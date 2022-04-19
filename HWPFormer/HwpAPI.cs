using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxHWPCONTROLLib;

namespace HWPHelper
{
    public class HwpAPI
    {
        public AxHwpCtrl ctrl;
        public string filePath = string.Empty;
        
        public HwpAPI(AxHWPCONTROLLib.AxHwpCtrl hwpCtrl)
        {
            ctrl = hwpCtrl;
        }

        public void SetRegister()
        {
            const string HNCRoot = @"HKEY_Current_User\Software\HNC\HwpCtrl\Modules";
            ctrl.Clear();
            string myProjectPath = Path.GetFullPath(".\\");
            if (Microsoft.Win32.Registry.GetValue(HNCRoot, "FilePathCheckerModuleExample", "Not Exist").Equals("Not Exist"))
            {
                Microsoft.Win32.Registry.SetValue(HNCRoot, "FilePathCheckerModuleExample", myProjectPath + "FilePathCheckerModuleExample.dll");
            }
            ctrl.RegisterModule("FilePathCheckDLL", "FilePathCheckerModuleExample");
        }

        public void SetupPage()
        {

        }
        public void setupToolBar()
        {
            _ = ctrl.SetToolBar(-1, "#0;1:TOOLBAR_MENU"); // #(position);(show):Toolbar name
            _ = ctrl.SetToolBar(-1, "#1;1:TOOLBAR_STANDARD");
            ctrl.ShowToolBar(1);
        }

        private struct Action
        {
            public Action(HWPCONTROLLib.DHwpAction action, HWPCONTROLLib.DHwpParameterSet param)
            {
                Act = action;
                Set = param;
            }

            public HWPCONTROLLib.DHwpAction Act { get; }
            public HWPCONTROLLib.DHwpParameterSet Set { get; }
        }
        private HWPCONTROLLib.DHwpAction CreateAction(string action)
        {
            HWPCONTROLLib.DHwpAction act = (HWPCONTROLLib.DHwpAction)ctrl.CreateAction(action);
            return act;
        }
        private HWPCONTROLLib.DHwpParameterSet CreateSet(string action)
        {
            HWPCONTROLLib.DHwpParameterSet set = (HWPCONTROLLib.DHwpParameterSet)ctrl.CreateSet(action);
            return set;
        }

        private Action GetActionSet(string action)
        {
            HWPCONTROLLib.DHwpAction act = CreateAction(action);
            HWPCONTROLLib.DHwpParameterSet set = CreateSet(action);
            act.GetDefault(set);
            var actionSet = new Action(act, set);
            return actionSet;
        }

        public void SaveFile()
        {
            ctrl.Save();
        }

        public void SaveAsFile(string path)
        {
            var fpath = Path.GetFullPath(path);
            ctrl.SaveAs(fpath);
        }

        public void OpenFile(string path)
        {
            ctrl.Open(path);
        }

        public void InsertFile(string path)
        {
            var actionSet = GetActionSet("InsertFile");
            var fpath = Path.GetFullPath(path);
            actionSet.Set.SetItem("FileName", fpath);
            actionSet.Act.Execute(actionSet.Set);
        }

    }
}

