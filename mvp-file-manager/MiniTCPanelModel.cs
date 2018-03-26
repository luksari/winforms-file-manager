using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace mvp_file_manager
{
    public class MiniTCPanelModel
    {
        #region Private Fields
        private string currentPath;
        private List<string> content;
        private List<DriveInfo> drives;
        #endregion

        #region Props
        public string CurrentPath
        {
            get
            {
                return currentPath;
            }

            set
            {
                if (Regex.IsMatch(value, @"^(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+)\\(?:[\w]+\\)*\w([\w.])+$"))
                {
                    currentPath = value;
                }
                else
                {
                    throw new Exception(value + "Doesn't match path regex");
                }
            }
        }

        public List<DriveInfo> Drives
        {
            get
            {
                return drives;
            }

            set
            {
                drives = value;
            }
        }
        public List<string> Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }
        #endregion

        #region Constructors
        public MiniTCPanelModel() { }
        #endregion

        #region Public Methods
        public void LoadDrives()
        {
            DriveInfo[] readyDrives = DriveInfo.GetDrives().Where(drive => drive.IsReady).ToArray();
            foreach(var drive in readyDrives)
            {
                Drives.Add(drive);
            }
        }
        public void SetPath(string text)
        {
            CurrentPath = text;
        }
        public void GetContent()
        {
            string[] allfiles = Directory.GetFiles(CurrentPath, "*.*", System.IO.SearchOption.AllDirectories);
            foreach (var file in allfiles)
            {
                FileAttributes attr = File.GetAttributes(file);
                if (attr.HasFlag(FileAttributes.Directory)) { file.Replace(file, "<DIR>" + file); }
                else { file.Replace(file, "<F>" + file); }
                Content.Add(file);
            }
        }
        #endregion

        #region Private Methods


        #endregion
    }
}
