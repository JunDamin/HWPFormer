using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxHWPCONTROLLib;

namespace HWPHelper
{
    class HwpWrapper
    {
        private AxHwpCtrl hwp;
        public HwpWrapper(AxHWPCONTROLLib.AxHwpCtrl hwpCtrl)
        {
            hwp = hwpCtrl;
        }

        public void SetupPage()
        {

        }
        public void setupToolBar()
        {
            _ = hwp.SetToolBar(-1, "#0;1:TOOLBAR_MENU"); // #(position);(show):Toolbar name
            _ = hwp.SetToolBar(-1, "#1;1:TOOLBAR_STANDARD");
            hwp.ShowToolBar(1);
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
            HWPCONTROLLib.DHwpAction act = (HWPCONTROLLib.DHwpAction)hwp.CreateAction(action);
            return act;
        }
        private HWPCONTROLLib.DHwpParameterSet CreateSet(string action)
        {
            HWPCONTROLLib.DHwpParameterSet set = (HWPCONTROLLib.DHwpParameterSet)hwp.CreateSet(action);
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
            hwp.Save();
        }

        public void SaveAsFile(string path)
        {
            var fpath = Path.GetFullPath(path);
            hwp.SaveAs(fpath);
        }

        public void OpenFile(string path)
        {
            hwp.Open(path);
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

