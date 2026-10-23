using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssetTermsBox
{
    public partial class FormTagUpdate : Form
    {
        private FormMain m_formMain = null;

        public FormTagUpdate(FormMain formMain)
        {
            InitializeComponent();

            m_formMain = formMain;

            // SQL：SELECT
            Dictionary<int, Dictionary<string, string>> tagData = TD_TAG.SelectAllData();

            // コンボボックスに値を入れる
            for (int count = 0; count < tagData.Count; count++)
            {
                Dictionary<string, string> data = tagData[count];
                UI_ComboTag.Items.Add(data["name"]);
            }
        }

        private bool CheckInputData()
        {
            // コンボボックス
            if (UI_ComboTag.Text.Length == 0)
            {
                C_MessageBox.Error("変更するタグを選択してください。");
                return false;
            }
            // 入力欄
            if (UI_TextTag.Text.Length == 0)
            {
                C_MessageBox.Error("タグ名を入力してください。");
                return false;
            }
            if (UI_TextTag.Text == UI_ComboTag.Text)
            {
                C_MessageBox.Error("変更前と違うタグ名を入力してください。");
                return false;
            }
            string id = TD_TAG.selectId(UI_TextTag.Text);
            if (id != "" && id != null)
            {
                C_MessageBox.Error("タグ名が既存のデータと被っています。");
                return false;
            }

            return true;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void UI_BtnUpdate_Click(object sender, EventArgs e)
        {
            // 入力確認
            if (CheckInputData() == false)
            {
                return;
            }

            // ドロップボックスの値のデータを、テキストボックスの値で更新
            TD_TAG.UpdateData(UI_ComboTag.Text, UI_TextTag.Text);

            // MainFormのリストの更新
            m_formMain.Display(true);
            this.Dispose();
            return;
        }
    }
}
