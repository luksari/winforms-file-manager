using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mvp_file_manager
{
    public interface IView
    {
        string SourcePath { get; set; }
        string TargetPath { get; set; }
        string SelectedItem { get; set; }

        event Func<object, EventArgs, List<DriveInfo>> ViewEventLoadDrives;
        event Func<object, EventArgs, List<string>> ViewEventLoadDir;
        event Func<object, EventArgs, string> ViewEventLoadReturnPath;
        event Func<string, bool> ViewButtonClicked;

        void ErrorMessage(string message);
    }
}
