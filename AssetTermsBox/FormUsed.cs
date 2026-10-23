using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssetTermsBox
{
    public partial class FormUsed : Form
    {
        private string myParentId = "nc510840";

        public FormUsed()
        {
            InitializeComponent();

            // このツールの親登録ID
            UI_TextParent.Text += myParentId + " ";


            List<string> usedAssetList = C_ManageWorkDataFile.GetUsedAssetList();
            // 選択しているのがない
            if (usedAssetList.Count() == 0)
            {
                return;
            }




            // 権利情報、親登録情報
            Dictionary<int, Dictionary<string, string>> dataList = TD_ASSET.SelectUsedData(usedAssetList);
            UI_TextTerms.Text += "■ 使用素材 ■" + Environment.NewLine;
            for (int kindsCnt = 1;kindsCnt <= 5; kindsCnt++)
            {
                switch (kindsCnt)
                {
                    case 1:
                        UI_TextTerms.Text += "● 画像" + Environment.NewLine;
                        break;
                    case 2:
                        UI_TextTerms.Text += "● 音声" + Environment.NewLine;
                        break;
                    case 3:
                        UI_TextTerms.Text += "● フォント" + Environment.NewLine;
                        break;
                    case 4:
                        UI_TextTerms.Text += "● 合成音声" + Environment.NewLine;
                        break;
                    case 5:
                        UI_TextTerms.Text += "● その他" + Environment.NewLine;
                        break;
                }

                for (int cnt = 0; cnt < dataList.Count(); cnt++)
                {
                    Dictionary<string, string> data = dataList[cnt];
                    if (data["kinds"] != kindsCnt.ToString())
                    {
                        continue;
                    }

                    // 権利情報
                    if (data["terms"] != "")
                    {
                        UI_TextTerms.Text += data["terms"] + Environment.NewLine;
                    }

                    // 親登録
                    if (data["parent"] != "")
                    {
                        UI_TextParent.Text += data["parent"] + " ";
                    }

                }
            }

            // 共通権利情報
            string[] holderIdList = TD_ASSET.SelectUsedHolderId(usedAssetList);
            Dictionary<int, Dictionary<string, string>> holderList = TD_HOLDER.SelectTermsWhereId(holderIdList);
            UI_TextTerms.Text += "● 権利者ごと" + Environment.NewLine;
            for (int cnt = 0; cnt < holderList.Count(); cnt++)
            {
                Dictionary<string, string> holder = holderList[cnt];
                // 権利情報
                if (holder["terms"] != "")
                {
                    UI_TextTerms.Text += holder["terms"] + Environment.NewLine;
                }
            }



            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void UI_BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UI_BtnTermsCoppy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(UI_TextTerms.Text);
        }

        private void UI_BtnParentCoppy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(UI_TextParent.Text);
        }
    }
}
