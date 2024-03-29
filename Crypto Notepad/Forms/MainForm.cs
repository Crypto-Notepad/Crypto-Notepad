﻿using Crypto_Notepad.Properties;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class MainForm : Form
    {
        Settings settings = Settings.Default;
        readonly string[] args = Environment.GetCommandLineArgs();
        string currentClipboardText;
        string filePath = "";
        string argsPath = "";
        bool cancelPressed = false;
        int findPos = 0;
        int caretPos;
        FormWindowState currentWindowState;
        public MainForm()
        {
            InitializeComponent();
            richTextBox.DragDrop += new DragEventHandler(RichTextBox_DragDrop);
            richTextBox.AllowDrop = true;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_MAXIMIZE = 0xF030;
            const int SC_RESTORE = 0xF120;
            try
            {
                if (m.Msg == WM_SYSCOMMAND & m.WParam.ToInt32() == SC_MINIMIZE)
                {
                    richTextBox.Visible = false;
                }
                if (m.Msg == WM_SYSCOMMAND & m.WParam.ToInt32() == SC_RESTORE | m.WParam.ToInt32() == SC_MAXIMIZE & !fileLockedPanel.Visible)
                {
                    if (!fileLockedPanel.Visible)
                    {
                        richTextBox.Visible = true;
                    }
                }

                switch (m.Msg)
                {
                    case WM_SYSCOMMAND:
                        int command = m.WParam.ToInt32() & 0xfff0;
                        if (command == SC_MINIMIZE)
                        {
                            currentWindowState = WindowState;
                        }
                        break;
                }
            }
            catch (OverflowException)
            {

            }
            base.WndProc(ref m);
        }

        #region Methods
        private async Task DecryptAES()
        {
            EnterPasswordForm enterPasswordForm = new EnterPasswordForm();
            enterPasswordForm.Owner = this;
            enterPasswordForm.ShowDialog();
            richTextBox.SuspendDrawing();
            UseWaitCursor = true;
            if (!PublicVar.okPressed)
            {
                PublicVar.openFileName = Path.GetFileName(filePath);
                openFileDialog.FileName = filePath;
                mainMenu.Enabled = true;
                toolbarPanel.Enabled = true;
                settingsToolStripMenuItem.Enabled = true;
                richTextBox.ReadOnly = false;
                UseWaitCursor = false;
                richTextBox.ResumeDrawing();
                return;
            }
            if (searchPanel.Visible)
            {
                FindMainMenu_Click(this, new EventArgs());
            }
            try
            {
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    mainMenu.Enabled = false;
                    toolbarPanel.Enabled = false;
                    settingsToolStripMenuItem.Enabled = false;
                    richTextBox.ReadOnly = true;
                    string openedFileText = await reader.ReadToEndAsync();
                    if (string.IsNullOrEmpty(settings.TheSalt))
                    {
                        richTextBox.Text = await AES.Decrypt(openedFileText, TypedPassword.Value, null, settings.HashAlgorithm,
                        Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize));
                    }
                    else
                    {
                        string currentRichTextBoxText = richTextBox.Text;
                        richTextBox.Text = await AES.Decrypt(openedFileText, TypedPassword.Value, settings.TheSalt, settings.HashAlgorithm,
                        Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize));
                        if (PublicVar.metadataCorrupt)
                        {
                            PublicVar.openFileName = Path.GetFileName(filePath);
                            PublicVar.metadataCorrupt = false;
                            mainMenu.Enabled = true;
                            settingsToolStripMenuItem.Enabled = true;
                            toolbarPanel.Enabled = true;
                            richTextBox.ReadOnly = false;
                            UseWaitCursor = false;
                            richTextBox.ResumeDrawing();
                            richTextBox.Text = currentRichTextBoxText;
                            richTextBox.Modified = false;
                            return;
                        }
                    }
                }
                Text = Path.GetFileName(openFileDialog.FileName) + " – " + PublicVar.appName;
                filePath = openFileDialog.FileName;
                PublicVar.openFileName = Path.GetFileName(openFileDialog.FileName);
                PublicVar.password.Set(TypedPassword.Value);
                TypedPassword.Value = null;
                StatusPanelFileInfo();
                mainMenu.Enabled = true;
                settingsToolStripMenuItem.Enabled = true;
                toolbarPanel.Enabled = true;
                richTextBox.ReadOnly = false;
                UseWaitCursor = false;
                richTextBox.ResumeDrawing();
            }
            catch (Exception ex)
            {
                if (ex is FormatException | ex is CryptographicException)
                {
                    PublicVar.okPressed = false;
                    if (Visible)
                    {
                        PublicVar.messageBoxCenterParent = true;
                    }
                    using (new CenterWinDialog(this))
                    {
                        TypedPassword.Value = null;
                        DialogResult dialogResult = MessageBox.Show(this, "Invalid key!", PublicVar.appName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (dialogResult == DialogResult.Retry)
                        {
                            await DecryptAES();
                        }
                        if (dialogResult == DialogResult.Cancel)
                        {
                            PublicVar.openFileName = Path.GetFileName(filePath);
                            mainMenu.Enabled = true;
                            settingsToolStripMenuItem.Enabled = true;
                            toolbarPanel.Enabled = true;
                            richTextBox.ReadOnly = false;
                            UseWaitCursor = false;
                            richTextBox.ResumeDrawing();
                            if (!Visible)
                            {
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private async void TryToDecryptMessage(string openedFilePath)
        {
            if (Visible)
            {
                PublicVar.messageBoxCenterParent = true;
            }

            PublicVar.password.Set(null);

            if (Path.GetExtension(openedFilePath) != ".cnp")
            {
                if (settings.openTxtUnencrypted)
                {
                    richTextBox.Text = File.ReadAllText(openedFilePath);
                    Text = Path.GetFileName(openedFilePath) + " – " + PublicVar.appName;
                    filePath = openedFilePath;
                    StatusPanelFileInfo();
                }
                else
                {
                    using (new CenterWinDialog(this))
                    {
                        DialogResult res = MessageBox.Show(this, "Try to decrypt \"" + PublicVar.openFileName + "\" file?", PublicVar.appName,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.No)
                        {
                            richTextBox.Text = File.ReadAllText(openedFilePath);
                            Text = Path.GetFileName(openedFilePath) + " – " + PublicVar.appName;
                            filePath = openedFilePath;
                            StatusPanelFileInfo();
                        }
                        else
                        {
                            await DecryptAES();
                        }
                    }
                }
            }
            else
            {
                await DecryptAES();
            }
        }

        private void OpenAsotiations()
        {
            PublicVar.openFileName = Path.GetFileName(args[1]);
            openFileDialog.FileName = Path.GetFullPath(args[1]);
            TryToDecryptMessage(args[1]);
        }

        private void SendTo()
        {
            PublicVar.openFileName = Path.GetFileName(argsPath);
            openFileDialog.FileName = Path.GetFullPath(argsPath);
            TryToDecryptMessage(argsPath);
        }

        private async void ContextMenuEncryptReplace()
        {
            DialogResult res = MessageBox.Show(this, "This action will delete the source file and replace it with encrypted version. File must be in UTF-8 Encoding.", PublicVar.appName,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }
            richTextBox.Text = File.ReadAllText(args[1]);
            PublicVar.openFileName = Path.GetFileName(args[1]);
            string newFileName = Path.GetDirectoryName(args[1]) + @"\" + Path.GetFileNameWithoutExtension(args[1]) + ".cnp";
            EnterPasswordForm enterPasswordForm = new EnterPasswordForm
            {
                Owner = this
            };
            enterPasswordForm.ShowDialog();
            File.Delete(args[1]);
            string unencryptedText = richTextBox.Text;
            string encryptedText = await AES.Encrypt(richTextBox.Text, TypedPassword.Value, null, settings.HashAlgorithm, Convert.ToInt32(settings.PasswordIterations),
                Convert.ToInt32(settings.KeySize));
            using (StreamWriter writer = new StreamWriter(newFileName))
            {
                writer.Write(encryptedText);
                writer.Close();
            }
            PublicVar.password.Set(TypedPassword.Value);
            TypedPassword.Value = null;
            filePath = newFileName;
            PublicVar.openFileName = Path.GetFileName(newFileName);
            Text = PublicVar.appName + " – " + PublicVar.openFileName;
            richTextBox.Text = unencryptedText;
            StatusPanelFileInfo();
            richTextBox.Modified = false;
        }

        private void SaveConfirm()
        {
            string messageBoxText;
            if (richTextBox.Modified)
            {
                if (string.IsNullOrEmpty(PublicVar.openFileName))
                {
                    PublicVar.openFileName = "Unnamed.cnp";
                }
                if (!PublicVar.passwordChanged)
                {
                    messageBoxText = "Save file: " + "\"" + PublicVar.openFileName + "\"" + " ? ";
                }
                else
                {
                    messageBoxText = "Save file: " + "\"" + PublicVar.openFileName + "\"" + " with a new key? ";
                }
                if (Visible)
                {
                    PublicVar.messageBoxCenterParent = true;
                }
                using (new CenterWinDialog(this))
                {
                    DialogResult res = MessageBox.Show(this, messageBoxText, PublicVar.appName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        trayIcon.Visible = false;
                        SaveMainMenu_Click(this, new EventArgs());
                    }
                    if (res == DialogResult.Cancel)
                    {
                        cancelPressed = true;
                    }
                }
            }
        }

        private async Task CheckForUpdates(bool autoCheck)
        {
            try
            {
                PublicVar.messageBoxCenterParent = true;
                WebClient client = new WebClient();
                Uri updateUrl = new Uri("https://raw.githubusercontent.com/Crypto-Notepad/Crypto-Notepad/master/version.txt", UriKind.Absolute);
                Stream stream = await client.OpenReadTaskAsync(updateUrl);
                StreamReader reader = new StreamReader(stream);
                string content = await reader.ReadToEndAsync();
                string version = Application.ProductVersion;
                string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";
                int appVersion = Convert.ToInt32(version.Replace(".", "")), serverVersion = Convert.ToInt32(content.Replace(".", ""));
                if (serverVersion > appVersion)
                {
                    PublicVar.messageBoxCenterParent = true;
                    if (statusPanel.Visible)
                    {
                        StatusPanelMessage("update-needed");
                        return;
                    }
                    else
                    {
                        using (new CenterWinDialog(this))
                        {
                            DialogResult res = MessageBox.Show(this, "New version is available. Install it now?", PublicVar.appName,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (res == DialogResult.Yes)
                            {
                                File.WriteAllBytes(exePath + "Updater.exe", Resources.Updater);
                                var pr = new Process();
                                pr.StartInfo.FileName = exePath + "Updater.exe";
                                pr.StartInfo.Arguments = "/u";
                                pr.Start();
                                Application.Exit();
                            }
                        }
                    }
                }

                if (serverVersion <= appVersion && autoCheck)
                {
                    using (new CenterWinDialog(this))
                    {
                        if (statusPanel.Visible)
                        {
                            StatusPanelMessage("update-missing");
                        }
                        else
                        {
                            MessageBox.Show(this, "Crypto Notepad is up to date.", PublicVar.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            {
                if (autoCheck)
                {
                    using (new CenterWinDialog(this))
                    {
                        if (statusPanel.Visible)
                        {
                            StatusPanelMessage("update-failed");
                        }
                        else
                        {
                            MessageBox.Show(this, "Checking for updates failed:\nConnection lost or the server is busy.", PublicVar.appName,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private async void StatusPanelMessage(string type)
        {
            string ready = "Ready";
            if (statusPanelLabel.Text == "New version is available")
            {
                ready = "New version is available";
            }
            switch (type)
            {
                case "save":
                    if (statusPanelLabel.Text != "File Saved")
                    {
                        statusPanelLabel.Text = "File Saved";
                        await Task.Delay(3000);
                        statusPanelLabel.Text = ready;
                    }
                    break;
                case "update-missing":
                    statusPanelLabel.Text = "Crypto Notepad is up to date";
                    await Task.Delay(3000);
                    statusPanelLabel.Text = ready;
                    break;
                case "update-failed":
                    statusPanelLabel.Text = "Checking for updates failed";
                    await Task.Delay(3000);
                    statusPanelLabel.Text = ready;
                    break;
                case "update-needed":
                    statusPanelLabel.Text = "New version is available";
                    break;
                case "always-top-on":
                    if (statusPanelLabel.Text != "Always on top ON")
                    {
                        statusPanelLabel.Text = "Always on top ON";
                        await Task.Delay(3000);
                        statusPanelLabel.Text = ready;
                    }
                    break;
                case "always-top-off":
                    if (statusPanelLabel.Text != "Always on top OFF")
                    {
                        statusPanelLabel.Text = "Always on top OFF";
                        await Task.Delay(3000);
                        statusPanelLabel.Text = ready;
                    }
                    break;
                case "clipboard-clear":
                    if (statusPanelLabel.Text != "Clipboard cleared")
                    {
                        statusPanelLabel.Text = "Clipboard cleared";
                        await Task.Delay(3000);
                        statusPanelLabel.Text = ready;
                    }
                    break;
            }
        }

        protected internal void StatusPanelFileInfo()
        {
            if (statusPanel.Visible)
            {
                if (statusPanelModifiedLabel.Visible)
                {
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        DateTime creation = File.GetLastWriteTime(filePath);
                        statusPanelModifiedLabel.Text = "Modified: " + creation.ToString("dd.MM.yyyy");
                        statusPanelModifiedLabel.ToolTipText = creation.ToString();
                    }
                }
                if (statusPanelSizeLabel.Visible)
                {
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        long length = new FileInfo(filePath).Length;
                        statusPanelSizeLabel.Text = "Size: " + Methods.SizeSuffix(length).ToString();
                        StatusPanelTextInfo();
                    }
                }
                statusPanelReadonlyLabel.Text = "Readonly: " + readOnlyMainMenu.Checked.ToString();
                statusPanelWordwrapLabel.Text = "Word Wrap: " + wordWrapMainMenu.Checked.ToString();
            }
        }

        protected internal void StatusPanelTextInfo()
        {
            if (statusPanel.Visible)
            {
                if (statusPanelLinesLabel.Visible)
                {
                    int linesCount = richTextBox.Lines.Length;
                    if (linesCount == 0)
                    {
                        linesCount = 1;
                    }
                    statusPanelLinesLabel.Text = "Lines: " + linesCount;
                }
                if (statusPanelLengthLabel.Visible)
                {
                    statusPanelLengthLabel.Text = "Length: " + richTextBox.TextLength;
                }
            }
        }

        private void StatusPanelTimer_Tick(object sender, EventArgs e)
        {
            StatusPanelTextInfo();
            statusPanelTimer.Stop();
        }

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            LockMainMenu_Click(this, new EventArgs());
            lockTimer.Enabled = false;
        }

        private async Task UnlockFile()
        {
            try
            {
                richTextBox.SuspendDrawing();
                UseWaitCursor = true;
                fileLockedPanel.Enabled = false;
                TypedPassword.Value = fileLockedKeyTextBox.Text;
                mainMenu.Enabled = false;
                settingsToolStripMenuItem.Enabled = false;
                toolbarPanel.Enabled = false;
                using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                {
                    string openedFileText = await reader.ReadToEndAsync();
                    richTextBox.Text = await AES.Decrypt(openedFileText, TypedPassword.Value, null, settings.HashAlgorithm,
                        Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize));
                }
                richTextBox.Modified = false;
                fileLockedPanel.Visible = false;
                richTextBox.SelectionStart = caretPos;
                PublicVar.password.Set(TypedPassword.Value);
                TypedPassword.Value = null;
                richTextBox.Focus();
                StatusPanelFileInfo();
                richTextBox.ResumeDrawing();
                UseWaitCursor = false;
                fileLockedPanel.Enabled = true;
                mainMenu.Enabled = true;
                settingsToolStripMenuItem.Enabled = true;
                toolbarPanel.Enabled = true;
            }
            catch (Exception ex)
            {
                if (ex is CryptographicException)
                {
                    TypedPassword.Value = null;
                    PublicVar.messageBoxCenterParent = true;
                    using (new CenterWinDialog(this))
                    {
                        DialogResult dialogResult = MessageBox.Show(this, "Invalid key!", PublicVar.appName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (dialogResult == DialogResult.Retry)
                        {
                            UseWaitCursor = false;
                            richTextBox.ResumeDrawing();
                            fileLockedPanel.Enabled = true;
                            fileLockedKeyTextBox.Text = "";
                            fileLockedKeyTextBox.Focus();
                        }
                        if (dialogResult == DialogResult.Cancel)
                        {
                            fileLockedPanel.Visible = false;
                            Text = PublicVar.appName;
                            filePath = "";
                            PublicVar.openFileName = "";
                            UseWaitCursor = false;
                            richTextBox.ResumeDrawing();
                            fileLockedPanel.Enabled = true;
                        }
                    }
                }
            }
        }

        private void LoadSettings()
        {
            if (settings.editorRightToLeft)
            {
                richTextBox.RightToLeft = RightToLeft.Yes;
                rightToLeftContextMenu.Checked = true;
            }
            else
            {
                richTextBox.RightToLeft = RightToLeft.No;
                rightToLeftContextMenu.Checked = false;
            }
            if (settings.insertKey == "Disable")
            {
                insertMainMenu.ShortcutKeys = Keys.Insert;
            }
            else
            {
                insertMainMenu.ShortcutKeys = Keys.None;
            }
            if (settings.windowLocation.ToString() != "{X=0,Y=0}")
            {
                Location = settings.windowLocation;
            }
            if (!Methods.IsOnScreen(this))
            {
                Location = new Point(1, 1);
            }

            Size = settings.windowSize;
            if (settings.toolbarBorder)
            {
                toolbarPanel.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                toolbarPanel.BorderStyle = BorderStyle.None;
            }
            TopMost = settings.alwaysOnTop;
            alwaysOnTopMainMenu.Checked = settings.alwaysOnTop;
            if (settings.closeToTray | settings.minimizeToTray | settings.trayMenu)
            {
                trayIcon.Visible = true;
            }
            richTextBoxPanel.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), settings.editorBorder);
            wordWrapMainMenu.Checked = settings.editorWrap;
            toolbarPanel.BackColor = settings.toolbarBackColor;
            toolbarPanel.Visible = settings.toolbarVisible;
            closeToolbarButton.Visible = settings.toolbarCloseButton;
            mainMenu.Visible = settings.mainMenuVisible;
            rightToLeftContextMenu.Checked = settings.editorRightToLeft;
            statusPanel.ForeColor = settings.statusPanelFontColor;
            statusPanel.BackColor = settings.statusPanelBackColor;
            statusPanel.Visible = settings.statusPanelVisible;
            statusPanelLengthLabel.Visible = settings.statusPanelLength;
            statusPanelLinesLabel.Visible = settings.statusPanelLines;
            statusPanelModifiedLabel.Visible = settings.statusPanelModified;
            statusPanelSizeLabel.Visible = settings.statusPanelSize;
            statusPanelReadonlyLabel.Visible = settings.statusPanelReadonly;
            statusPanelWordwrapLabel.Visible = settings.statusPanelWordWrap;
            statusPanelPasteboardLabel.Visible = settings.statusPanelPasteboard;
            richTextBox.WordWrap = settings.editorWrap;
            richTextBox.ForeColor = settings.editorForeColor;
            richTextBox.BackColor = settings.editorBackColor;
            richTextBox.Font = settings.editorFont;
            BackColor = settings.editorBackColor;
            searchPanel.BackColor = settings.searchPanelBackColor;
            searchPanel.ForeColor = settings.searchPanelForeColor;
            searchTextBox.BackColor = settings.searchPanelBackColor;
            searchTextBox.ForeColor = settings.searchPanelForeColor;
            searchCaseSensitiveCheckBox.ForeColor = settings.searchPanelForeColor;
            searchWholeWordCheckBox.ForeColor = settings.searchPanelForeColor;
            searchFindNextButton.ForeColor = settings.searchPanelForeColor;
            searchCloseButton.ForeColor = settings.searchPanelForeColor;
            searchPanel.CellBorderStyle = (TableLayoutPanelCellBorderStyle)Enum.Parse(typeof(TableLayoutPanelCellBorderStyle), settings.searchPanelBorder);

            RegistryKey explorerAssociate = Registry.CurrentUser.OpenSubKey(@"Software\Classes\.cnp\", true);
            if (settings.explorerAssociate && explorerAssociate == null)
            {
                Methods.AssociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
            }

            RegistryKey explorerIntegrate = Registry.CurrentUser.OpenSubKey(@"Software\Classes\*\shell\Crypto Notepad\", true);
            if (settings.explorerIntegrate && explorerIntegrate == null)
            {
                Methods.MenuIntegrate("enable");
            }

            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\SendTo\Crypto Notepad.lnk";
            if (settings.explorerSendTo && !File.Exists(shortcutPath))
            {
                Methods.SendToShortcut();
            }
        }

        public void MenuIcons(bool menuIcons)
        {
            if (menuIcons)
            {
                newMainMenu.Image = Resources.document_plus;
                openMainMenu.Image = Resources.folder_open_document;
                saveMainMenu.Image = Resources.disk_return_black;
                saveAsMainMenu.Image = Resources.disks_black;
                openFileLocationMainMenu.Image = Resources.folder_horizontal;
                deleteFileMainMenu.Image = Resources.document_minus;
                tryToDecryptMainMenu.Image = Resources.lock_pencil;
                exitMainMenu.Image = Resources.cross_button;
                undoMainMenu.Image = Resources.arrow_left;
                redoMainMenu.Image = Resources.arrow_right;
                cutMainMenu.Image = Resources.scissors;
                copyMainMenu.Image = Resources.document_copy;
                pasteMainMenu.Image = Resources.clipboard;
                deleteMainMenu.Image = Resources.minus;
                findMainMenu.Image = Resources.magnifier;
                selectAllMainMenu.Image = Resources.selection_input;
                clearClipboardMainMenu.Image = Resources.clipboard_minus;
                wordWrapMainMenu.Image = Resources.wrap_option;
                readOnlyMainMenu.Image = Resources.document_pencil;
                insertDateTimeMainMenu.Image = Resources.clock_plus;
                clearMainMenu.Image = Resources.document;
                changePasswordMainMenu.Image = Resources.key;
                lockMainMenu.Image = Resources.lock_warning;
                settingsMainMenu.Image = Resources.gear;
                pasteBoardMainMenu.Image = Resources.clipboard_text;
                documentationMainMenu.Image = Resources.document_text;
                checkForUpdatesMainMenu.Image = Resources.upload_cloud;
                aboutMainMenu.Image = Resources.information;
                alwaysOnTopMainMenu.Image = Resources.applications_blue;
                saveCloseFileMainMenu.Image = Resources.disk_minus;
                passwordGeneratorMainMenu.Image = Resources.key_plus;
            }
            else
            {
                foreach (ToolStripItem item in mainMenu.Items)
                {
                    if (item is ToolStripDropDownItem)
                        foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)item).DropDownItems)
                        {
                            dropDownItem.Image = null;
                        }
                }
            }
        }

        protected internal void ShortcutKeys(bool shortcutKeys)
        {
            if (shortcutKeys)
            {
                newMainMenu.ShortcutKeys = Keys.Control | Keys.N;
                openMainMenu.ShortcutKeys = Keys.Control | Keys.O;
                saveMainMenu.ShortcutKeys = Keys.Control | Keys.S;
                saveAsMainMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
                saveCloseFileMainMenu.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.S;
                openFileLocationMainMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
                deleteFileMainMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D;
                tryToDecryptMainMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
                exitMainMenu.ShortcutKeys = Keys.Control | Keys.Q;
                undoMainMenu.ShortcutKeys = Keys.Control | Keys.Z;
                redoMainMenu.ShortcutKeys = Keys.Control | Keys.Y;
                cutMainMenu.ShortcutKeys = Keys.Control | Keys.X;
                copyMainMenu.ShortcutKeys = Keys.Control | Keys.C;
                pasteMainMenu.ShortcutKeys = Keys.Control | Keys.V;
                deleteMainMenu.ShortcutKeys = Keys.Delete;
                findMainMenu.ShortcutKeys = Keys.Control | Keys.F;
                selectAllMainMenu.ShortcutKeys = Keys.Control | Keys.A;
                clearClipboardMainMenu.ShortcutKeys = Keys.Control | Keys.D;
                wordWrapMainMenu.ShortcutKeys = Keys.Control | Keys.W;
                readOnlyMainMenu.ShortcutKeys = Keys.Control | Keys.R;
                clearMainMenu.ShortcutKeys = Keys.Control | Keys.Delete;
                alwaysOnTopMainMenu.ShortcutKeys = Keys.Control | Keys.T;
                passwordGeneratorMainMenu.ShortcutKeys = Keys.Control | Keys.P;
                changePasswordMainMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.P;
                lockMainMenu.ShortcutKeys = Keys.Control | Keys.L;
                settingsMainMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
                documentationMainMenu.ShortcutKeys = Keys.Control | Keys.F1;
                checkForUpdatesMainMenu.ShortcutKeys = Keys.Control | Keys.U;
                aboutMainMenu.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            }
            else
            {
                newMainMenu.ShortcutKeys = Keys.None;
                openMainMenu.ShortcutKeys = Keys.None;
                saveMainMenu.ShortcutKeys = Keys.None;
                saveAsMainMenu.ShortcutKeys = Keys.None;
                saveCloseFileMainMenu.ShortcutKeys = Keys.None;
                openFileLocationMainMenu.ShortcutKeys = Keys.None;
                deleteFileMainMenu.ShortcutKeys = Keys.None;
                tryToDecryptMainMenu.ShortcutKeys = Keys.None;
                exitMainMenu.ShortcutKeys = Keys.None;
                undoMainMenu.ShortcutKeys = Keys.None;
                redoMainMenu.ShortcutKeys = Keys.None;
                cutMainMenu.ShortcutKeys = Keys.None;
                copyMainMenu.ShortcutKeys = Keys.None;
                pasteMainMenu.ShortcutKeys = Keys.None;
                deleteMainMenu.ShortcutKeys = Keys.None;
                findMainMenu.ShortcutKeys = Keys.None;
                selectAllMainMenu.ShortcutKeys = Keys.None;
                clearClipboardMainMenu.ShortcutKeys = Keys.None;
                wordWrapMainMenu.ShortcutKeys = Keys.None;
                readOnlyMainMenu.ShortcutKeys = Keys.None;
                clearMainMenu.ShortcutKeys = Keys.None;
                alwaysOnTopMainMenu.ShortcutKeys = Keys.None;
                passwordGeneratorMainMenu.ShortcutKeys = Keys.None;
                changePasswordMainMenu.ShortcutKeys = Keys.None;
                lockMainMenu.ShortcutKeys = Keys.None;
                settingsMainMenu.ShortcutKeys = Keys.None;
                documentationMainMenu.ShortcutKeys = Keys.None;
                checkForUpdatesMainMenu.ShortcutKeys = Keys.None;
                aboutMainMenu.ShortcutKeys = Keys.None;
            }
        }

        public void ToolbarIcons(bool oldIcons)
        {
            if (oldIcons)
            {
                newToolbarButton.Image = Resources.old_page_white_add;
                openToolbarButton.Image = Resources.old_folder_vertical_document;
                saveToolbarButton.Image = Resources.old_diskette;
                fileLocationToolbarButton.Image = Resources.old_folder_stand;
                deleteFileToolbarButton.Image = Resources.old_page_white_delete;
                cutToolbarButton.Image = Resources.old_cut_red;
                copyToolbarButton.Image = Resources.old_page_white_copy;
                pasteToolbarButton.Image = Resources.old_paste_plain;
                changePasswordToolbarButton.Image = Resources.old_page_white_key;
                lockToolbarButton.Image = Resources.old_lock;
                insertDateTimeMainMenu.Image = Resources.old_clock_add;
                tryToDecryptToolbarButton.Image = Resources.old_lock_edit;
                settingsToolbarButton.Image = Resources.old_setting_tools;
                alwaysOnTopToolbarButton.Image = Resources.old_application_double;
            }
            else
            {
                newToolbarButton.Image = Resources.document_plus;
                openToolbarButton.Image = Resources.folder_open_document;
                saveToolbarButton.Image = Resources.disk_return_black;
                fileLocationToolbarButton.Image = Resources.folder_horizontal;
                deleteFileToolbarButton.Image = Resources.document_minus;
                cutToolbarButton.Image = Resources.scissors;
                copyToolbarButton.Image = Resources.document_copy;
                pasteToolbarButton.Image = Resources.clipboard;
                changePasswordToolbarButton.Image = Resources.key;
                lockToolbarButton.Image = Resources.lock_warning;
                insertDateTimeMainMenu.Image = Resources.clock_plus;
                tryToDecryptToolbarButton.Image = Resources.lock_pencil;
                settingsToolbarButton.Image = Resources.gear;
                alwaysOnTopToolbarButton.Image = Resources.applications_blue;
            }

        }

        public void ClipboardProgressbar()
        {
            if (richTextBox.SelectionLength != 0)
            {
                if (!string.IsNullOrEmpty(settings.clipboardClearTime))
                {
                    statusPanelClipboardProgressBar.Value = 100;
                    clipboardTimer.Interval = int.Parse(settings.clipboardClearTime);
                    clipboardTimer.Start();
                }
            }
        }
        #endregion


        #region Event Handlers
        private void RichTextBox_ModifiedChanged(object sender, EventArgs e)
        {
            if (richTextBox.Modified == false)
            {
                if (Text.Contains("*"))
                {
                    Text = Text.Replace("*", string.Empty);
                }
            }
            //if (richTextBox.Modified == true)
            //{
            //    if (!Text.Contains("*"))
            //    {
            //        Text = Text.Insert(0, "*");
            //        if (string.IsNullOrEmpty(PublicVar.openFileName) & richTextBox.TextLength > 0)
            //        {
            //            Text = "Unnamed.cnp" + " – " + PublicVar.appName;
            //            Text = Text.Insert(0, "*");
            //        }
            //    }
            //}
        }
        private void StatusPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (statusPanel.Visible)
            {
                StatusPanelTextInfo();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized & settings.minimizeToTray)
            {
                Hide();
            }
            if (WindowState == FormWindowState.Minimized & settings.autoLock & !string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                settingsToolStripMenuItem.Enabled = false;
                fileLockedPanel.Visible = true;
            }
            if (WindowState == FormWindowState.Normal)
            {
                if (fileLockedPanel.Visible)
                {
                    fileLockedKeyTextBox.Focus();
                }
            }
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            richTextBox.Focus();
            if (PublicVar.passwordChanged)
            {
                richTextBox.Modified = true;
            }
            lockTimer.Enabled = false;
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(settings.lockTimeout) & settings.lockTimeout != "0" & !string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                lockTimer.Interval = int.Parse(settings.lockTimeout) * 60000;
                lockTimer.Enabled = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                settings.windowSize = Size;
                settings.windowLocation = Location;
                settings.windowState = WindowState;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                settings.windowState = WindowState;
            }
            settings.Save();
            if (settings.closeToTray)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (settings.autoLock & !string.IsNullOrEmpty(PublicVar.password.Get()))
                    {
                        settingsToolStripMenuItem.Enabled = false;
                        fileLockedPanel.Visible = true;
                    }
                    Hide();
                    e.Cancel = true;
                    return;
                }
            }
            if (richTextBox.Modified)
            {
                if (string.IsNullOrEmpty(PublicVar.openFileName))
                {
                    PublicVar.openFileName = "Unnamed.cnp";
                }
                if (!string.IsNullOrEmpty(richTextBox.Text))
                {
                    string messageBoxText;
                    if (!PublicVar.passwordChanged)
                    {
                        messageBoxText = "Save file: " + "\"" + PublicVar.openFileName + "\"" + " ? ";
                    }
                    else
                    {
                        messageBoxText = "Save file: " + "\"" + PublicVar.openFileName + "\"" + " with a new password? ";
                    }
                    if (Visible)
                    {
                        PublicVar.messageBoxCenterParent = true;
                    }
                    else
                    {
                        PublicVar.messageBoxCenterParent = false;
                    }
                    using (new CenterWinDialog(this))
                    {
                        DialogResult res = MessageBox.Show(this, messageBoxText, PublicVar.appName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            if (string.IsNullOrEmpty(filePath))
                            {
                                saveFileDialog.FileName = "Unnamed.cnp";
                                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                                {
                                    e.Cancel = true;
                                    return;
                                }
                                EnterPasswordForm enterKeyForm = new EnterPasswordForm
                                {
                                    Owner = this
                                };
                                enterKeyForm.ShowDialog();
                                if (!PublicVar.okPressed)
                                {
                                    PublicVar.openFileName = Path.GetFileName(filePath);
                                    e.Cancel = true;
                                    return;
                                }
                                PublicVar.password.Set(TypedPassword.Value);
                                filePath = saveFileDialog.FileName;
                            }
                            Hide();
                            trayIcon.Visible = false;
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                string encryptedText = richTextBox.Text;
                                Task.Run(async () =>
                                {
                                    encryptedText = await AES.Encrypt(encryptedText, PublicVar.password.Get(), null, settings.HashAlgorithm,
                                    Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize));
                                }).Wait();
                                writer.Write(encryptedText);
                                writer.Close();
                            }
                            if (settings.clearClipboardAtClose)
                            {
                                Clipboard.Clear();
                            }
                        }
                        if (res == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (settings.clearClipboardAtClose)
            {
                Clipboard.Clear();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Visible = true;
            richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
            richTextBox.Modified = false;

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Crypto Notepad.settings"))
            {
                if (Visible)
                {
                    PublicVar.messageBoxCenterParent = true;
                }
                using (new CenterWinDialog(this))
                {
                    DialogResult res = MessageBox.Show(this, "Enable automatic update check at startup?\nThis action can be undone in settings.", PublicVar.appName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        settings.autoCheckUpdate = true;
                    }
                }
            }
            WindowState = settings.windowState;
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            Visible = false;
            LoadSettings();
            Methods.DeleteUpdateFiles();
            MenuIcons(settings.menuIcons);
            ToolbarIcons(settings.oldToolbarIcons);
            ShortcutKeys(settings.shortcutKeys);
            statusPanelReadonlyLabel.Text = "Readonly: " + readOnlyMainMenu.Checked.ToString();
            statusPanelWordwrapLabel.Text = "Word Wrap: " + wordWrapMainMenu.Checked.ToString();
            statusPanelPasteboardLabel.Text = "Paste Board: " + pasteBoardMainMenu.Checked.ToString();
            if (args.Length == 2) /*drag & drop to executable*/
            {
                OpenAsotiations();
            }
            if (args.Contains("/s")) /*send to*/
            {
                foreach (var arg in args)
                {
                    argsPath = arg;
                }
                SendTo();
            }
            if (args.Contains("/o"))  /*decrypt & open*/
            {
                PublicVar.openFileName = Path.GetFileName(args[1]);
                openFileDialog.FileName = Path.GetFullPath(args[1]);
                await DecryptAES();
            }
            if (args.Contains("/er")) /*encrypt and replace*/
            {
                ContextMenuEncryptReplace();
            }
            if (settings.autoCheckUpdate)
            {
                await CheckForUpdates(false);
            }

        }

        private void RichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength != 0)
            {
                cutToolbarButton.Enabled = true;
                copyToolbarButton.Enabled = true;
            }
            else
            {
                cutToolbarButton.Enabled = false;
                copyToolbarButton.Enabled = false;
            }
        }

        private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                searchTextBox.Text = "";
                searchPanel.Visible = false;
                richTextBox.Focus();
                richTextBox.DeselectAll();
                e.Handled = e.SuppressKeyPress = true;
                findPos = 0;
            }
            if (e.KeyCode == Keys.Enter & searchPanel.Visible & !string.IsNullOrEmpty(searchTextBox.Text))
            {
                SearchFindNextButton_MouseUp(null, null);
                e.Handled = e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.C || e.Control && e.KeyCode == Keys.X)
            {
                ClipboardProgressbar();
            }
        }

        private void RichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (settings.openLinks == "LMB Click")
            {
                Process.Start(e.LinkText);
            }
            if (settings.openLinks == "Shift+LMB")
            {
                if ((ModifierKeys & Keys.Shift) != 0)
                {
                    Process.Start(e.LinkText);
                }
            }
            if (settings.openLinks == "Control+LMB")
            {
                if ((ModifierKeys & Keys.Control) != 0)
                {
                    Process.Start(e.LinkText);
                }
            }
        }

        private void RichTextBox_DragDrop(object sender, DragEventArgs e)
        {
            SaveConfirm();
            if (cancelPressed)
            {
                cancelPressed = false;
                return;
            }
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in FileList) openFileDialog.FileName = file;
            object fileName = e.Data.GetData("FileDrop");
            PublicVar.openFileName = Path.GetFileName(openFileDialog.FileName);
            if (fileName != null)
            {
                if (fileName is string[] list && !string.IsNullOrWhiteSpace(list[0]))
                {
                    TryToDecryptMessage(openFileDialog.FileName);
                }
            }
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
           statusPanelTimer.Start();
            if (richTextBox.Modified)
            {
                if (!Text.Contains("*"))
                {
                    Text = Text.Insert(0, "*");
                    if (string.IsNullOrEmpty(PublicVar.openFileName) & richTextBox.TextLength > 0)
                    {
                        Text = "Unnamed.cnp" + " – " + PublicVar.appName;
                        Text = Text.Insert(0, "*");
                    }
                }
            }
        }

        private void StatusPanelLabel_TextChanged(object sender, EventArgs e)
        {
            if (statusPanelLabel.Text == "New version is available")
            {
                statusPanelLabel.IsLink = true;
            }
            else
            {
                statusPanelLabel.IsLink = false;
            }
        }

        private void StatusPanelLabel_Click(object sender, EventArgs e)
        {
            if (statusPanelLabel.Text == "New version is available")
            {
                string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";
                using (new CenterWinDialog(this))
                {
                    DialogResult res = MessageBox.Show(this, "New version is available. Install it now?", PublicVar.appName,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        File.WriteAllBytes(exePath + "Updater.exe", Resources.Updater);
                        var pr = new Process();
                        pr.StartInfo.FileName = exePath + "Updater.exe";
                        pr.StartInfo.Arguments = "/u";
                        pr.Start();
                        Application.Exit();
                    }
                }
            }
        }

        private void ClipboardTimer_Tick(object sender, EventArgs e)
        {
            if (settings.statusPanelClipboard)
            {
                statusPanelClipboardProgressBar.Visible = true;
            }
            statusPanelClipboardProgressBar.Value--;
            if (statusPanelClipboardProgressBar.Value == 0)
            {
                Clipboard.Clear();
                if (settings.statusPanelClipboard)
                {
                    statusPanelClipboardProgressBar.Visible = false;
                }
                clipboardTimer.Stop();
            }
        }
        #endregion


        #region Main Menu
        /*File*/
        private void NewMainMenu_Click(object sender, EventArgs e)
        {
            SaveConfirm();
            if (cancelPressed)
            {
                cancelPressed = false;
                return;
            }
            PublicVar.openFileName = "Unnamed.cnp";
            EnterPasswordForm enterKeyForm = new EnterPasswordForm
            {
                Owner = this
            };
            enterKeyForm.ShowDialog();

            if (!PublicVar.okPressed)
            {
                PublicVar.openFileName = "";
                if (!string.IsNullOrEmpty(filePath))
                {
                    PublicVar.openFileName = Path.GetFileName(filePath);
                }
                TypedPassword.Value = null;
                PublicVar.okPressed = false;
            }
            else
            {
                saveFileDialog.FileName = "Unnamed.cnp";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    TypedPassword.Value = null;
                    return;
                }
                richTextBox.Clear();
                PublicVar.password.Set(TypedPassword.Value);
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                Text = Path.GetFileName(saveFileDialog.FileName) + " – " + PublicVar.appName;
                filePath = saveFileDialog.FileName;
                PublicVar.openFileName = Path.GetFileName(saveFileDialog.FileName);
                sw.Close();
            }
            TypedPassword.Value = null;
        }

        private void OpenMainMenu_Click(object sender, EventArgs e)
        {
            SaveConfirm();
            if (cancelPressed)
            {
                cancelPressed = false;
                return;
            }
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            {
                PublicVar.openFileName = Path.GetFileName(openFileDialog.FileName);
                TryToDecryptMessage(openFileDialog.FileName);
                richTextBox.Modified = false;
            }
        }

        private async void SaveMainMenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                SaveAsMainMenu_Click(this, new EventArgs());
                return;
            }
            mainMenu.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;
            toolbarPanel.Enabled = false;
            richTextBox.ReadOnly = true;
            richTextBox.SuspendDrawing();
            UseWaitCursor = true;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(await AES.Encrypt(richTextBox.Text, PublicVar.password.Get(), null, settings.HashAlgorithm,
                    Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize)));
                writer.Close();
            }
            richTextBox.Modified = false;
            PublicVar.passwordChanged = false;
            StatusPanelMessage("save");
            StatusPanelFileInfo();
            richTextBox.ResumeDrawing();
            UseWaitCursor = false;
            mainMenu.Enabled = true;
            settingsToolStripMenuItem.Enabled = true;
            toolbarPanel.Enabled = true;
            richTextBox.ReadOnly = false;
        }

        private async void SaveAsMainMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                PublicVar.openFileName = Path.GetFileName(filePath);
                saveFileDialog.FileName = Path.GetFileName(filePath);
            }
            else
            {
                PublicVar.openFileName = "Unnamed.cnp";
                saveFileDialog.FileName = "Unnamed.cnp";
            }
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            PublicVar.openFileName = Path.GetFileName(saveFileDialog.FileName);
            EnterPasswordForm enterKeyForm = new EnterPasswordForm
            {
                Owner = this
            };
            if (string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                enterKeyForm.ShowDialog();
                if (!PublicVar.okPressed)
                {
                    PublicVar.openFileName = Path.GetFileName(filePath);
                    return;
                }
            }
            if (TypedPassword.Value == null)
            {
                TypedPassword.Value = PublicVar.password.Get();
            }
            PublicVar.password.Set(TypedPassword.Value);
            filePath = saveFileDialog.FileName;
            mainMenu.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;
            toolbarPanel.Enabled = false;
            richTextBox.ReadOnly = true;
            richTextBox.SuspendDrawing();
            UseWaitCursor = true;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(await AES.Encrypt(richTextBox.Text, PublicVar.password.Get(), null, settings.HashAlgorithm,
                    Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize)));
                writer.Close();
            }
            richTextBox.ResumeDrawing();
            UseWaitCursor = false;
            mainMenu.Enabled = true;
            settingsToolStripMenuItem.Enabled = true;
            toolbarPanel.Enabled = true;
            richTextBox.ReadOnly = false;
            richTextBox.Modified = false;
            Text = Path.GetFileName(filePath) + " – " + PublicVar.appName;
            TypedPassword.Value = null;
            PublicVar.openFileName = Path.GetFileName(saveFileDialog.FileName);
            StatusPanelMessage("save");
            StatusPanelFileInfo();
        }

        private async void SaveCloseFileMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;
            toolbarPanel.Enabled = false;
            richTextBox.SuspendDrawing();
            UseWaitCursor = true;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(await AES.Encrypt(richTextBox.Text, PublicVar.password.Get(), null, settings.HashAlgorithm,
                    Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize)));
                writer.Close();
            }
            richTextBox.ResumeDrawing();
            UseWaitCursor = false;
            mainMenu.Enabled = true;
            settingsToolStripMenuItem.Enabled = true;
            toolbarPanel.Enabled = true;
            richTextBox.ReadOnly = false;
            PublicVar.password.Set(null);
            richTextBox.Clear();
            PublicVar.openFileName = "";
            filePath = "";
            Text = PublicVar.appName;
            statusPanelModifiedLabel.Text = "Modified";
            statusPanelModifiedLabel.ToolTipText = null;
            statusPanelSizeLabel.Text = "Size";
        }

        private void OpenFileLocationMainMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                Process.Start("explorer.exe", @"/select, " + filePath);
            }
        }

        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                PublicVar.messageBoxCenterParent = true;
                using (new CenterWinDialog(this))
                {
                    if (MessageBox.Show(this, "Delete file: " + "\"" + filePath + "\"" + " ?", PublicVar.appName,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Delete(filePath);
                        richTextBox.Clear();
                        PublicVar.password.Set(null);
                        fileLocationToolbarButton.Enabled = false;
                        deleteFileToolbarButton.Enabled = false;
                        changePasswordToolbarButton.Enabled = false;
                        lockToolbarButton.Enabled = false;
                        filePath = "";
                        PublicVar.openFileName = "";
                        Text = PublicVar.appName;
                        StatusPanelTextInfo();
                        statusPanelModifiedLabel.Text = "Modified";
                        statusPanelSizeLabel.Text = "Size";
                        statusPanelModifiedLabel.ToolTipText = null;
                    }
                }
            }
        }

        private async void TryToDecryptMainMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                await DecryptAES();
            }
        }

        private void ExitMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*File*/

        /*Edit*/
        private void EditMainMenu_DropDownOpened(object sender, EventArgs e)
        {

        }

        private void FileMainMenu_DropDownOpening(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                deleteFileMainMenu.Enabled = true;
                openFileLocationMainMenu.Enabled = true;
            }
            else
            {
                deleteFileMainMenu.Enabled = false;
                openFileLocationMainMenu.Enabled = false;
            }

            if (!string.IsNullOrEmpty(PublicVar.password.Get()) && !string.IsNullOrEmpty(filePath))
            {
                saveCloseFileMainMenu.Enabled = true;
            }
            else
            {
                saveCloseFileMainMenu.Enabled = false;
            }

            if (string.IsNullOrEmpty(PublicVar.password.Get()) && richTextBox.TextLength > 0 && !string.IsNullOrEmpty(filePath))
            {
                tryToDecryptMainMenu.Enabled = true;
            }
            else
            {
                tryToDecryptMainMenu.Enabled = false;
            }
        }

        private void EditMainMenu_DropDownOpening(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength != 0)
            {
                cutMainMenu.Enabled = true;
                copyMainMenu.Enabled = true;
                deleteMainMenu.Enabled = true;
            }
            else
            {
                cutMainMenu.Enabled = false;
                copyMainMenu.Enabled = false;
                deleteMainMenu.Enabled = false;
            }
        }

        private void ToolsMainMenu_DropDownOpening(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                changePasswordMainMenu.Enabled = false;
                lockMainMenu.Enabled = false;
            }
            else
            {
                changePasswordMainMenu.Enabled = true;
                lockMainMenu.Enabled = true;

            }
        }

        private void UndoMainMenu_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
            richTextBox.DeselectAll();
        }

        public void RedoMainMenu_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void CutMainMenu_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
            ClipboardProgressbar();
        }

        private void CopyMainMenu_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
            ClipboardProgressbar();
        }

        private void PasteMainMenu_Click(object sender, EventArgs e)
        {
            if (richTextBox.Focused)
            {
                richTextBox.Paste(DataFormats.GetFormat(DataFormats.Text));
            }
            if (searchTextBox.Focused)
            {
                searchTextBox.Paste();
            }
        }

        private void DeleteMainMenu_Click(object sender, EventArgs e)
        {
            richTextBox.SelectedText = "";
        }

        private void FindMainMenu_Click(object sender, EventArgs e)
        {
            if (!richTextBox.Visible) return;

            if (searchPanel.Visible)
            {
                searchTextBox.Text = "";
                searchPanel.Visible = false;
                richTextBox.Focus();
                richTextBox.DeselectAll();
            }
            else
            {
                searchPanel.Visible = true;
                searchTextBox.Focus();
            }
        }

        private void SelectAllMainMenu_Click(object sender, EventArgs e)
        {
            if (richTextBox.Focused)
            {
                richTextBox.SelectAll();
            }
            if (searchTextBox.Focused)
            {
                searchTextBox.SelectAll();
            }
        }

        private void ClearClipboardMainMenu_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText())
            {
                return;
            }

            Clipboard.Clear();
            if (statusPanelClipboardProgressBar.Visible)
            {
                statusPanelClipboardProgressBar.Visible = false;
                clipboardTimer.Stop();
            }
            StatusPanelMessage("clipboard-clear");
        }

        private void ReadOnlyMainMenu_Click(object sender, EventArgs e)
        {
            richTextBox.ReadOnly = readOnlyMainMenu.Checked;
            statusPanelReadonlyLabel.Text = "Readonly: " + readOnlyMainMenu.Checked.ToString();
        }

        private void InsertDateTimeMainMenu_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            richTextBox.SelectedText = now.ToString();
            richTextBox.Modified = true;
            if (!Text.Contains("*"))
            {
                Text = Text.Insert(0, "*");
                if (string.IsNullOrEmpty(PublicVar.openFileName) & richTextBox.TextLength > 0)
                {
                    Text = "Unnamed.cnp" + " – " + PublicVar.appName;
                    Text = Text.Insert(0, "*");
                }
            }
        }

        private void WordWrapMainMenu_Click(object sender, EventArgs e)
        {
            richTextBox.WordWrap = wordWrapMainMenu.Checked;
            settings.menuWrap = wordWrapMainMenu.Checked;
            settings.editorWrap = richTextBox.WordWrap;
            settings.Save();
            statusPanelWordwrapLabel.Text = "Word Wrap: " + wordWrapMainMenu.Checked.ToString();
        }

        private void ClearMainMenu_Click(object sender, EventArgs e)
        {
            if (!readOnlyMainMenu.Checked)
            {
                richTextBox.SelectAll();
                richTextBox.SelectedText = " ";
            }
        }
        /*Edit*/

        /*Tools*/
        private void AlwaysOnTopMainMenu_Click(object sender, EventArgs e)
        {
            if (alwaysOnTopMainMenu.Checked)
            {
                settings.alwaysOnTop = true;
                TopMost = true;
                StatusPanelMessage("always-top-on");
            }
            else
            {
                settings.alwaysOnTop = false;
                TopMost = false;
                StatusPanelMessage("always-top-off");
            }

        }

        private void PasswordGeneratorMainMenu_Click(object sender, EventArgs e)
        {
            PasswordGeneratorFrom passwordGeneratorFrom = new PasswordGeneratorFrom();
            passwordGeneratorFrom.ShowDialog(this);
        }

        private void ChangePasswordMainMenu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                ChangePasswordForm changePasswordForm = new ChangePasswordForm();
                changePasswordForm.ShowDialog(this);
            }
        }

        private async void LockMainMenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                return;
            }

            mainMenu.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;
            toolbarPanel.Enabled = false;
            richTextBox.SuspendDrawing();
            UseWaitCursor = true;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(await AES.Encrypt(richTextBox.Text, PublicVar.password.Get(), null, settings.HashAlgorithm,
                    Convert.ToInt32(settings.PasswordIterations), Convert.ToInt32(settings.KeySize)));
                writer.Close();
            }
            richTextBox.ResumeDrawing();
            UseWaitCursor = false;
            fileLockedPanel.Visible = true;
        }

        private void SettingsMainMenu_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm
            {
                Owner = this
            };
            settingsForm.ShowDialog();
        }
        /*Tools*/

        /*Paste Board*/
        string clipboardLastText = "";
        private void PasteBoardTimer_Tick(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            if (!string.IsNullOrEmpty(clipboardText) && clipboardLastText != clipboardText)
            {
                clipboardLastText = clipboardText;
                if (richTextBox.Text.Length > 0)
                {
                    richTextBox.AppendText("\n\n" + clipboardText);
                    richTextBox.SelectionStart = richTextBox.Text.Length;
                    richTextBox.ScrollToCaret();
                }
                else
                {
                    richTextBox.AppendText(clipboardText);
                }
            }
        }

        private void PasteBoardMainMenu_Click(object sender, EventArgs e)
        {
            if (pasteBoardMainMenu.Checked)
            {
                Clipboard.Clear();
                pasteBoardTimer.Start();
                statusPanelPasteboardLabel.Text = "Paste Board: " + pasteBoardMainMenu.Checked.ToString();
            }
            else
            {
                pasteBoardTimer.Stop();
                statusPanelPasteboardLabel.Text = "Paste Board: " + pasteBoardMainMenu.Checked.ToString();
            }
        }
        /*Paste Board*/

        /*Help*/
        private void DocumentationMainMenu_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Crypto-Notepad/Crypto-Notepad/wiki/Documentation");
        }

        private async void CheckForUpdatesMainMenu_Click(object sender, EventArgs e)
        {
            await CheckForUpdates(true);
        }

        private void AboutMainMenu_Click(object sender, EventArgs e)
        {
            AboutFrom aboutFrom = new AboutFrom();
            aboutFrom.Owner = this;
            aboutFrom.ShowDialog(this);
        }
        /*Help*/
        #endregion


        #region Editor Menu
        private void ContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (richTextBox.SelectionLength != 0)
            {
                cutContextMenu.Enabled = true;
                copyContextMenu.Enabled = true;
                deleteContextMenu.Enabled = true;
            }
            else
            {
                cutContextMenu.Enabled = false;
                copyContextMenu.Enabled = false;
                deleteContextMenu.Enabled = false;
            }
        }

        private void UndoContextMenu_Click(object sender, EventArgs e)
        {
            UndoMainMenu_Click(this, new EventArgs());
        }

        private void RedoContextMenu_Click(object sender, EventArgs e)
        {
            RedoMainMenu_Click(this, new EventArgs());
        }

        private void CutContextMenu_Click(object sender, EventArgs e)
        {
            CutMainMenu_Click(this, new EventArgs());
        }

        private void CopyContextMenu_Click(object sender, EventArgs e)
        {
            CopyMainMenu_Click(this, new EventArgs());
        }

        private void PasteContextMenu_Click(object sender, EventArgs e)
        {
            PasteMainMenu_Click(this, new EventArgs());
        }

        private void DeleteContextMenu_Click(object sender, EventArgs e)
        {
            DeleteMainMenu_Click(this, new EventArgs());
        }

        private void SelectAllContextMenu_Click(object sender, EventArgs e)
        {
            SelectAllMainMenu_Click(this, new EventArgs());
        }

        private void RightToLeftContextMenu_Click(object sender, EventArgs e)
        {
            if (rightToLeftContextMenu.Checked)
            {
                if (!richTextBox.WordWrap)
                {
                    string rtbTxt = richTextBox.Text;
                    richTextBox.Clear();
                    richTextBox.RightToLeft = RightToLeft.Yes;
                    Application.DoEvents();
                    richTextBox.Text = rtbTxt;
                }
                else
                {
                    string rtbTxt = richTextBox.Text;
                    richTextBox.Clear();
                    richTextBox.RightToLeft = RightToLeft.Yes;
                    Application.DoEvents();
                    richTextBox.Text = rtbTxt;
                }
                settings.editorRightToLeft = true;
                richTextBox.Modified = false;
            }
            else
            {
                richTextBox.RightToLeft = RightToLeft.No;
                settings.editorRightToLeft = false;
                richTextBox.Modified = false;
            }
            settings.Save();
        }

        private void ClearContextMenu_Click(object sender, EventArgs e)
        {
            if (!readOnlyMainMenu.Checked)
            {
                ClearMainMenu_Click(this, new EventArgs());
            }
        }
        #endregion


        #region Toolbar
        private void NewToolbarButton_Click(object sender, EventArgs e)
        {
            NewMainMenu_Click(this, new EventArgs());
        }

        private void OpenToolbarButton_Click(object sender, EventArgs e)
        {
            OpenMainMenu_Click(this, new EventArgs());
        }

        private void SaveToolbarButton_Click(object sender, EventArgs e)
        {
            SaveMainMenu_Click(this, new EventArgs());
        }

        private void FileLocationToolbarButton_Click(object sender, EventArgs e)
        {
            OpenFileLocationMainMenu_Click(this, new EventArgs());
        }

        private void DeleteFileToolbarButton_Click(object sender, EventArgs e)
        {
            DeleteFileToolStripMenuItem_Click(this, new EventArgs());
        }

        private void CutToolbarButton_Click(object sender, EventArgs e)
        {
            CutMainMenu_Click(this, new EventArgs());
        }

        private void CopyToolbarButton_Click(object sender, EventArgs e)
        {
            CopyMainMenu_Click(this, new EventArgs());
        }

        private void PasteToolbarButton_Click(object sender, EventArgs e)
        {
            PasteMainMenu_Click(this, new EventArgs());
        }

        private void ChangePasswordToolbarButton_Click(object sender, EventArgs e)
        {
            ChangePasswordMainMenu_Click(this, new EventArgs());
        }

        private void SettingsToolbarButton_Click(object sender, EventArgs e)
        {
            SettingsMainMenu_Click(this, new EventArgs());
        }

        private void LockToolbarButton_Click(object sender, EventArgs e)
        {
            LockMainMenu_Click(this, new EventArgs());
        }

        private void TryToDecryptToolbarButton_Click(object sender, EventArgs e)
        {
            TryToDecryptMainMenu_Click(this, new EventArgs());
        }

        private void CloseToolbarButton_Click(object sender, EventArgs e)
        {
            toolbarPanel.Visible = false;
            settings.toolbarVisible = false;
        }

        private void CloseToolbarButton_MouseEnter(object sender, EventArgs e)
        {
            closeToolbarButton.ForeColor = Color.DimGray;
        }

        private void CloseToolbarButton_MouseLeave(object sender, EventArgs e)
        {
            closeToolbarButton.ForeColor = Color.DarkGray;
        }

        private void AlwaysOnTopToolbarButton_Click(object sender, EventArgs e)
        {
            if (settings.alwaysOnTop)
            {
                settings.alwaysOnTop = false;
                TopMost = settings.alwaysOnTop;
                alwaysOnTopMainMenu.Checked = settings.alwaysOnTop;
                StatusPanelMessage("always-top-off");
            }
            else
            {
                settings.alwaysOnTop = true;
                TopMost = settings.alwaysOnTop;
                alwaysOnTopMainMenu.Checked = settings.alwaysOnTop;
                StatusPanelMessage("always-top-on");
            }
        }

        private void ToolbarPanel_MouseEnter(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength != 0)
            {
                cutToolbarButton.Enabled = true;
                copyToolbarButton.Enabled = true;
            }
            else
            {
                cutToolbarButton.Enabled = false;
                copyToolbarButton.Enabled = false;
            }

            if (string.IsNullOrEmpty(PublicVar.password.Get()))
            {
                fileLocationToolbarButton.Enabled = false;
                deleteFileToolbarButton.Enabled = false;
                changePasswordToolbarButton.Enabled = false;
                lockToolbarButton.Enabled = false;
            }
            else
            {
                fileLocationToolbarButton.Enabled = true;
                deleteFileToolbarButton.Enabled = true;
                changePasswordToolbarButton.Enabled = true;
                lockToolbarButton.Enabled = true;
            }

            if (string.IsNullOrEmpty(PublicVar.password.Get()) && richTextBox.TextLength > 0 && !string.IsNullOrEmpty(filePath))
            {
                tryToDecryptToolbarButton.Enabled = true;
            }
            else
            {
                tryToDecryptToolbarButton.Enabled = false;
            }

        }
        #endregion


        #region Search Panel
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            findPos = 0;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                searchTextBox.Text = "";
                searchPanel.Visible = false;
                richTextBox.Focus();
                richTextBox.DeselectAll();
                e.Handled = e.SuppressKeyPress = true;
                findPos = 0;
            }
            if (e.KeyCode == Keys.Enter & searchPanel.Visible & !string.IsNullOrEmpty(searchTextBox.Text))
            {
                SearchFindNextButton_MouseUp(null, null);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void SearchCloseButton_Click(object sender, EventArgs e)
        {
            FindMainMenu_Click(this, new EventArgs());
        }

        private void SearchCaseSensitiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            findPos = 0;
            richTextBox.DeselectAll();
            searchTextBox.Focus();
        }

        private void SearchWholeWordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            findPos = 0;
            richTextBox.DeselectAll();
            searchTextBox.Focus();
        }

        private void FindText(string text, RichTextBoxFinds findOptions)
        {
            if (text.Length > 0)
            {
                try
                {
                    findPos = richTextBox.Find(searchTextBox.Text, findPos, findOptions);
                    if (findPos == -1)
                    {
                        findPos = 0;
                        searchTextBox.Focus();
                        return;
                    }
                    richTextBox.Focus();
                    richTextBox.Select(findPos, searchTextBox.Text.Length);
                    findPos += searchTextBox.Text.Length + 1;
                }
                catch
                {
                    findPos = 0;
                }
            }
        }

        private void SearchFindNextButton_MouseUp(object sender, MouseEventArgs e)
        {
            if ((!searchWholeWordCheckBox.Checked) & (!searchCaseSensitiveCheckBox.Checked))
            {
                FindText(searchTextBox.Text, RichTextBoxFinds.None);
            }
            else if (searchWholeWordCheckBox.Checked & searchCaseSensitiveCheckBox.Checked)
            {
                FindText(searchTextBox.Text, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);
            }
            else if (searchCaseSensitiveCheckBox.Checked)
            {
                FindText(searchTextBox.Text, RichTextBoxFinds.MatchCase);
            }
            else if (searchWholeWordCheckBox.Checked)
            {
                FindText(searchTextBox.Text, RichTextBoxFinds.WholeWord);
            }
        }

        private void SearchFindNextButton_MouseEnter(object sender, EventArgs e)
        {
            currentClipboardText = Clipboard.GetText();
        }

        private void SearchFindNextButton_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(currentClipboardText);
        }
        #endregion


        #region AutoLock
        private void FileLockedKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fileLockedKeyTextBox.Text.Length > 0)
            {
                fileLockedOkButton.Enabled = true;
            }
            else
            {
                fileLockedOkButton.Enabled = false;
            }
        }

        private void FileLockedPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (fileLockedPanel.Visible)
            {
                foreach (ToolStripItem item in mainMenu.Items)
                {
                    if (item is ToolStripDropDownItem)
                        foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)item).DropDownItems)
                        {
                            dropDownItem.Enabled = false;
                        }
                }
                if (searchPanel.Visible)
                {
                    searchTextBox.Text = "";
                    searchPanel.Visible = false;
                }
                PublicVar.password.Set(null);
                caretPos = richTextBox.SelectionStart;
                richTextBox.Visible = false;
                settingsToolStripMenuItem.Enabled = false;
                toolbarPanel.Enabled = false;
                mainMenu.Enabled = false;
                richTextBox.Clear();
                StatusPanelTextInfo();
                statusPanelModifiedLabel.Text = "Modified";
                statusPanelModifiedLabel.ToolTipText = null;
                statusPanelSizeLabel.Text = "Size";
                fileLockedKeyTextBox.Focus();
            }
            else
            {
                foreach (ToolStripItem item in mainMenu.Items)
                {
                    if (item is ToolStripDropDownItem)
                        foreach (ToolStripItem dropDownItem in ((ToolStripDropDownItem)item).DropDownItems)
                        {
                            dropDownItem.Enabled = true;
                        }
                }

                richTextBox.Visible = true;
                toolbarPanel.Enabled = true;
                searchPanel.Enabled = true;
                mainMenu.Enabled = true;
                fileLockedKeyTextBox.Text = "";
            }
        }

        private async void FileLockedOkButton_Click(object sender, EventArgs e)
        {
            await UnlockFile();
        }

        private void FileLockedCloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            settingsToolStripMenuItem.Enabled = true;
            fileLockedPanel.Visible = false;
            Text = PublicVar.appName;
            filePath = "";
            PublicVar.openFileName = "";
        }

        private void FileLockedShowKey_Click(object sender, EventArgs e)
        {
            if (fileLockedKeyTextBox.UseSystemPasswordChar)
            {
                fileLockedKeyTextBox.UseSystemPasswordChar = false;
                fileLockedShowKey.Image = Resources.eye;
            }
            else
            {
                fileLockedKeyTextBox.UseSystemPasswordChar = true;
                fileLockedShowKey.Image = Resources.eye_half;
            }
        }

        private void FileLockedKeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter & fileLockedOkButton.Enabled)
            {
                FileLockedOkButton_Click(sender, e);
            }
        }

        private void FileLockedCloseButton_MouseEnter(object sender, EventArgs e)
        {
            fileLockedCloseButton.ForeColor = Color.Silver;
        }

        private void FileLockedCloseButton_MouseLeave(object sender, EventArgs e)
        {
            fileLockedCloseButton.ForeColor = Color.DimGray;
        }
        #endregion


        #region Tray
        private void ResetWindowLocationTrayMenu_Click(object sender, EventArgs e)
        {
            Location = new Point(1, 1);
        }
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterScreen
            };
            settingsForm.ShowDialog();
        }
        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!Visible)
                {
                    Show();
                    WindowState = currentWindowState;
                    if (!fileLockedPanel.Visible)
                    {
                        richTextBox.Visible = true;
                    }
                }
            }
        }
        private void HideWindowTrayMenu_Click(object sender, EventArgs e)
        {
            currentWindowState = WindowState;
            WindowState = FormWindowState.Minimized;
            Hide();
        }
        private void ShowWindowTrayMenu_Click(object sender, EventArgs e)
        {
            if (!Visible)
            {
                Show();
                WindowState = currentWindowState;
                if (!fileLockedPanel.Visible)
                {
                    richTextBox.Visible = true;
                }
            }
        }
        private void ExitTrayMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TrayMenu_Opening(object sender, CancelEventArgs e)
        {
            if (Visible)
            {
                showWindowTrayMenu.Enabled = false;
            }
            else
            {
                showWindowTrayMenu.Enabled = true;
            }

            if (!Visible)
            {
                hideWindowTrayMenu.Enabled = false;
            }
            else
            {
                hideWindowTrayMenu.Enabled = true;
            }
        }
        #endregion


        #region Debug Menu
        private void VariablesMainMenu_Click(object sender, EventArgs e)
        {
#if DEBUG
            string formattedTime = DateTime.Now.ToString("yyyy.MM.dd hh:mm:ss");
            Debug.WriteLine("\nTime: " + formattedTime);
            Debug.WriteLine("PublicVar.openFileName: " + PublicVar.openFileName);
            Debug.WriteLine("openFileDialog.FileName " + openFileDialog.FileName);
            Debug.WriteLine("filePath: " + filePath);
            Debug.WriteLine("encryptionKey: " + PublicVar.password.Get());
            Debug.WriteLine("TypedPassword: " + TypedPassword.Value);
            Debug.WriteLine("keyChanged: " + PublicVar.passwordChanged);
            Debug.WriteLine("okPressed: " + PublicVar.okPressed);
            Debug.WriteLine("RichTextBox.Modified: " + richTextBox.Modified);
            Debug.WriteLine("EditorMenuStrip: " + contextMenu.Enabled);
            Debug.WriteLine("metadataCorrupt: " + PublicVar.metadataCorrupt);
#endif
        }







        #endregion

    }
}