using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mvp_file_manager
{



        public class Presenter
        {


            Model model;
            IView view;

            public Presenter(Model model, View view)
            {
                this.model = model;
                this.view = view;

                view.ViewEventLoadDrives += View_ViewEventLoadDrives;
                view.ViewEventLoadDir += View_ViewEventLoadDir;
                view.ViewEventLoadReturnPath += View_ViewEventLoadReturnPath;
                view.ViewButtonClicked += View_ButtonClicked;

        }
        private bool View_ButtonClicked(string action)
        {
            try
            {
                switch (action)
                {
                    case "Copy":
                        return model.CopyDir(view.SourcePath + view.SelectedItem, view.TargetPath + view.SelectedItem);
                    case "Delete":
                        return model.RemoveDir(view.SourcePath + view.SelectedItem);
                    case "Move":
                        return model.MoveDir(view.SourcePath + view.SelectedItem, view.TargetPath + view.SelectedItem);
                    default:
                        return false;

                }
            }
            catch (IOException ioexc) { view.ErrorMessage(ioexc.Message); }
            catch (System.UnauthorizedAccessException accesexc) { view.ErrorMessage(accesexc.Message); }
            catch (System.ArgumentException argexc) { view.ErrorMessage(argexc.Message); }
            return false;
        }
            private List<string> View_ViewEventLoadDir(object path, EventArgs arg2)
            {

                return model.LoadPath(path.ToString());

            }
            private List<DriveInfo> View_ViewEventLoadDrives(object arg1, EventArgs arg2)
            {
                return model.LoadDrives();
            }

            private string View_ViewEventLoadReturnPath(object path, EventArgs e)
            {
                return model.ReturnPath(path.ToString());
            }
        }
    }
