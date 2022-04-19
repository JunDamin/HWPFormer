using System.IO;


namespace HWPFormer
{
	partial class MainForm
	{
        public void SetupPage()
        {

        }
		private void setupToolBar()
		{
			_ = axHwpCtrl1.SetToolBar(-1, "#0;1:TOOLBAR_MENU"); // #(position);(show):Toolbar name
            _ = axHwpCtrl1.SetToolBar(-1, "#1;1:TOOLBAR_STANDARD");
            axHwpCtrl1.ShowToolBar(1);
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
            HWPCONTROLLib.DHwpAction act = (HWPCONTROLLib.DHwpAction)axHwpCtrl1.CreateAction(action);
            return act;
        }
        private HWPCONTROLLib.DHwpParameterSet CreateSet(string action)
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

        public void SaveFile()
        {
            axHwpCtrl1.Save();
        }

        public void SaveAsFile(string path)
        {
            var fpath = Path.GetFullPath(path);
            axHwpCtrl1.SaveAs(fpath);
        }

        public void OpenFile(string path)
        {
            axHwpCtrl1.Open(path);
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