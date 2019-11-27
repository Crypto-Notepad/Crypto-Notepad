using Crypto_Notepad.Properties;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Settings settings = Settings.Default;
            using (Mutex mutex = new Mutex(true, PublicVar.appName, out bool createdNew))
            {
                if (!settings.singleInstance)
                {
                    createdNew = true;
                }
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(
                    PublicVar.appName + " is already running.\nDo you still want to open a new copy of the app?", 
                    PublicVar.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 
                    MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new MainForm());
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        Process current = Process.GetCurrentProcess();
                        foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                        {
                            if (process.Id != current.Id)
                            {
                                SetForegroundWindow(process.MainWindowHandle);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }

    static class PublicVar
    {
        public static EncryptedString password = new EncryptedString();
        public static bool passwordChanged = false;
        public static bool okPressed = false;
        public static bool messageBoxCenterParent = false;       
        public const string appName = "Crypto Notepad";
        public static string openFileName;
        public static bool metadataCorrupt = false;
    }

    static class TypedPassword
    {
        public static string Value { get; set; }
    } 

}
