using System.IO;


namespace HWPFormer
{
	partial class Main
	{
        private void SetupPage()
        {

        }
		private void setupToolBar()
		{
			_ = axHwpCtrl1.SetToolBar(-1, "#0;1:TOOLBAR_MENU"); // #(position);(show):Toolbar name
            _ = axHwpCtrl1.SetToolBar(-1, "#1;1:TOOLBAR_STANDARD");
            axHwpCtrl1.ShowToolBar(1);
		}

        public struct Action
        {
            public Action(HWPCONTROLLib.DHwpAction action, HWPCONTROLLib.DHwpParameterSet param)
            {
                Act = action;
                Set = param;
            }

            public HWPCONTROLLib.DHwpAction Act { get; }
            public HWPCONTROLLib.DHwpParameterSet Set { get; }
        }
        public HWPCONTROLLib.DHwpAction CreateAction(string action)
        {
            HWPCONTROLLib.DHwpAction act = (HWPCONTROLLib.DHwpAction)axHwpCtrl1.CreateAction(action);
            return act;
        }
        public HWPCONTROLLib.DHwpParameterSet CreateSet(string action)
        {
            HWPCONTROLLib.DHwpParameterSet set = (HWPCONTROLLib.DHwpParameterSet)axHwpCtrl1.CreateSet(action);
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

        private void SaveFile()
        {
            axHwpCtrl1.Save();
        }

        private void SaveAsFile(string path)
        {
            var fpath = Path.GetFullPath(path);
            axHwpCtrl1.SaveAs(fpath);
        }

        private void OpenFile(string path)
        {
            axHwpCtrl1.Open(path);
        }

        private void InsertFile(string path)
        {
            var actionSet = GetActionSet("InsertFile");
            var fpath = Path.GetFullPath(path);
            actionSet.Set.SetItem("FileName", fpath);
            actionSet.Act.Execute(actionSet.Set);
        }
    }
}