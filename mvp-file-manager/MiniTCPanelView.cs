using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mvp_file_manager
{
    public partial class MiniTCPanelView : UserControl
    {
        public MiniTCPanelView()
        {
            InitializeComponent();
        }
        #region Properties
        public string CurrentPath
        {
            get
            {
                return textBoxPath.Text;
            }
            set
            {
                textBoxPath.Text = value;
            }
        }
        public string[] Files
        {
            set
            {
                foreach (string item in value)
                {
                    listBoxFiles.Items.Add(item);
                }
            }
        }
        public string[] Directories
        {
            set
            {
                listBoxFiles.Items.Clear();
                if (textBoxPath.TextLength > 4) listBoxFiles.Items.Add("...");
                foreach (string item in value)
                {
                    listBoxFiles.Items.Add("<DIR>" + item);
                }
            }
        }

        #endregion
        #region Private Methods

        private void LoadDrives(object sender, EventArgs e)
        {
            DriveInfo[] readyDrives = DriveInfo.GetDrives().Where(drive => drive.IsReady).ToArray();
            comboBoxDrives.Items.Clear();
            foreach(var drive in readyDrives)
            {
                comboBoxDrives.Items.Add(drive);
            }
        }

        private void ChangeDrive(object sender, EventArgs e)
        {
            var drive = Path.GetPathRoot(comboBoxDrives.SelectedItem.ToString());
            if (Directory.Exists(drive))
            {
                CurrentPath = comboBoxDrives.SelectedItem.ToString();
                ChangePath(CurrentPath);
            }
            else
            {
                textBoxPath.Text = "Wybrany napęd nie jest gotowy!";
                listBoxFiles.Items.Clear();
            }
        }

        private void ChangePath(string path)
        {
            CurrentPath = path;
            SetDirsAndFiles();
        }

        private void SetDirsAndFiles()
        {
            Directories = Directory.GetDirectories(CurrentPath);
            Files = Directory.GetFiles(CurrentPath);
        }
        private new void DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                if (listBoxFiles.SelectedItem.ToString() == "...")
                    ChangePath(Path.GetPathRoot(CurrentPath));
                else if (listBoxFiles.SelectedItem.ToString().StartsWith("<DIR>", StringComparison.Ordinal))
                    ChangePath(listBoxFiles.SelectedItem.ToString().Remove(0, 5));
                else
                    System.Diagnostics.Process.Start(listBoxFiles.SelectedItem.ToString());
            }
        }

        #endregion

    }
}
