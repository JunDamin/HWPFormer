using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AxHWPCONTROLLib;
using System.Windows.Forms;

namespace HWPHelper
{
    public class HwpWrapper
    {
        public HwpAPI hwp;
        public string filePath = string.Empty;

        public HwpWrapper(AxHWPCONTROLLib.AxHwpCtrl hwpCtrl)
        {
            hwp = new HwpAPI(hwpCtrl);
        }

        public void setupToolBar() => hwp.setupToolBar();
        public void SetupPage() => hwp.SetupPage();

        public void Select() => hwp.ctrl.Select();

        public void SaveFile() => hwp.SaveFile();

        public void SaveAsFile(string path) => hwp.SaveAsFile(path);

        public void InsertFile(string path) => hwp.InsertFile(path);

        public void OpenFile(string path) => hwp.OpenFile(path);

        public void PutFieldText(string key, string text) => hwp.ctrl.PutFieldText(key, text);

        public void AskPermission()
        {
            Thread.Sleep(4000);
            MessageBox.Show("잠시후 나타날 HwpCtrl 접근 허가요청에서 \"모두 허용(A)\"을 눌러주세요.", "확인", MessageBoxButtons.OK);
            NewHWP();
        }

        public void CheckSavePath()
        {
            if (hwp.filePath == string.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "hwp files (*.hwp)|*.hwp";

                if (saveFileDialog.ShowDialog() == DialogResult.Yes)
                {
                    hwp.filePath = saveFileDialog.FileName;
                    hwp.SaveAsFile(hwp.filePath);
                }
            }
        }

        public void AskSave()
        {
            DialogResult res = MessageBox.Show("저장하지 않은 내용은 삭제됩니다. 기존 내용을 모두 저장하시겠습니까?", "저장하기", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                CheckSavePath();
                hwp.SaveAsFile(hwp.filePath);
            }
        }

        public DialogResult PreClosingConfirmation()
        {
            DialogResult res = MessageBox.Show("프로그램을 종료하면 저장하지 않은 내용은 모두 사라집니다. 내용을 저장하시겠습니까?", "저장하기", MessageBoxButtons.YesNoCancel);
            return res;
        }

        public void NewHWP()
        {
            if (hwp.filePath != string.Empty) AskSave();
            hwp.filePath = string.Empty;

            var path = "templates\\page.hwp";
            hwp.OpenFile(Path.GetFullPath(path));
        }
        public void OpenHWP()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "hwp files (*.hwp)|*.hwp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                hwp.filePath = openFileDialog.FileName;
                hwp.OpenFile(hwp.filePath);
            }
        }

        public bool SaveHWP()
        {
            if (hwp.filePath == string.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "hwp files (*.hwp)|*.hwp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    hwp.filePath = saveFileDialog.FileName;
                    hwp.SaveAsFile(hwp.filePath);
                }
                else return false;
            }
            else
            {
                hwp.SaveAsFile(hwp.filePath);
            }
            return true;
        }

    }
}
