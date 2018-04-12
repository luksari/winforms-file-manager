using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;


namespace mvp_file_manager
{
    public class Model
    {
        
        #region Constructors
        public Model() { }
        #endregion

        #region Internal Methods
        internal List<string> LoadPath(string path)
        {
            try
            {

                if (Directory.Exists(path))
                {
                    string[] dirs = Directory.GetDirectories(path);
                    string[] files = Directory.GetFiles(path);
                    List<string> allItems = new List<string>();

                    foreach (String d in dirs)
                    {
                        allItems.Add("<DIR>" + d.Remove(0, Path.GetDirectoryName(d).Length));
                    }
                    foreach (String f in files)
                    {
                        allItems.Add(f.Remove(0, Path.GetDirectoryName(f).Length));
                    }
                    return allItems;
                }
                else
                {
                    try
                    {
                        Process.Start(path);
                    }
                    catch (System.InvalidOperationException) { }
                    return null;
                }
            }
            catch (System.UnauthorizedAccessException) { return null; }
        }

        internal List<DriveInfo> LoadDrives()
        {
            List<DriveInfo> readyDrives = DriveInfo.GetDrives().Where(drive => drive.IsReady).ToList();
            return readyDrives;
        }

        internal bool CopyDir(string sourceDir, string targetDir)
        {
            if (Directory.Exists(sourceDir)) //copy folder 
            {
                Console.WriteLine(sourceDir + " target: " + targetDir);
                DirectoryCopy(sourceDir, targetDir, true);
            }
            else
            {
                //copy only files
                Console.WriteLine(sourceDir + " target: " + targetDir);
                File.Copy(sourceDir, targetDir); //the same name for the destination file 
            }
            return true;

        }
        internal bool MoveDir(string sourceDir, string targetDir)
        {

            if (Directory.Exists(sourceDir)) //copy folder 
            {
                Console.WriteLine(sourceDir + " target: " + targetDir);

                if (Directory.GetDirectoryRoot(sou­rceDir) == Directory.GetDirectoryRoot(targetDir)) // if its the same volumin, biuld in method
                {
                    Directory.Move(sourceDir, targetDir);
                }
                else
                {
                    DirectoryCopy(sourceDir, targetDir, true);
                    Directory.Delete(sourceDir, true);
                }

            }
            else File.Move(sourceDir, targetDir);
            return true;

        }
        internal bool RemoveDir(string dir) // check if user is sure to remove file, update list     
        {
            if (Directory.Exists(dir)) //delete folder recursively 
            {
                Directory.Delete(dir, true);
            }
            else
            {
                File.Delete(dir);

            }
            return true;

        }
        internal string ReturnPath(string path)
        {
            try
            {
                if (Path.GetDirectoryName(path) == null) return string.Empty;
                else return Path.GetDirectoryName(path);
            }
            catch (System.ArgumentException) { return string.Empty; }
            catch (System.UnauthorizedAccessException) { return string.Empty; } 

        }


        #endregion


        #region Private Methods
        private static void DirectoryCopy(string currentDirectory, string targetDirectory, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(currentDirectory);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + currentDirectory);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(targetDirectory, file.Name); //'System.IO.IOException -> when the filename exist!!
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(targetDirectory, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
    #endregion
}

