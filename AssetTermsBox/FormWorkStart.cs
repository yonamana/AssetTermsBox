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
    public partial class FormWorkStart : Form
    {
        public FormWorkStart()
        {
            InitializeComponent();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void UI_BtnCreate_Click(object sender, EventArgs e)
        {
            if (CheckInputData() == false)
            {
                return;
            }

            string createPath = C_CreatePath.WorkDataPath();
            string createFilePath = createPath + UI_TextNewName.Text + ".txt";
            // 道中フォルダの作成
            C_OperateFolder opeFolder = new C_OperateFolder();
            opeFolder.Create(createPath);
            
            // 同名ファイルの存在を確認
            string[] files = System.IO.Directory.GetFiles(createPath, "*", System.IO.SearchOption.AllDirectories);
            foreach (string file in files)
            {
                if (createFilePath == file)
                {
                    C_MessageBox.Error("同名の作業が存在します。");
                    return;
                }
            }

            // ファイルの作成
            File.Create(createFilePath).Close();

            C_ManageWorkDataFile.SetWorkDataFilePath(createFilePath);

            this.Dispose();
            return;
        }

        private bool CheckInputData()
        {
            if (UI_TextNewName.Text.Length == 0)
            {
                C_MessageBox.Error("");
                return false;
            }
            if (UI_TextNewName.Text.Length > 50)
            {
                C_MessageBox.Error("");
                return false;
            }

            return true;
        }
    }
}
