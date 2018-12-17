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
            this.des.GenerateIV();
            this.des.GenerateKey();
            this.Set(String);
        }

        public EncryptedString()
        {
            this.des.GenerateIV();
            this.des.GenerateKey();
        }

        public string Get()
        {
            if (this.encryptedString == null) return null;
            var decryptor = this.des.CreateDecryptor();
            byte[] output = decryptor.TransformFinalBlock(this.encryptedString, 0, this.encryptedString.Length);
            return Encoding.Default.GetString(output);
        }

        public void Set(string String)
        {
            if (String == null) { this.encryptedString = null; return; }
            var encryptor = this.des.CreateEncryptor();
            byte[] str = Encoding.Default.GetBytes(String);
            this.encryptedString = encryptor.TransformFinalBlock(str, 0, str.Length);
        }
    }
}
