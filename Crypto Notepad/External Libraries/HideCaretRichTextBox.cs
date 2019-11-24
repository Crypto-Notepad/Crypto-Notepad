using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public class HideCaretRichTextBox : ExRichTextBox
    {
        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        private static extern long HideCaret(IntPtr hwnd);

        protected override void WndProc(ref Message m)
        {
            HideCaret(this.Handle);
            base.WndProc(ref m);
        }
    }
}
