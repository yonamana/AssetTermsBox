using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssetTermsBox
{
    public partial class FormTagInsert : Form
    {
        private FormMain m_formMain = null;
        public FormTagInsert(FormMain formMain)
        {
            InitializeComponent();

            m_formMain = formMain;
        }

        private bool CheckInputData()
        {
            // 入力欄
            if (UI_TextTag.Text.Length == 0)
            {
                C_MessageBox.Error("タグ名を入力してください。");
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

        private void UI_BtnInsert_Click(object sender, EventArgs e)
        {
            // 入力確認
            if (CheckInputData() == false)
            {
                return;
            }

            // TAGデータの登録
            TD_TAG.InsertData(UI_TextTag.Text);

            if (m_formMain != null)
            {
                m_formMain.Display(true);
            }
            this.Dispose();
            return;
        }
    }
}
