using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssetTermsBox
{
    public partial class FormTagDelete : Form
    {

        private FormMain m_formMain = null;

        public FormTagDelete(FormMain formMain)
        {
            InitializeComponent();

            m_formMain = formMain;

            // SQL：SELECT
            Dictionary<int, Dictionary<string, string>> tagData = TD_TAG.SelectAllData();

            // コンボボックスに値を入れる
            for (int count = 0; count < tagData.Count; count++)
            {
                Dictionary<string, string> data = tagData[count];
                comboBox1.Items.Add(data["name"]);
            }

            return;
        }

        private bool CheckInputData()
        {
            // コンボボックス
            if (comboBox1.Text.Length == 0)
            {
                C_MessageBox.Error("変更するタグを選択してください。");
                return false;
            }

            return true;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            // 入力確認
            if (CheckInputData() == false)
            {
                return;
            }
            // 確認メッセージ
            if (C_MessageBox.Check("「" + comboBox1.Text + "」を削除してよろしいですか？") == false)
            {
                return;
            }

            // TAGテーブル
            string tagId = TD_TAG.selectId(comboBox1.Text);
            TD_TAG.DeleteData(tagId);

            // WORK_TAGテーブル
            TD_ASSET_TAG.DeleteDataByTagId(tagId);

            // MainFormのリストの更新
            m_formMain.Display(true);
            this.Dispose();
            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
