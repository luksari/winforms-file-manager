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

        private List<string> dir;
        private List<DriveInfo> drives;

        public List<string> Dir
        {
            get { return dir; }
            set
            {
                dir = value;
                if (dir != null)
                {
                    foreach (String d in dir)
                    {
                        listBoxFiles.Items.Add(d);
                    }
                }
            }
        }

        public List<DriveInfo> Drives
        {
            get { return drives; }
            set
            {
                drives = value;
                comboBoxDrives.Items.Clear();
                if (drives != null)
                {
                    foreach (var d in drives)
                    {
                        comboBoxDrives.Items.Add(d);
                    }
                }
            }
        }
        public string CurrentPath
        {
            get { return textBoxPath.Text; }
            set
            {
                if (value != null && value.Contains("<DIR>"))
                {
                    int index = value.IndexOf("<");
                    textBoxPath.Text = value.Remove(index, 5);
                }
                else textBoxPath.Text = value;
            }

        }

        public string SelectedDir
        {
            get
            {
                if (listBoxFiles.SelectedItem != null)
                {
                    if (listBoxFiles.SelectedItem.ToString().StartsWith("<DIR>"))    
                                                                            
                    {
                        if (!listBoxFiles.SelectedItem.ToString().Contains("\\")) return "\\" + listBoxFiles.SelectedItem.ToString().Remove(0, 3);

                        else return listBoxFiles.SelectedItem.ToString().Remove(0, 5);
                    }
                    else if (!listBoxFiles.SelectedItem.ToString().Contains("\\")) return "\\" + listBoxFiles.SelectedItem.ToString();
                    else return listBoxFiles.SelectedItem.ToString();
                }
                else return null;


            }
            set { }
        }


        public event Func<object, EventArgs, List<string>> PanelEventLoadDir;
        public void PathChanged(object sender, EventArgs e)
        {
            if (PanelEventLoadDir != null)
            {
                listBoxFiles.Items.Clear();
                Dir = PanelEventLoadDir(this.CurrentPath, e);

            }


        }
        public event Func<object, EventArgs, List<DriveInfo>> PanelEventLoadDrives;
        private void loadDrives(object sender, EventArgs e)
        {
            if (PanelEventLoadDrives != null)
            {
                Drives = PanelEventLoadDrives(sender, e);
            }
        }

        private void changeDrive(object sender, EventArgs e)
        {
            ComboBox drives = sender as ComboBox;
            textBoxPath.Text = drives.SelectedItem.ToString();
        }



        public event Action<object, EventArgs, bool> PanelSelectedItem;

        public void SelectedItem(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null)
            {
                if (listBox.SelectedItem != null)
                {

                    PanelSelectedItem(this, e, false);
                }
                else
                {
                    PanelSelectedItem(this, e, true);
                }
            }
            else PanelSelectedItem(this, e, true);

        }
        
        public void ClearSelected()
        {

            listBoxFiles.ClearSelected();
        }

        private void ExecutePath(object sender, EventArgs e)
        {

            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                CurrentPath = CurrentPath + listBox.SelectedItem.ToString();
            }
            SelectedItem(sender, e); 
        }

        public event Func<object, EventArgs, string> PanelEventReturnPath;
        private void ReturnButtonClick(object sender, EventArgs e)
        {
            CurrentPath = PanelEventReturnPath(this.CurrentPath, e);
            SelectedItem(sender, e); 
        }

        public void Refresh(object sender, EventArgs e)
        {
            PathChanged(sender, e);
        }
    }
}

