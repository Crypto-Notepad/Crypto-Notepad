using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptPad
{
    class Encryption
    {
        public static string key = "";
        public static TripleDES Create3DES()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key));
            des.IV = new byte[des.BlockSize / 8];
            return des;
        }
        public static string EncrypTo3DES(string PlainText)
        {
            if (string.IsNullOrEmpty(PlainText))
            {
                return null;
            }
            TripleDES des = Create3DES();
            ICryptoTransform ct = des.CreateEncryptor();
            byte[] input = Encoding.Unicode.GetBytes(PlainText);
            byte[] resArr = ct.TransformFinalBlock(input, 0, input.Length);
            string result = Convert.ToBase64String(resArr);
            return result;
        }
        public static string DecryptFrom3Des(string CypherText)
        {
            if (string.IsNullOrEmpty(CypherText))
            {
                return null;
            }
            byte[] b = Convert.FromBase64String(CypherText);
            TripleDES des = Create3DES();
            ICryptoTransform ct = des.CreateDecryptor();
            byte[] output = ct.TransformFinalBlock(b, 0, b.Length);
            return Encoding.Unicode.GetString(output);
        }
    }
}
