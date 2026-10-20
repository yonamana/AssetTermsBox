using FolderOpearete;
using SqlOperate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssetTermsBox
{
    public partial class FormAssetInsert : Form
    {
        private int kindsValue = 1;


        public FormAssetInsert()
        {
            InitializeComponent();

            // SELECT: HOLDER
            Dictionary<int, Dictionary<string, string>> holderDataList = TD_HOLDER.SelectData();
            for (int cnt = 0; cnt < holderDataList.Count(); cnt++)
            {
                Dictionary<string, string> holderData = holderDataList[cnt];
                UI_ComboHolderName.Items.Add(holderData["name"]);
            }

            return;
        }



        private bool CheckInputData()
        {
            // ファイル
            if (kindsValue == 1 || kindsValue == 2)
            {
                if (UI_TextFile.Text.Length == 0)
                {
                    C_MessageBox.Error("ファイルを選択してください。");
                    return false;
                }

            }
            // 素材名
            if (UI_TextAssetName.Text.Length == 0)
            {
                C_MessageBox.Error("素材名を入力してください。");
                return false;
            }
            if (UI_TextAssetName.Text.Length > 100)
            {
                C_MessageBox.Error("素材名は100文字以内にしてください。");
                return false;
            }
            // 権利元名
            if (UI_ComboHolderName.Text.Length == 0)
            {
                C_MessageBox.Error("権利元名を入力してください。");
                return false;
            }
            if (UI_ComboHolderName.Text.Length > 50)
            {
                C_MessageBox.Error("権利元名は50文字以内にしてください。");
                return false;
            }
            // 共通権利情報
            if (UI_TextCommonTerms.Text.Length > 1000)
            {
                C_MessageBox.Error("共通権利情報は1000文字以内にしてください。");
                return false;
            }
            // 権利情報
            if (UI_TextTerms.Text.Length > 1000)
            {
                C_MessageBox.Error("権利情報は1000文字以内にしてください。");
                return false;
            }
            // 親登録ID
            if (UI_TextParent.Text.Length > 20)
            {
                C_MessageBox.Error("親登録IDは20文字以内にしてください。");
                return false;
            }
            // メモ
            if (UI_TextMemo.Text.Length > 1000)
            {
                C_MessageBox.Error("メモは1000文字以内にしてください。");
                return false;
            }


            return true;
        }

        private void UI_BtnKindsImage_Click(object sender, EventArgs e)
        {
            kindsValue = 1;

            UI_BtnKindsImage.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;

            UI_BtnFile.Enabled = true;
        }

        private void UI_BtnKindsSound_Click(object sender, EventArgs e)
        {
            kindsValue = 2;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;

            UI_BtnFile.Enabled = true;
        }

        private void UI_BtnKindsFont_Click(object sender, EventArgs e)
        {
            kindsValue = 3;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;

            UI_BtnFile.Enabled = false;
        }

        private void UI_BtnKindsSpeech_Click(object sender, EventArgs e)
        {
            kindsValue = 4;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsOther.BackColor = Color.White;

            UI_BtnFile.Enabled = false;
        }

        private void UI_BtnKindsOther_Click(object sender, EventArgs e)
        {
            kindsValue = 5;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.FromArgb(192, 192, 255);

            UI_BtnFile.Enabled = false;
        }

        private void UI_BtnFile_Click(object sender, EventArgs e)
        {
            if (kindsValue == 1)
            {
                string GetFileName = C_Dialog.OpenImageFile("");
                if (GetFileName != "")
                {
                    UI_TextFile.Text = GetFileName;
                    UI_TextAssetName.Text = Path.GetFileName(GetFileName);
                }
            }
            else if (kindsValue == 2)
            {
                string GetFileName = C_Dialog.OpenSoundFile("");
                if (GetFileName != "")
                {
                    UI_TextFile.Text = GetFileName;
                    UI_TextAssetName.Text = Path.GetFileName(GetFileName);
                }
            }

            return;
        }

        private void UI_BtnInsert_Click(object sender, EventArgs e)
        {
            // 入力項目の確認
            if (CheckInputData() == false)
            {
                return;
            }


            // 権利元のSELECT、INSERT
            string getHolderId = TD_HOLDER.GetId(UI_ComboHolderName.Text);
            if (getHolderId == "")
            {
                // INSERT
                getHolderId = TD_HOLDER.InsertData(UI_ComboHolderName.Text, UI_TextCommonTerms.Text);
            }
            else if (getHolderId != "" && UI_TextCommonTerms.Text != "")
            {
                TD_HOLDER.UpdateData(getHolderId, UI_ComboHolderName.Text, UI_TextCommonTerms.Text);
            }



            // データのINSERT
            string getAssetId = TD_ASSET.InsertData(
                UI_TextAssetName.Text,
                getHolderId,
                UI_TextTerms.Text,
                UI_TextParent.Text,
                UI_TextMemo.Text,
                UI_CheckBookmark.Checked,
                kindsValue
            );


            // 紐づいているタグのINSERT



            // ファイルの移動
            if (kindsValue == 1 || kindsValue == 2)
            {
                C_OperateFolder opeFolder = new C_OperateFolder();
                string fileName = Path.GetFileName(UI_TextFile.Text);
                string assetIdPath = C_CreatePath.WorkFileAssetIdPath(getAssetId);
                // 道中フォルダの作成
                opeFolder.Create(assetIdPath);
                // ファイル移動
                if (opeFolder.FileMove(UI_TextFile.Text, assetIdPath + "\\" + fileName) == false)
                {
                    C_MessageBox.Error("ファイルの移動に失敗しました。\n（移動前と移動後のファイルの確認をしてください）");
                }

            }

            this.Dispose();
            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void UI_ComboHolderName_Leave(object sender, EventArgs e)
        {
            // HOLDER.termsを取得
            Dictionary<int, Dictionary<string, string>> dataList = TD_HOLDER.GetTerms(UI_ComboHolderName.Text);
            // UIを更新
            if (dataList.Count == 0)
            {
                return;
            }
            UI_TextCommonTerms.Text = dataList[0]["terms"];
        }
    }
}
