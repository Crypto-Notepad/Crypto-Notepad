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
        public static string encryptionKey { get; set; }
        public static bool keyChanged { get; set; }
        public static bool settingsChanged{ get; set; }
        public static bool okPressed { get; set; }
    }
}
