using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public class ExRichTextBox : RichTextBox
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        private const int WM_VSCROLL = 0x115;
        private const int WM_MOUSEWHEEL = 0x20A;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEWHEEL)
            {
                int scrollLines = SystemInformation.MouseWheelScrollLines;
                for (int i = 0; i < scrollLines; i++)
                {
                    try
                    {
                        if ((int)m.WParam >= 0)
                            SendMessage(Handle, WM_VSCROLL, (IntPtr)0, IntPtr.Zero);
                        else
                            SendMessage(Handle, WM_VSCROLL, (IntPtr)1, IntPtr.Zero);
                    }
                    catch (OverflowException)
                    {
                        SendMessage(Handle, WM_VSCROLL, (IntPtr)1, IntPtr.Zero);
                    }
                }
                return;
            }
            base.WndProc(ref m);
        }

    }
}
