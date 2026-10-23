using FolderOpearete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssetTermsBox
{
    public partial class FormAssetUpdate : Form
    {
        private int kindsValue = 1;
        private string updateAssetId = "";

        private FormMain m_formMain = null;
        


        public FormAssetUpdate(FormMain formMain, string assetId)
        {
            InitializeComponent();

            m_formMain = formMain;
            updateAssetId = assetId;

            // SELECT: HOLDER
            Dictionary<int, Dictionary<string, string>> holderDataList = TD_HOLDER.SelectData();
            for (int cnt = 0; cnt < holderDataList.Count(); cnt++)
            {
                Dictionary<string, string> data = holderDataList[cnt];
                UI_ComboHolderName.Items.Add(data["name"]);
            }



            // データの表示
            Dictionary<string, string> assetData = TD_ASSET.SelectDataOne(assetId);
            UI_TextAssetName.Text = assetData["name"];
            UI_TextTerms.Text = assetData["terms"];
            UI_TextParent.Text = assetData["parent"];
            UI_TextMemo.Text = assetData["memo"];
            if (assetData["bookmark"] == "1")
            {
                UI_CheckBookmark.Checked = true;
            }

            switch (assetData["kinds"])
            {
                case "1":
                    ChangeKindsImage();
                    break;
                case "2":
                    ChangeKindsSound();
                    break;
                case "3":
                    ChangeKindsFont();
                    break;
                case "4":
                    ChangeKindsSpeech();
                    break;
                case "5":
                    ChangeKindsOther();
                    break;
            }

            Dictionary<string, string> holderData = TD_HOLDER.SelectDataOne(assetData["holder_id"]);
            UI_ComboHolderName.Text = holderData["name"];
            UI_TextCommonTerms.Text = holderData["terms"];


            // タグのSQL
            Dictionary<int, Dictionary<string, string>> tagResult = TD_TAG.SelectAllData();

            // コンボボックスに値を入れる
            for (int count = 0; count < tagResult.Count; count++)
            {
                Dictionary<string, string> tagData = tagResult[count];
                UI_CheckedListTag.Items.Add(tagData["name"]);
            }

            // タグのチェック
            string[] nameList = C_LinkWorkTag.GetTagNameByWorkId(assetId);
            foreach (string name in nameList)
            {
                int index = UI_CheckedListTag.Items.IndexOf(name);
                UI_CheckedListTag.SetItemChecked(index, true);
            }

            return;
        }




        private bool CheckInputData()
        {
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
            ChangeKindsImage();
        }

        private void ChangeKindsImage()
        {
            kindsValue = 1;

            UI_BtnKindsImage.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;
        }

        private void UI_BtnKindsSound_Click(object sender, EventArgs e)
        {
            ChangeKindsSound();
        }

        private void ChangeKindsSound()
        {
            kindsValue = 2;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;
        }

        private void UI_BtnKindsFont_Click(object sender, EventArgs e)
        {
            ChangeKindsFont();
        }

        private void ChangeKindsFont()
        {
            kindsValue = 3;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;
        }

        private void UI_BtnKindsSpeech_Click(object sender, EventArgs e)
        {
            ChangeKindsSpeech();
        }

        private void ChangeKindsSpeech()
        {
            kindsValue = 4;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsOther.BackColor = Color.White;
        }

        private void UI_BtnKindsOther_Click(object sender, EventArgs e)
        {
            ChangeKindsOther();
        }

        private void ChangeKindsOther()
        {
            kindsValue = 5;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void UI_BtnUpdate_Click(object sender, EventArgs e)
        {
            // 入力項目の確認
            if (CheckInputData() == false)
            {
                return;
            }


            // 権利元のSELECT、INSERT、UPDATE
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



            // データのUPDATE
            TD_ASSET.UpdateData(
                updateAssetId,
                UI_TextAssetName.Text,
                getHolderId,
                UI_TextTerms.Text,
                UI_TextParent.Text,
                UI_TextMemo.Text,
                UI_CheckBookmark.Checked,
                kindsValue
            );




            

            // 今回のassetIdのタグをすべて削除
            TD_ASSET_TAG.DeleteDataByAssetId(updateAssetId);

            // 紐づいているタグのINSERT
            if (UI_CheckedListTag.CheckedItems.Count > 0)
            {
                string[] tagIdList = TD_TAG.SelectIdList(UI_CheckedListTag);

                foreach (string tagId in tagIdList)
                {
                    TD_ASSET_TAG.InsertData(updateAssetId, tagId);
                }
            }



            m_formMain.Display(true);


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
