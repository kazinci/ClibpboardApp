using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;
using Path = System.IO.Path;

namespace ClipboardApp
{
    public partial class MainWindow : Form
    {
        // Variable declaration
        
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        IntPtr _nextClipboardViewer;

        private int _counter; //clipboard item counter
        private bool _enabled; //  ClipBoard monitor enable/disable switch
        public static string FileName; // the filename, where the ClipBoard-Data saved
        private bool _gDriveLogging; // google Drive saving enable/disable switch
        public static string Minute; // google Drive sync minutes
        public static string Hour; // google Drive sync hours
        public static string SaveFileName; // file-location, where to save automatically clipboard-data
        public static bool AutoSave; // option to turn on or off auto saving to defined location
        public static bool StartNewDate; // option to turn on or off clearing history every day
        private long _elapsed; //elapsed time between Clipboard events
        private string _oldFileName; // used to temporaly store file-name for saving
        
        Stopwatch sw = new Stopwatch();

        // Methods, functions

        public MainWindow()
        {
            InitializeComponent();
            _elapsed = 1000;
            _enabled = true;
            _gDriveLogging = false;
            Minute = "00";
            Hour = "00";
            timer.Start();
            _nextClipboardViewer = (IntPtr)SetClipboardViewer((int)Handle);
        }

        // clipboard change monitor
        protected override void WndProc(ref Message m)
        {
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    if (_enabled)
                    {
                        sw.Stop();
                        _elapsed = sw.ElapsedMilliseconds;

                        if (_elapsed == 0)
                        {
                            goto  Quit;
                        }
                        
                        DisplayClipboardData(); // Event Listener
                    }

                    Quit:
                    sw.Restart();
                    SendMessage(_nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == _nextClipboardViewer)
                        _nextClipboardViewer = m.LParam;
                    else
                        SendMessage(_nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        // executed if clipboard has changed
        void DisplayClipboardData()
        {
            try
            {
                IDataObject iData = Clipboard.GetDataObject();

                //checking data-format inside the clipborad

                if (iData != null && iData.GetDataPresent(DataFormats.Text))
                {
                    string data = (string) iData.GetData(DataFormats.Text);
                    ClipboardLogger(data); // calling next method
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        // saves and displays the clipboard history
        void ClipboardLogger(string data)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToString("T");
            dataSet.Tables["Table1"].Rows.Add(_counter.ToString("D"), data, date, time);
            _counter++;

            
            
            if (AutoSave)
            {
                if (StartNewDate)
                {
                    // if enabled it will create new files every day at 00:00 in the given directory
                    FileName = String.Format("{0}\\{1}-{2}.xlsx", Path.GetDirectoryName(SaveFileName), Path.GetFileNameWithoutExtension(SaveFileName), date);
                }
                else
                {
                    // if "saving to HDD" enabled on in "Options Window", the program will use it
                    FileName = SaveFileName;
                }
            }
            else
            {
                // if "saving to HDD" not turned on in "Options Window" we create Excel files in the same directory where the program installed
                if (StartNewDate)
                {
                    // if enabled it will create new files every day at 00:00
                    FileName = Path.Combine(Directory.GetCurrentDirectory(), String.Format("{0}.xlsx", date));
                    _oldFileName = FileName;
                }
                else
                {
                    // if disabled it will use the last filename
                    if (_oldFileName == null)
                    {
                        _oldFileName = Path.Combine(Directory.GetCurrentDirectory(), String.Format("{0}.xlsx", date));
                    }
                    FileName = _oldFileName; // owerwrite with previous value
                }
            }

            SAVINGPROCESS:
            
            try
            {
                CreateExcelFile.CreateExcelDocument(dataSet, FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("Excel creation error: {0}", exception.Message));
            }
            
            
        }
        
        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                trayIcon.Visible = false;
                Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewHistoryLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHistory();
        }

        private void ViewHistory()
        {
            if (File.Exists(FileName))
                Process.Start(FileName);
            else
                MessageBox.Show("Sorry, no clipboard data collected yet!");
        }

        private void exportCurrentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                File.Copy(FileName, saveFileDialog.FileName, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(String.Format("File saving error: {0}", exception.Message));
            }
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(FileName))
                Process.Start(FileName);
            else
                MessageBox.Show("Sorry, no clipboard data collected yet!");
        }

        private void disableLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_enabled)
                DisableLogging();
            else
                EnableLogging();
        }

        private void clearCurrentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearHistory();
        }

        private void ClearHistory()
        {
            dataSet.Tables["Table1"].Rows.Clear();
            _counter = 0; 
        }

        private void disableLoggingEnableLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_enabled)
                DisableLogging();
            else
                EnableLogging();
        }

        private void DisableLogging()
        {
            disableLoggingEnableLoggingToolStripMenuItem.Text = "Disable Logging / Enable Logging (Disabled!)";
            clipSavingLabel.Text = "Clipboard Saving: Disabled";
            _enabled = false;
        }

        private void EnableLogging()
        {
            disableLoggingEnableLoggingToolStripMenuItem.Text = "Disable Logging / Enable Logging (Enabled!)";
            clipSavingLabel.Text = "Clipboard Saving: Enabled";
            _enabled = true;
        }

        private void enterGoogleDriveInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettingsWindow();
        }

        private void OpenSettingsWindow()
        {
            SettingsWindow set = new SettingsWindow();
            set.ShowDialog();
        }

        private void saveToGoogleDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartUpload(); // Upload to google drive
        }

        private void enableGoogleDriveLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gDriveLogging)
                EnableGoogleDriveLogging();
            else
                DisableGoogleDriveLogging();
        }

        private void EnableGoogleDriveLogging()
        {
            enableGoogleDriveLoggingToolStripMenuItem.Text = "Enable Google Drive Logging (Enabled!)";
            syncWithGoogleLabel.Text = "Synchronization with Google Drive: Enabled";
            syncTimeLabel.Text = String.Format("Sync Time: {0} : {1}", Hour, Minute);
            _gDriveLogging = true;
        }

        private void DisableGoogleDriveLogging()
        {
            enableGoogleDriveLoggingToolStripMenuItem.Text = "Enable Google Drive Logging (Disabled!)";
            syncWithGoogleLabel.Text = "Synchronization with Google Drive: Disabled";
            syncTimeLabel.Text = String.Empty;
            _gDriveLogging = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (sw.ElapsedMilliseconds > 1000000)
                sw.Stop();
            if (DateTime.Now.ToString("hh:mm") == String.Format("{0}:{1}",Hour,Minute) && _gDriveLogging)
                StartUpload(); // Upload to google drive
            if (StartNewDate && DateTime.Now.ToString("hh:mm") == "00:00")
                ClearHistory();
            
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SettingsWindow set = new SettingsWindow();
            set.ShowDialog();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            StartUpload();
        }

        private void StartUpload()
        {
            uploadBtn.Enabled = false;
            try
            {
                backgroundWorker.RunWorkerAsync(); // run on a separate thread
            }
            catch (Exception)
            {
                MessageBox.Show("Upload process already started!");
            }
        }

        private void viewHistoryBtn_Click(object sender, EventArgs e)
        {
            ViewHistory();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearHistory();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            OpenSettingsWindow();
        }

        private void enableGoogleBtn_Click(object sender, EventArgs e)
        {
            disableGoogleBtn.Enabled = true;
            enableGoogleBtn.Enabled = false;
            EnableGoogleDriveLogging();
        }

        private void disableGoogleBtn_Click(object sender, EventArgs e)
        {
            disableGoogleBtn.Enabled = false;
            enableGoogleBtn.Enabled = true;
            DisableGoogleDriveLogging();
        }

        private void enableLoggingBtn_Click(object sender, EventArgs e)
        {
            enableLoggingBtn.Enabled = false;
            disableLoggingBtn.Enabled = true;
            EnableLogging();
        }

        private void disableLoggingBtn_Click(object sender, EventArgs e)
        {
            enableLoggingBtn.Enabled = true;
            disableLoggingBtn.Enabled = false;
            DisableLogging();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            UploadToGoogleDrive.AuthorizeAndUpload(); // Upload to google drive
        }

        private void newLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearHistory();
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = true;
            Hide();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("^(C)");
            /*
            string buffer = String.Empty;
            bool first = true;
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                if (!first)
                {
                    buffer += "\n";
                }
                buffer += cell.Value.ToString();
                first = false;
            }
            //Copy to clipboard
            Clipboard.SetText(buffer);
            */
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void DeleteRow()
        {
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                dataSet.Tables["Table1"].Rows.RemoveAt(cell.RowIndex);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            uploadBtn.Enabled = true;
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            _enabled = false;
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            _enabled = true;
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46) // 46 is the ASCII representation of 'Delete' button
            {
                DeleteRow();
            }
        }
        
    }
}
