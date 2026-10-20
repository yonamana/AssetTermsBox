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
        private string myParentId = "kariNumber";

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

            // 共通権利情報
            string[] holderIdList = TD_ASSET.SelectUsedHolderId(usedAssetList);
            Dictionary<int, Dictionary<string, string>> holderList = TD_HOLDER.SelectTermsWhereId(holderIdList);
            for (int cnt = 0; cnt < holderList.Count(); cnt++)
            {
                Dictionary<string, string> holder = holderList[cnt];
                // 権利情報
                if (holder["terms"] != "")
                {
                    UI_TextTerms.Text += holder["terms"] + Environment.NewLine;
                }
            }
            UI_TextTerms.Text += Environment.NewLine;


            // 権利情報、親登録情報
            Dictionary<int, Dictionary<string, string>> dataList = TD_ASSET.SelectUsedData(usedAssetList);


            for (int cnt = 0; cnt < dataList.Count(); cnt++)
            {
                Dictionary<string, string> data = dataList[cnt];

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
    }
}
