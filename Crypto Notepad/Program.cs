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
            Application.Run(new MainWindow());
        }
    }

    static class publicVar
    {
        public static string encryptionKey = "";
        public static bool keyChanged = false;
        public static bool settingsChanged = false;
        public static bool okPressed = false;
    }

}
