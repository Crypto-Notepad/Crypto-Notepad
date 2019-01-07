using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using File = System.IO.File;

namespace Crypto_Notepad
{
    public partial class MainForm : Form
    {
        Properties.Settings ps = Properties.Settings.Default;
        string filePath = "";
        string[] args = Environment.GetCommandLineArgs();
        int caretPos = 0;
        string appName = Assembly.GetExecutingAssembly().GetName().Name + " – ";
        string currentFilename = "";
        bool shiftPresed;
        bool cancelPressed = false;
        bool noExit = false;
        string argsPath = "";

        public MainForm()
        {
            InitializeComponent();
            CustomRTB.DragDrop += new DragEventHandler(CustomRTB_DragDrop);
            CustomRTB.AllowDrop = true;
        }

        /*Functions*/
        private void DecryptAES()
        {
            EnterKeyForm f2 = new EnterKeyForm();
            f2.ShowDialog();
            if (!PublicVar.okPressed)
            {
                return;
            }
            if (SearchPanel.Visible)
            {
                FindToolStripMenuItem_Click(this, new EventArgs());
            }
            try
            {
                string opnfile = File.ReadAllText(OpenFile.FileName);
                string NameWithotPath = Path.GetFileName(OpenFile.FileName);
                string de;

                if (ps.TheSalt != null)
                {
                     de = AES.Decrypt(opnfile, TypedPassword.Value, ps.TheSalt, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
                }
                else
                {
                     de = AES.Decrypt(opnfile, TypedPassword.Value, null, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
                }

                CustomRTB.Text = de;

                Text = appName + NameWithotPath;
                filePath = OpenFile.FileName;
                string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                CustomRTB.Select(Convert.ToInt32(cc2), 0);

                PublicVar.openFileName = Path.GetFileName(OpenFile.FileName);
                currentFilename = Path.GetFileName(OpenFile.FileName);
                PublicVar.encryptionKey.Set(TypedPassword.Value);
                TypedPassword.Value = null;
            }
            catch (CryptographicException)
            {
                using (new CenterWinDialog(this))
                {
                    TypedPassword.Value = null;
                    DialogResult dialogResult = MessageBox.Show("Invalid key!", PublicVar.appName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Retry)
                    {
                        DecryptAES();
                    }
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
        }

        private void OpenAsotiations()
        {
            EnterKeyForm Form2 = new EnterKeyForm();
            Form2.StartPosition = FormStartPosition.CenterScreen;
            string fileExtension = Path.GetExtension(args[1]);

            if (fileExtension == ".cnp")
            {
                try
                {
                    string NameWithotPath = Path.GetFileName(args[1]);
                    string opnfile = File.ReadAllText(args[1]);

                    Form2.ShowDialog();
                    if (!PublicVar.okPressed)
                    {
                        OpenFile.FileName = "";
                        return;
                    }
                    PublicVar.okPressed = false;

                    string de = AES.Decrypt(opnfile, TypedPassword.Value, null, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
                    CustomRTB.Text = de;

                    Text = PublicVar.appName + " – " + NameWithotPath;

                    filePath = args[1];
                    string cc = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                    PublicVar.encryptionKey.Set(TypedPassword.Value);
                    CustomRTB.Select(Convert.ToInt32(cc), 0);
                    TypedPassword.Value = null;
                }
                catch (CryptographicException)
                {
                    TypedPassword.Value = null;
                    DialogResult dialogResult = MessageBox.Show("Invalid key!", PublicVar.appName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Retry)
                    {
                        OpenAsotiations();
                    }
                }

            }
            else
            {
                string opnfile = File.ReadAllText(args[1]);
                string NameWithotPath = Path.GetFileName(args[1]);
                CustomRTB.Text = opnfile;
                Text = PublicVar.appName + " – " + NameWithotPath;
                string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                CustomRTB.Select(Convert.ToInt32(cc2), 0);
            }

            currentFilename = Path.GetFileName(args[1]);
        }

        private void SendTo()
        {
            EnterKeyForm f2 = new EnterKeyForm();
            f2.StartPosition = FormStartPosition.CenterScreen;
            string fileExtension = Path.GetExtension(argsPath);

            if (fileExtension == ".cnp")
            {
                try
                {
                    string NameWithotPath = Path.GetFileName(argsPath);
                    string opnfile = File.ReadAllText(argsPath);

                    f2.ShowDialog();
                    if (!PublicVar.okPressed)
                    {
                        OpenFile.FileName = "";
                        return;
                    }
                    PublicVar.okPressed = false;
                    string de = AES.Decrypt(opnfile, TypedPassword.Value, null, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
                    CustomRTB.Text = de;

                    Text = PublicVar.appName + " – " + NameWithotPath;

                    filePath = argsPath;
                    string cc = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                    CustomRTB.Select(Convert.ToInt32(cc), 0);
                    PublicVar.encryptionKey.Set(TypedPassword.Value);
                    currentFilename = Path.GetFileName(argsPath);
                    TypedPassword.Value = null;
                }
                catch (CryptographicException)
                {
                    TypedPassword.Value = null;
                    DialogResult dialogResult = MessageBox.Show("Invalid key!", PublicVar.appName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Retry)
                    {
                        SendTo();
                    }
                }

            }
            else
            {
                string opnfile = File.ReadAllText(argsPath);
                string NameWithotPath = Path.GetFileName(argsPath);
                CustomRTB.Text = opnfile;
                Text = PublicVar.appName + " – " + NameWithotPath;
                string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                CustomRTB.Select(Convert.ToInt32(cc2), 0);
            }
        }

        private void SendToShortcut()
        {
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\SendTo";
            string shortcutName = PublicVar.appName + ".lnk";
            string shortcutLocation = Path.Combine(shortcutPath, shortcutName);
            string targetFileLocation = Assembly.GetEntryAssembly().Location;

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.Description = PublicVar.appName;
            shortcut.IconLocation = targetFileLocation;
            shortcut.TargetPath = targetFileLocation;
            shortcut.Arguments = "/s";
            shortcut.Save();
        }

        private void ContextMenuEncryptReplace()
        {
            PublicVar.openFileName = Path.GetFileName(args[1]);

            if (args[1].Contains(".cnp"))
            {
                MessageBox.Show("Looks like this file is already encrypted", PublicVar.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("This action will delete the source file and replace it with encrypted version", PublicVar.appName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }

            if (!args[1].Contains(".cnp"))
            {
                string opnfile = File.ReadAllText(args[1]);
                CustomRTB.Text = opnfile;
                string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                CustomRTB.Select(Convert.ToInt32(cc2), 0);
                currentFilename = Path.GetFileName(args[1]);
                string newFile = Path.GetDirectoryName(args[1]) + @"\" + Path.GetFileNameWithoutExtension(args[1]) + ".cnp";

                EnterKeyForm f2 = new EnterKeyForm();
                f2.ShowDialog();
                if (!PublicVar.okPressed)
                {
                    Application.Exit();
                }
                PublicVar.okPressed = false;

                File.Delete(args[1]);

                string noenc = CustomRTB.Text;
                string en;
                en = AES.Encrypt(CustomRTB.Text, TypedPassword.Value, null, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
                CustomRTB.Text = en;
                StreamWriter sw = new StreamWriter(newFile);
                int i = CustomRTB.Lines.Count();
                int j = 0;
                i = i - 1;
                while (j <= i)
                {
                    sw.WriteLine(CustomRTB.Lines.GetValue(j).ToString());
                    j = j + 1;
                }
                sw.Close();
                PublicVar.encryptionKey.Set(TypedPassword.Value);
                TypedPassword.Value = null;
                filePath = newFile;
                currentFilename = Path.GetFileName(newFile);
                CustomRTB.Text = noenc;
            }

            #region workaround, strange behavior with the cursor in customRTB fix
            CustomRTB.DetectUrls = false;
            CustomRTB.DetectUrls = true;
            CustomRTB.Modified = false;
            #endregion

            if (PublicVar.okPressed)
            {
                PublicVar.okPressed = false;
            }
        }

        private void ContextMenuEncrypt()
        {
            PublicVar.openFileName = Path.GetFileName(args[1]);
            if (!args[1].Contains(".cnp"))
            {
                string opnfile = File.ReadAllText(args[1]);
                string NameWithotPath = Path.GetFileName(args[1]);
                CustomRTB.Text = opnfile;
                Text = PublicVar.appName + NameWithotPath;
                string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                CustomRTB.Select(Convert.ToInt32(cc2), 0);
                currentFilename = Path.GetFileName(args[1]);
                filePath = OpenFile.FileName;
            }

            #region workaround, strange behavior with the cursor in customRTB fix
            CustomRTB.DetectUrls = false;
            CustomRTB.DetectUrls = true;
            #endregion

            CustomRTB.Modified = false;

            if (PublicVar.okPressed)
            {
                PublicVar.okPressed = false;
            }
        }

        private void DeleteUpdateFiles()
        {
            string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";
            string UpdaterExe = exePath + "Updater.exe";
            string UpdateZip = exePath + "Crypto-Notepad-Update.zip";
            string ZipDll = exePath + "Ionic.Zip.dll";

            if (File.Exists(UpdaterExe))
            {
                File.Delete(UpdaterExe);
            }

            if (File.Exists(UpdateZip))
            {
                File.Delete(UpdateZip);
            }

            if (File.Exists(ZipDll))
            {
                File.Delete(ZipDll);
            }
        }

        private void SaveConfirm(bool exit)
        {
            if (!CustomRTB.Modified)
            {
                if (exit)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                if (currentFilename == "")
                {
                    currentFilename = "Unnamed.cnp";
                }

                if (CustomRTB.Text != "")
                {
                    string messageBoxText = "";

                    if (!PublicVar.keyChanged)
                    {
                        messageBoxText = "Save file: " + "\"" + currentFilename + "\"" + " ? ";
                    }
                    else
                    {
                        messageBoxText = "Save file: " + "\"" + currentFilename + "\"" + " with a new key? ";
                    }

                    using (new CenterWinDialog(this))
                    {
                        DialogResult res = MessageBox.Show(messageBoxText, PublicVar.appName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            SaveToolStripMenuItem_Click(this, new EventArgs());
                            if (exit)
                            {
                                Environment.Exit(0);
                            }

                        }

                        if (res == DialogResult.No)
                        {
                            if (exit)
                            {
                                Environment.Exit(0);
                            }
                        }

                        if (res == DialogResult.Cancel)
                        {
                            noExit = true;
                            cancelPressed = true;
                            return;
                        }
                    }
                }
            }
        }

        private void CheckForUpdates(bool autoCheck)
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/version.txt");
                StreamReader reader = new StreamReader(stream);
                string content = reader.ReadToEnd();
                string version = Application.ProductVersion;
                string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";

                int appVersion = Convert.ToInt32(version.Replace(".", "")), serverVersion = Convert.ToInt32(content.Replace(".", ""));

                if (serverVersion > appVersion)
                {
                    MainMenu.Invoke((Action)delegate
                    {
                        using (new CenterWinDialog(this))
                        {
                            DialogResult res = MessageBox.Show("New version is available. Install it now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (res == DialogResult.Yes)
                            {
                                File.WriteAllBytes(exePath + "Ionic.Zip.dll", Properties.Resources.Ionic_Zip);
                                File.WriteAllBytes(exePath + "Updater.exe", Properties.Resources.Updater);

                                var pr = new Process();
                                pr.StartInfo.FileName = exePath + "Updater.exe";
                                pr.StartInfo.Arguments = "/u";
                                pr.Start();
                                Application.Exit();
                            }
                        }
                    });
                }

                if (serverVersion <= appVersion && autoCheck)
                {
                    MainMenu.Invoke((Action)delegate
                    {
                        using (new CenterWinDialog(this))
                        {
                            MessageBox.Show("Crypto Notepad is up to date.", PublicVar.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    });
                }

            }
            catch
            {
                return;
            }
        }

        private void AutoLock(bool minimize)
        {
            EnterKeyForm f2 = new EnterKeyForm();
            PublicVar.encryptionKey.Set(null);
            caretPos = CustomRTB.SelectionStart;
            f2.MinimizeBox = true;
            Hide();

            if (minimize)
            {
                f2.WindowState = FormWindowState.Minimized;
            }
            f2.ShowDialog();

            if (!PublicVar.okPressed)
            {
                PublicVar.encryptionKey.Set(null);
                CustomRTB.Clear();
                Text = PublicVar.appName;
                PublicVar.openFileName = null;
                filePath = "";
                Show();
                return;
            }
            PublicVar.okPressed = false;

            try
            {
                CustomRTB.Clear();
                string opnfile = File.ReadAllText(filePath);
                string de = AES.Decrypt(opnfile, TypedPassword.Value, null, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
                CustomRTB.Text = de;
                Text = PublicVar.appName + " – " + PublicVar.openFileName;
                string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                CustomRTB.Select(Convert.ToInt32(cc2), 0);
                CustomRTB.SelectionStart = caretPos;
                PublicVar.encryptionKey.Set(TypedPassword.Value);
                TypedPassword.Value = null;
                Show();
            }
            catch (Exception ex)
            {
                if (ex is CryptographicException)
                {
                    TypedPassword.Value = null;
                    DialogResult dialogResult = MessageBox.Show("Invalid key!", PublicVar.appName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Retry)
                    {
                        AutoLock(false);
                    }
                    if (dialogResult == DialogResult.Cancel)
                    {
                        PublicVar.encryptionKey.Set(null);
                        CustomRTB.Clear();
                        Text = PublicVar.appName;
                        filePath = "";
                        currentFilename = "";
                        Show();
                        return;
                    }
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x112;
            const int SC_MINIMIZE = 0xF020;

            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == SC_MINIMIZE && ps.AutoLock && PublicVar.encryptionKey.Get() != null)
            {
                if (ps.AutoSave)
                {
                    SaveToolStripMenuItem_Click(this, new EventArgs());
                }
                else
                {
                    SaveConfirm(false);
                }
                AutoLock(true);
                return;
            }
            base.WndProc(ref m);
        }

        private void MenuIcons()
        {
            if (ps.MenuIcons)
            {
                NewToolStripMenuItem.Image = Properties.Resources.document_plus;
                OpenToolStripMenuItem.Image = Properties.Resources.folder_open_document;
                SaveToolStripMenuItem.Image = Properties.Resources.disk_return_black;
                SaveAsToolStripMenuItem.Image = Properties.Resources.disks_black;
                OpenFileLocationToolStripMenuItem.Image = Properties.Resources.folder_horizontal;
                DeleteFileToolStripMenuItem.Image = Properties.Resources.document_minus;
                ExitToolStripMenuItem.Image = Properties.Resources.cross_button;

                UndoToolStripMenuItem.Image = Properties.Resources.arrow_left;
                RedoToolStripMenuItem.Image = Properties.Resources.arrow_right;
                CutToolStripMenuItem.Image = Properties.Resources.scissors;
                CopyToolStripMenuItem.Image = Properties.Resources.document_copy;
                PasteToolStripMenuItem.Image = Properties.Resources.clipboard;
                DeleteToolStripMenuItem.Image = Properties.Resources.minus;
                FindToolStripMenuItem.Image = Properties.Resources.magnifier;
                SelectAllToolStripMenuItem.Image = Properties.Resources.selection_input;
                WordWrapToolStripMenuItem.Image = Properties.Resources.wrap_option;
                ClearToolStripMenuItem.Image = Properties.Resources.document;

                ChangeKeyToolStripMenuItem.Image = Properties.Resources.key;
                LockToolStripMenuItem.Image = Properties.Resources.lock_warning;
                SettingsToolStripMenuItem.Image = Properties.Resources.gear;

                DocumentationToolStripMenuItem.Image = Properties.Resources.document_text;
                CheckForUpdatesToolStripMenuItem.Image = Properties.Resources.upload_cloud;
                AboutToolStripMenuItem.Image = Properties.Resources.information;
            }
            else
            {
                foreach (ToolStripItem item in MainMenu.Items)
                {
                    if (item is ToolStripDropDownItem)
                        foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)item).DropDownItems)
                        {
                            dropDownItem.Image = null;
                        }
                }
            }
        }
        /*Functions*/


        /*Form Events*/
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            if (PublicVar.settingsChanged)
            {
                PublicVar.settingsChanged = false;
                CustomRTB.Font = new Font(ps.RichTextFont, ps.RichTextSize);
                CustomRTB.ForeColor = ps.RichForeColor;
                CustomRTB.BackColor = ps.RichBackColor;
                BackColor = ps.RichBackColor;

                if (ps.SendTo)
                {
                    SendToShortcut();
                }
                else
                {
                    string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\SendTo\Crypto Notepad.lnk";
                    if (File.Exists(shortcutPath))
                    {
                        File.Delete(shortcutPath);
                    }
                }

                #region  workaround, unhighlight URLs fix
                CustomRTB.DetectUrls = false;
                CustomRTB.DetectUrls = true;
                #endregion

                if (!ps.ShowToolbar && ToolbarPanel.Visible)
                {
                    ToolbarPanel.Visible = false;
                    CustomRTB.Height += 23;
                    CustomRTB.Location = new Point(0, 24);
                }
                if (ps.ShowToolbar && !ToolbarPanel.Visible)
                {
                    ToolbarPanel.Visible = true;
                    CustomRTB.Height -= 23;
                    CustomRTB.Location = new Point(0, 47);
                }

                MenuIcons();

                if (ps.ColoredToolbar)
                {
                    ToolbarPanel.BackColor = ps.RichBackColor;
                    ToolbarPanel.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    ToolbarPanel.BackColor = SystemColors.ButtonFace;
                    ToolbarPanel.BorderStyle = BorderStyle.None;
                }

            }

            if (PublicVar.keyChanged)
            {
                CustomRTB.Modified = true;
            }

            if (PublicVar.encryptionKey.Get() == null)
            {
                FileLocationToolbarButton.Enabled = false;
                DeleteFileToolbarButton.Enabled = false;
                ChangeKeyToolbarButton.Enabled = false;
                LockToolbarButton.Enabled = false;
            }
            else
            {
                FileLocationToolbarButton.Enabled = true;
                DeleteFileToolbarButton.Enabled = true;
                ChangeKeyToolbarButton.Enabled = true;
                LockToolbarButton.Enabled = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                ps.WindowSize = Size;
                ps.WindowLocation = Location;
                ps.WindowState = WindowState;
            }

            if (WindowState == FormWindowState.Maximized)
            {
                ps.WindowState = WindowState;
            }

            ps.Save();
            SaveConfirm(true);

            if (noExit)
            {
                e.Cancel = true;
            }
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            string pos = ps.WindowLocation.ToString();
            CustomRTB.Font = new Font(ps.RichTextFont, ps.RichTextSize);
            CustomRTB.ForeColor = ps.RichForeColor;
            CustomRTB.BackColor = ps.RichBackColor;
            BackColor = ps.RichBackColor;
            WordWrapToolStripMenuItem.Checked = ps.MenuWrap;
            CustomRTB.WordWrap = ps.RichWrap;
            ToolbarPanel.Visible = ps.ShowToolbar;

            if (ps.ColoredToolbar)
            {
                ToolbarPanel.BackColor = ps.RichBackColor;
                ToolbarPanel.BorderStyle = BorderStyle.FixedSingle;
            }

            if (!ps.ShowToolbar)
            {
                ToolbarPanel.Visible = false;

                CustomRTB.Height += 23;
                CustomRTB.Location = new Point(0, 24);
            }
            else
            {
                ToolbarPanel.Visible = true;
            }

            if (ps.AutoCheckUpdate)
            {
                Thread up = new Thread(() => CheckForUpdates(false));
                up.Start();
            }

            MenuIcons();
            DeleteUpdateFiles();

            if (args.Contains("/s")) /*send to*/
            {
                foreach (var arg in args)
                {
                    argsPath = arg;
                }
                SendTo();
            }

            if (args.Contains("/o"))  /*decrypt & open cnp*/
            {
                OpenAsotiations();
            }

            if (args.Contains("/e")) /*encrypt*/
            {
                ContextMenuEncrypt();
            }

            if (args.Contains("/er")) /*encrypt and replace*/
            {
                ContextMenuEncryptReplace();
            }

            if (pos != "{X=0,Y=0}")
            {
                Location = ps.WindowLocation;
            }

            Size = ps.WindowSize;
            WindowState = ps.WindowState;

#if DEBUG
            DebugToolStripMenuItem.Visible = true;
#endif
        }
        /*Form Events*/


        /*CustomRTB Events*/
        private void CustomRTB_SelectionChanged_1(object sender, EventArgs e)
        {
            if (CustomRTB.SelectionLength != 0)
            {
                CutToolbarButton.Enabled = true;
                CopyToolbarButton.Enabled = true;
            }
            else
            {
                CutToolbarButton.Enabled = false;
                CopyToolbarButton.Enabled = false;
            }
        }

        private void CustomRTB_Click(object sender, EventArgs e)
        {
            caretPos = CustomRTB.SelectionStart;
        }

        private void CustomRTB_KeyDown(object sender, KeyEventArgs e)
        {
            caretPos = CustomRTB.SelectionStart;
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftPresed = true;
            }
        }

        private void СustomRTB_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (shiftPresed)
            {
                shiftPresed = false;
                Process.Start(e.LinkText);
            }
        }

        private void CustomRTB_DragDrop(object sender, DragEventArgs e)
        {
            SaveConfirm(false);
            if (cancelPressed)
            {
                cancelPressed = false;
                return;
            }

            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in FileList) OpenFile.FileName = file;
            object fname = e.Data.GetData("FileDrop");
            if (fname != null)
            {
                var list = fname as string[];
                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    if (!OpenFile.FileName.Contains(".cnp"))
                    {
                        string opnfile = File.ReadAllText(OpenFile.FileName);
                        string NameWithotPath = Path.GetFileName(OpenFile.FileName);
                        CustomRTB.Text = opnfile;
                        Text = PublicVar.appName + " – " + NameWithotPath;
                        string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                        CustomRTB.Select(Convert.ToInt32(cc2), 0);
                        currentFilename = Path.GetFileName(OpenFile.FileName);
                        filePath = OpenFile.FileName;
                        return;
                    }
                    PublicVar.openFileName = Path.GetFileName(OpenFile.FileName);
                    DecryptAES();
                    if (PublicVar.okPressed)
                    {
                        PublicVar.okPressed = false;
                    }
                }
            }
        }

        private void CustomRTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftPresed = false;
            }
        }

        private void CustomRTB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CustomRTB_TextChanged(object sender, EventArgs e)
        {

        }
        /*CustomRTB Events*/


        /* Main Menu */

        /*File*/
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfirm(false);
            SaveFile.FileName = "Unnamed.cnp";
            PublicVar.openFileName = "Crypto Notepad";
            EnterKeyForm f2 = new EnterKeyForm();
            f2.ShowDialog();
            PublicVar.encryptionKey.Set(TypedPassword.Value);

            if (!PublicVar.okPressed)
            {
                TypedPassword.Value = null;
                return;
            }
            else
            {
                PublicVar.okPressed = false;
                if (SaveFile.ShowDialog() != DialogResult.OK)
                {
                    TypedPassword.Value = null;
                    return;
                }

                CustomRTB.Clear();
                StreamWriter sw = new StreamWriter(SaveFile.FileName);
                string NameWithotPath = Path.GetFileName(SaveFile.FileName);
                Text = PublicVar.appName + " – " + NameWithotPath;
                filePath = SaveFile.FileName;
                currentFilename = Path.GetFileName(SaveFile.FileName);
                sw.Close();
            }
            TypedPassword.Value = null;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile.FileName = "";
            SaveConfirm(false);
            if (cancelPressed)
            {
                cancelPressed = false;
                return;
            }

            if (OpenFile.ShowDialog() != DialogResult.OK) return;
            {
                PublicVar.openFileName = Path.GetFileName(OpenFile.FileName);
                if (!OpenFile.FileName.Contains(".cnp"))
                {
                    string opnfile = File.ReadAllText(OpenFile.FileName);
                    string NameWithotPath = Path.GetFileName(OpenFile.FileName);
                    CustomRTB.Text = opnfile;
                    Text = PublicVar.appName + " – " + NameWithotPath;
                    string cc2 = CustomRTB.Text.Length.ToString(CultureInfo.InvariantCulture);
                    CustomRTB.Select(Convert.ToInt32(cc2), 0);
                    return;
                }
                DecryptAES();

                #region workaround, strange behavior with the cursor in customRTB fix
                CustomRTB.DetectUrls = false;
                CustomRTB.DetectUrls = true;
                #endregion

                CustomRTB.Modified = false;

                if (PublicVar.okPressed)
                {
                    PublicVar.okPressed = false;
                }

                if (PublicVar.encryptionKey.Get() == null)
                {
                    FileLocationToolbarButton.Enabled = false;
                    DeleteFileToolbarButton.Enabled = false;
                    ChangeKeyToolbarButton.Enabled = false;
                    LockToolbarButton.Enabled = false;
                }
                else
                {
                    FileLocationToolbarButton.Enabled = true;
                    DeleteFileToolbarButton.Enabled = true;
                    ChangeKeyToolbarButton.Enabled = true;
                    LockToolbarButton.Enabled = true;
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int saveCaret = CustomRTB.SelectionStart;

            if (PublicVar.encryptionKey.Get() == null)
            {
                SaveFile.FileName = "Unnamed.cnp";
                SaveAsToolStripMenuItem_Click(this, new EventArgs());
                if (!PublicVar.okPressed)
                {
                    return;
                }
                PublicVar.okPressed = false;
            }

            string noenc = CustomRTB.Text;
            string en;

            en = AES.Encrypt(CustomRTB.Text, PublicVar.encryptionKey.Get(), null, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
            CustomRTB.Text = en;

            StreamWriter sw = new StreamWriter(filePath);
            int i = CustomRTB.Lines.Count();
            int j = 0;
            i = i - 1;

            while (j <= i)
            {
                sw.WriteLine(CustomRTB.Lines.GetValue(j).ToString());
                j = j + 1;
            }
            sw.Close();

            CustomRTB.Text = noenc;
            CustomRTB.Select(Convert.ToInt32(saveCaret), 0);
            PublicVar.keyChanged = false;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int saveCaret = CustomRTB.SelectionStart;
            string NameWithotPath = Path.GetFileName(OpenFile.FileName);
            SaveFile.FileName = currentFilename;
            EnterKeyForm f2 = new EnterKeyForm();

            if (string.IsNullOrEmpty(PublicVar.encryptionKey.Get()))
            {
                f2.ShowDialog();
                if (!PublicVar.okPressed)
                {
                    return;
                }
                PublicVar.okPressed = false;
            }

            if (SaveFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (TypedPassword.Value == null)
            {
                TypedPassword.Value = PublicVar.encryptionKey.Get();
            }

            filePath = SaveFile.FileName;
            string noenc = CustomRTB.Text;
            string en;
            en = AES.Encrypt(CustomRTB.Text, TypedPassword.Value, null, ps.HashAlgorithm, ps.PasswordIterations, ps.KeySize);
            CustomRTB.Text = en;
            StreamWriter sw = new StreamWriter(filePath);
            int i = CustomRTB.Lines.Count();
            int j = 0;
            i = i - 1;
            while (j <= i)
            {
                sw.WriteLine(CustomRTB.Lines.GetValue(j).ToString());
                j = j + 1;
            }
            sw.Close();
            CustomRTB.Text = noenc;
            Text = PublicVar.appName + " – " + Path.GetFileName(filePath);
            CustomRTB.Select(Convert.ToInt32(saveCaret), 0);
            PublicVar.encryptionKey.Set(TypedPassword.Value);
            TypedPassword.Value = null;
            currentFilename = Path.GetFileName(SaveFile.FileName);
        }

        private void OpenFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"/select, " + filePath);
        }

        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                using (new CenterWinDialog(this))
                {
                    if (MessageBox.Show("Delete file: " + "\"" + filePath + "\"" + " ?", PublicVar.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(filePath);
                        CustomRTB.Clear();
                        PublicVar.encryptionKey.Set(null);
                        FileLocationToolbarButton.Enabled = false;
                        DeleteFileToolbarButton.Enabled = false;
                        ChangeKeyToolbarButton.Enabled = false;
                        LockToolbarButton.Enabled = false;
                        filePath = "";
                        Text = PublicVar.appName;
                        return;
                    }
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (currentFilename == "")
            {
                OpenFileLocationToolStripMenuItem.Enabled = false;
                DeleteFileToolStripMenuItem.Enabled = false;
            }
            else
            {
                OpenFileLocationToolStripMenuItem.Enabled = true;
                DeleteFileToolStripMenuItem.Enabled = true;
            }
        }
        /*File*/

        /*Edit*/
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CustomRTB.Undo();
        }

        public void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomRTB.Redo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomRTB.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomRTB.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CustomRTB.Focused)
            {
                CustomRTB.Paste(DataFormats.GetFormat(DataFormats.Text));
            }
            if (SearchTextBox.Focused)
            {
                SearchTextBox.Paste();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomRTB.SelectedText = "";
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SearchPanel.Visible)
            {
                SearchTextBox.Text = "";
                SearchPanel.Visible = false;
                CustomRTB.Height += 27;
                CustomRTB.Focus();
                CustomRTB.DeselectAll();
                CustomRTB.SelectionStart = caretPos;
            }
            else
            {
                SearchPanel.Visible = true;
                SearchTextBox.Focus();
                CustomRTB.Height -= 27;
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CustomRTB.Focused)
            {
                CustomRTB.SelectAll();
            }
            if (SearchTextBox.Focused)
            {
                SearchTextBox.SelectAll();
            }
        }

        private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WordWrapToolStripMenuItem.Checked)
            {
                CustomRTB.WordWrap = true;
            }
            else
            {
                CustomRTB.WordWrap = false;
            }
            ps.MenuWrap = WordWrapToolStripMenuItem.Checked;
            ps.RichWrap = CustomRTB.WordWrap;
            ps.Save();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomRTB.Clear();
        }

        private void EditToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (CustomRTB.SelectionLength != 0)
            {
                CutToolStripMenuItem.Enabled = true;
                CopyToolStripMenuItem.Enabled = true;
                DeleteToolStripMenuItem.Enabled = true;
            }
            else
            {
                CutToolStripMenuItem.Enabled = false;
                CopyToolStripMenuItem.Enabled = false;
                DeleteToolStripMenuItem.Enabled = false;
            }
        }
        /*Edit*/

        /*Tools*/
        private void ChangeKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeKeyForm c = new ChangeKeyForm();
            c.ShowDialog(this);
        }

        private void LockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ps.AutoSave)
            {
                SaveToolStripMenuItem_Click(this, new EventArgs());
            }
            else
            {
                SaveConfirm(false);
            }
            AutoLock(false);
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        private void ToolsToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (PublicVar.encryptionKey.Get() == null)
            {
                ChangeKeyToolStripMenuItem.Enabled = false;
                LockToolStripMenuItem.Enabled = false;
            }
            else
            {
                ChangeKeyToolStripMenuItem.Enabled = true;
                LockToolStripMenuItem.Enabled = true;
            }
        }
        /*Tools*/

        /*Help*/
        private void DocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Crypto-Notepad/Crypto-Notepad/wiki/Documentation");
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread up = new Thread(() => CheckForUpdates(true));
            up.Start();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFrom a = new AboutFrom();
            a.ShowDialog(this);
        }
        /*Help*/

        /* Main Menu */


        /* Editor Menu */
        private void UndoEditorMenuStrip_Click(object sender, EventArgs e)
        {
            UndoToolStripMenuItem_Click(this, new EventArgs());
        }

        private void RedoEditorMenuStrip_Click(object sender, EventArgs e)
        {
            RedoToolStripMenuItem_Click(this, new EventArgs());
        }

        private void CutEditorMenuStrip_Click(object sender, EventArgs e)
        {
            CutToolStripMenuItem_Click(this, new EventArgs());
        }

        private void CopyEditorMenuStrip_Click(object sender, EventArgs e)
        {
            CopyToolStripMenuItem_Click(this, new EventArgs());
        }

        private void PasteEditorMenuStrip_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(this, new EventArgs());
        }

        private void DeleteEditorMenuStrip_Click(object sender, EventArgs e)
        {
            DeleteToolStripMenuItem_Click(this, new EventArgs());
        }

        private void SelectAllEditorMenuStrip_Click(object sender, EventArgs e)
        {
            SelectAllToolStripMenuItem_Click(this, new EventArgs());
        }

        private void RightToLeftEditorMenuStrip_Click(object sender, EventArgs e)
        {
            if (RightToLeftEditorMenuStrip.Checked)
            {
                if (!WordWrapToolStripMenuItem.Checked)
                {
                    string rtbTxt = CustomRTB.Text;
                    CustomRTB.Clear();
                    CustomRTB.RightToLeft = RightToLeft.Yes;
                    Application.DoEvents();
                    CustomRTB.Text = rtbTxt;
                }
                else
                {
                    CustomRTB.RightToLeft = RightToLeft.Yes;
                }
            }
            else
            {
                CustomRTB.RightToLeft = RightToLeft.No;
            }
        }

        private void ClearEditorMenuStrip_Click(object sender, EventArgs e)
        {
            ClearToolStripMenuItem_Click(this, new EventArgs());
        }

        private void EditorMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (CustomRTB.SelectionLength != 0)
            {
                CutEditorMenuStrip.Enabled = true;
                CopyEditorMenuStrip.Enabled = true;
                DeleteEditorMenuStrip.Enabled = true;
            }
            else
            {
                CutEditorMenuStrip.Enabled = false;
                CopyEditorMenuStrip.Enabled = false;
                DeleteEditorMenuStrip.Enabled = false;
            }
        }
        /* Editor Menu */


        /*Toolbar*/
        private void NewToolbarButton_Click(object sender, EventArgs e)
        {
            NewToolStripMenuItem_Click(this, new EventArgs());
        }

        private void OpenToolbarButton_Click(object sender, EventArgs e)
        {
            OpenToolStripMenuItem_Click(this, new EventArgs());
        }

        private void SaveToolbarButton_Click(object sender, EventArgs e)
        {
            SaveToolStripMenuItem_Click(this, new EventArgs());
        }

        private void FileLocationToolbarButton_Click(object sender, EventArgs e)
        {
            OpenFileLocationToolStripMenuItem_Click(this, new EventArgs());
        }

        private void DeleteFileToolbarButton_Click(object sender, EventArgs e)
        {
            DeleteFileToolStripMenuItem_Click(this, new EventArgs());
        }

        private void CutToolbarButton_Click(object sender, EventArgs e)
        {
            CutToolStripMenuItem_Click(this, new EventArgs());
        }

        private void CopyToolbarButton_Click(object sender, EventArgs e)
        {
            CopyToolStripMenuItem_Click(this, new EventArgs());
        }

        private void PasteToolbarButton_Click(object sender, EventArgs e)
        {
            PasteToolStripMenuItem_Click(this, new EventArgs());
        }

        private void ChangeKeyToolbarButton_Click(object sender, EventArgs e)
        {
            ChangeKeyToolStripMenuItem_Click(this, new EventArgs());
        }

        private void SettingsToolbarButton_Click(object sender, EventArgs e)
        {
            SettingsToolStripMenuItem_Click(this, new EventArgs());
        }

        private void LockToolbarButton_Click(object sender, EventArgs e)
        {
            LockToolStripMenuItem_Click(this, new EventArgs());
        }

        private void CloseToolbar_Click(object sender, EventArgs e)
        {
            ToolbarPanel.Visible = false;
            CustomRTB.Height += 23;
            CustomRTB.Location = new Point(0, 24);
            ps.ShowToolbar = false;
            ps.Save();
        }

        private void CloseToolbar_MouseEnter(object sender, EventArgs e)
        {
            CloseToolbar.Image = Properties.Resources.close_b;
        }

        private void CloseToolbar_MouseLeave(object sender, EventArgs e)
        {
            CloseToolbar.Image = Properties.Resources.close_g;
        }
        /*Toolbar*/


        /*Search Panel*/
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            bool isexist = CustomRTB.Highlight(SearchTextBox.Text, ps.HighlightsColor, chkMatchCase.Checked, chkMatchWholeWord.Checked);
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SearchTextBox.Text = "";
                SearchPanel.Visible = false;
                CustomRTB.Height += 27;
                CustomRTB.Focus();
                CustomRTB.DeselectAll();
                CustomRTB.SelectionStart = caretPos;
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void CloseSearchPanel_Click(object sender, EventArgs e)
        {
            FindToolStripMenuItem_Click(this, new EventArgs());
        }  

        private void CloseSearchPanel_MouseHover(object sender, EventArgs e)
        {
            CloseSearchPanel.Image = Properties.Resources.close_b;
        }

        private void CloseSearchPanel_MouseLeave(object sender, EventArgs e)
        {
            CloseSearchPanel.Image = Properties.Resources.close_g;
        }

        private void ChkMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            bool isexist = CustomRTB.Highlight(SearchTextBox.Text, ps.HighlightsColor, chkMatchCase.Checked, chkMatchWholeWord.Checked);
        }

        private void ChkMatchWholeWord_CheckedChanged(object sender, EventArgs e)
        {
            bool isexist = CustomRTB.Highlight(SearchTextBox.Text, ps.HighlightsColor, chkMatchCase.Checked, chkMatchWholeWord.Checked);
        }
        /*Search Panel*/


        /*Debug Menu*/
        private void MainVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            Debug.WriteLine("\ncurrentFilename: " + currentFilename);
            Debug.WriteLine("encryptionKey: " + PublicVar.encryptionKey.Get());
            Debug.WriteLine("TypedPassword: " + TypedPassword.Value);
            Debug.WriteLine("filePath: " + filePath);
            Debug.WriteLine("cancelPressed: " + cancelPressed);
            Debug.WriteLine("noExit: " + noExit);
            Debug.WriteLine("keyChanged: " + PublicVar.keyChanged);
            Debug.WriteLine("settingsChanged: " + PublicVar.settingsChanged);
            Debug.WriteLine("okPressed: " + PublicVar.okPressed);
            Debug.WriteLine("CustomRTB.Modified: " + CustomRTB.Modified);
#endif      
        }
        /*Debug Menu*/

    }
    }