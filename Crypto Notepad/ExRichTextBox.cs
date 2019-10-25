using System;
using System.Drawing;
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

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!AutoWordSelection)
            {
                AutoWordSelection = true;
                AutoWordSelection = false;
            }
        }    
    }
    public static class RichTextBoxPadding
    {
        public static void SetInnerMargins(this TextBoxBase textBox, int left, int top, int right, int bottom)
        {
            var rect = textBox.GetFormattingRect();

            var newRect = new Rectangle(left, top, rect.Width - left - right, rect.Height - top - bottom);
            textBox.SetFormattingRect(newRect);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public readonly int Left;
            public readonly int Top;
            public readonly int Right;
            public readonly int Bottom;

            private RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom)
            {
            }
        }

        [DllImport(@"User32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessageRefRect(IntPtr hWnd, uint msg, int wParam, ref RECT rect);

        [DllImport(@"user32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, ref Rectangle lParam);

        private const int EmGetrect = 0xB2;
        private const int EmSetrect = 0xB3;

        private static void SetFormattingRect(this TextBoxBase textbox, Rectangle rect)
        {
            var rc = new RECT(rect);
            SendMessageRefRect(textbox.Handle, EmSetrect, 0, ref rc);
        }

        private static Rectangle GetFormattingRect(this TextBoxBase textbox)
        {
            var rect = new Rectangle();
            SendMessage(textbox.Handle, EmGetrect, (IntPtr)0, ref rect);
            return rect;
        }
    }
}

