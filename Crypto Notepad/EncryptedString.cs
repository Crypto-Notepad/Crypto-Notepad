using System.Text;
using System.Security.Cryptography;

namespace Crypto_Notepad
{
    /// <summary>
    /// Stores a string encrypted in memory to defend against memory dumps
    /// </summary>
    class EncryptedString
    {
        private TripleDES des = TripleDESCryptoServiceProvider.Create();
        private byte[] encryptedString = null;

        public EncryptedString(string String)
        {
            des.GenerateIV();
            des.GenerateKey();
            Set(String);
        }

        public EncryptedString()
        {
            des.GenerateIV();
            des.GenerateKey();
        }

        public string Get()
        {
            if (encryptedString == null) return null;
            var decryptor = des.CreateDecryptor();
            byte[] output = decryptor.TransformFinalBlock(encryptedString, 0, encryptedString.Length);
            return Encoding.Default.GetString(output);
        }

        public void Set(string String)
        {
            if (String == null) { encryptedString = null; return; }
            var encryptor = des.CreateEncryptor();
            byte[] str = Encoding.Default.GetBytes(String);
            encryptedString = encryptor.TransformFinalBlock(str, 0, str.Length);
        }
    }
}
