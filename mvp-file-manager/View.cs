﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mvp_file_manager
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            miniTCPanel1.PanelEventLoadDir += VEventLoadDir;
            miniTCPanel2.PanelEventLoadDir += VEventLoadDir;
            miniTCPanel1.PanelEventLoadDrives += VEventLoadDrives;
            miniTCPanel2.PanelEventLoadDrives += VEventLoadDrives;
            miniTCPanel1.PanelSelectedItem += ChangeSelected;
            miniTCPanel2.PanelSelectedItem += ChangeSelected;
            miniTCPanel1.PanelEventReturnPath += VEventLoadReturnPath;
            miniTCPanel2.PanelEventReturnPath += VEventLoadReturnPath;

        }

        public string SourcePath { get; set; }
        public string TargetPath { get; set; }
        public string SelectedItem { get; set; }
        public bool Panel1Active { get; set; }
        public bool Panel2Active { get; set; }

        public event Func<object, EventArgs, List<DriveInfo>> ViewEventLoadDrives;
        public List<DriveInfo> VEventLoadDrives(object obj, EventArgs args)
        {
            return ViewEventLoadDrives(obj, args);
        }

        public event Func<object, EventArgs, List<string>> ViewEventLoadDir;
        public List<string> VEventLoadDir(object obj, EventArgs args)
        {
            return ViewEventLoadDir(obj, args);
        }

        public event Func<object, EventArgs, string> ViewEventLoadReturnPath;
        public string VEventLoadReturnPath(object path, EventArgs arg2)
        {
            return ViewEventLoadReturnPath(path, arg2);
        }
        private void ChangeSelected(object sender, EventArgs e, bool nullPath)
        {
            MiniTCPanelView miniTCPanel = sender as MiniTCPanelView;

            if (nullPath) SelectedItem = null;
            else
            {
                if (miniTCPanel.Name == "miniTCPanel1")
                {
                    miniTCPanel2.ClearSelected();
                    Panel1Active = true;
                    Panel2Active = false;   
                }
                else if (miniTCPanel.Name == "miniTCPanel2")
                {
                    miniTCPanel1.ClearSelected();
                    Panel2Active = true;
                    Panel1Active = false;
                }
            }

        }
        public event Func<string, bool> ViewButtonClicked;


        public void buttonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (Panel1Active)
            {
                SourcePath = miniTCPanel1.CurrentPath;
                TargetPath = miniTCPanel2.CurrentPath;
                SelectedItem = miniTCPanel1.SelectedDir;
            }
            else if (Panel2Active)
            {
                SourcePath = miniTCPanel2.CurrentPath;
                TargetPath = miniTCPanel1.CurrentPath;
                SelectedItem = miniTCPanel2.SelectedDir;
            }

            if (SelectedItem != null)
            {
                if (button.Text == "Delete")
                {
                    if (ViewButtonClicked(button.Text))  
                    {
                        if (Panel1Active)
                        {
                            miniTCPanel1.Refresh(sender, e);
                        }
                        else if (Panel2Active)
                        {
                            miniTCPanel2.Refresh(sender, e);
                        }
                    }
                }
                else if (TargetPath != string.Empty)
                {
                    if (ViewButtonClicked(button.Text))
                    {
                        miniTCPanel1.Refresh(sender, e);
                        miniTCPanel2.Refresh(sender, e);
                    }
                }
            }
        }

        public void ErrorMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}