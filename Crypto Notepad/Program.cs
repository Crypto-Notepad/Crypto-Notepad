using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    static class PublicVar
    {
        public static EncryptedString encryptionKey = new EncryptedString();
        public static bool randomizeSalts = true;
        public static bool keyChanged = false;
        public static bool settingsChanged = false;
        public static bool okPressed = false;
        public static string openFileName = "Crypto Notepad";
    }
    
    static class TypedPassword
    {
        public static string Value { get; set; }
    } 

}
