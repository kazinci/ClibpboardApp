using System;
using System.Windows.Forms;

namespace ClipboardApp
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            hourBox.Text = MainWindow.Hour;
            minuteBox.Text = MainWindow.Minute;
            clearChk.Checked = MainWindow.StartNewDate;
            autoSaveChk.Checked = MainWindow.AutoSave;
            autoSaveTBox.Text = MainWindow.SaveFileName;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainWindow.SaveFileName) && autoSaveChk.Checked)
            {
                MessageBox.Show("Please select the path where you want to save clipboard data!");
                SelectBtn.PerformClick();
                return;
            }
            MainWindow.Hour = hourBox.Text;
            MainWindow.Minute = minuteBox.Text;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UploadToGoogleDrive.Authorize();           
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.SaveFileName = saveFileDialog.FileName;
            autoSaveTBox.Text = MainWindow.SaveFileName;
        }

        private void autoSaveChk_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.AutoSave = autoSaveChk.Checked;
            if (autoSaveChk.Checked)
            {
                autoSaveTBox.Enabled = true;
                SelectBtn.Enabled = true;
            }
            else
            {
                autoSaveTBox.Enabled = false;
                SelectBtn.Enabled = false;
            }
        }

        private void clearChk_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.StartNewDate = clearChk.Checked;
        }
    }
}
