using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    /// <summary>
    /// This class extracts information needed for decryption from a .cnp file
    /// </summary>
    class AESMetadata
    {
        /// <summary>
        /// Offset to actual AES data; size of metadata
        /// </summary>
        private int _offsetToData;
        public int offsetToData
        {
            get
            {
                return this._offsetToData;
            }
        }
        private byte[] _initialVector;
        public byte[] initialVector
        {
            get
            {
                return this._initialVector;
            }
        }
        private byte[] _salt;
        public byte[] salt
        {
            get
            {
                return this._salt;
            }
        }

        public AESMetadata()
        {
            this._initialVector = new byte[16];
            this._salt = null;
        }

        public void DeleteMetadataFromBuffer(ref byte[] rawData)
        {
            // Possibly unsafe
            byte[] buffer = new byte[rawData.Length - this.offsetToData];
            System.Buffer.BlockCopy(rawData, this.offsetToData, buffer, 0, rawData.Length - this.offsetToData);
            rawData = buffer;
        }

        public bool GetMetadata(byte[] rawData)
        {
            int index = 0;
            bool result = false;
            // Read initialVector
            for (int i = 0;
                index < rawData.Length;
                index++, i++)
            {
                if (rawData[index] == '\0') // Null terminator
                {
                    result = true;
                    index++;
                    break;
                }
                if (index < this.initialVector.Length)
                    this.initialVector[i] = rawData[index];
                else
                    break;
            }

            if (!result) return false;

            // This is kind of a dirty fix, but it gets the job done
            // Get length of salt
            int length = 0;
            for (int i = index;
                i < rawData.Length;
                i++)
            {
                if (rawData[i] == '\0') // Null terminator
                {
                    index++;
                    break;
                }
                length++;
            }
            // Copy bytes into this.salt
            this._salt = new byte[length];
            System.Buffer.BlockCopy(rawData, index - 1, this.salt, 0, length);

            this._offsetToData = this.salt.Length + 1 + this.initialVector.Length + 1;

            return true;
        }
    }

    class AES
    {
        public static string Encrypt(string plainText, string password,
        string salt = null, string hashAlgorithm = "SHA1",
        int passwordIterations = 2, int keySize = 256)
        {
            if (string.IsNullOrEmpty(plainText))
                return "";

            byte[] plainTextBytes;
            byte[] saltValueBytes;

            // In case user wants a random salt or salt is null/empty for some other reason
            if (string.IsNullOrEmpty(salt))
            {
                saltValueBytes = new byte[64]; // Nice and long
                RandomNumberGenerator rng = RandomNumberGenerator.Create();
                rng.GetNonZeroBytes(saltValueBytes);
            }
            else
            {
                saltValueBytes = Encoding.ASCII.GetBytes(salt);
            }

            plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes
             (password, saltValueBytes, hashAlgorithm, passwordIterations);

            // Null password; adds *some* memory dump protection
            password = null;

            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            symmetricKey.GenerateIV();

            byte[] cipherTextBytes = null;

            using (MemoryStream memStream = new MemoryStream())
            {
                byte[] nullByte = { 0 };
                memStream.Write(symmetricKey.IV, 0, symmetricKey.IV.Length);
                memStream.Write(nullByte, 0, 1);
                memStream.Write(saltValueBytes, 0, saltValueBytes.Length);
                memStream.Write(nullByte, 0, 1);

                using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor
                (keyBytes, symmetricKey.IV))
                {
                    using (CryptoStream cryptoStream = new CryptoStream
                             (memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Dispose();
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string cipherText, string password, string salt = "Kosher",
        string hashAlgorithm = "SHA1",
        int passwordIterations = 2,
        int keySize = 256)
        {
            if (string.IsNullOrEmpty(cipherText))
                return null;

            byte[] initialVectorBytes;
            byte[] saltValueBytes;
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

            // Extract metadata from file
            AESMetadata metadata = new AESMetadata();
            if (!metadata.GetMetadata(cipherTextBytes))
            {
                // Metadata parsing error
                DialogResult result = MessageBox.Show("Unable to parse file metadata.\nAttempt to open anyway?\n(May result in a \'Incorrect Key\' error if the salt is wrong.)",
                "Missing or Corrupted Metadata", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    // Default initialization vector from builds v1.1.2 and older
                    const string default_IV = "16CHARSLONG12345";

                    initialVectorBytes = Encoding.ASCII.GetBytes(default_IV);
                    saltValueBytes = Encoding.ASCII.GetBytes(salt);
                }
                else { return null; }
            }
            else
            {
                saltValueBytes = metadata.salt;
                initialVectorBytes = metadata.initialVector;
                metadata.DeleteMetadataFromBuffer(ref cipherTextBytes);
            }

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes
                (password, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount = 0;

            using (MemoryStream memStream = new MemoryStream(cipherTextBytes))
            {
                using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor
                         (keyBytes, initialVectorBytes))
                {
                    using (CryptoStream cryptoStream
                    = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }

                symmetricKey.Dispose();
            }
            
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }
    }
}
