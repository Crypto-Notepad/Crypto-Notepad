using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
        public static bool keyChanged = false;
        public static bool okPressed = false;
        public const string appName = "Crypto Notepad";
        public static string openFileName;
    }

    static class TypedPassword
    {
        public static string Value { get; set; }
    } 

}
