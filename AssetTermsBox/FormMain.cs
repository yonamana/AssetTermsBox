using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Collections;
using System.Security.Cryptography.Xml;
using static System.Net.WebRequestMethods;

namespace AssetTermsBox
{
    public partial class FormMain : Form
    {
        private int kindsValue = 1;

        public FormMain()
        {
            InitializeComponent();

            Display();
        }

        private void UI_BtnWorkCreate_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartWorkStart();
        }

        private void UI_BtnAssetInsert_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartAssetInsert();
        }

        private void UI_BtnKindsImage_Click(object sender, EventArgs e)
        {
            kindsValue = 1;

            UI_BtnKindsImage.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;
            Display();
            SelectFirstRow();
        }

        private void UI_BtnKindsSound_Click(object sender, EventArgs e)
        {
            kindsValue = 2;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;
            Display();
            SelectFirstRow();
        }

        private void UI_BtnKindsFont_Click(object sender, EventArgs e)
        {
            kindsValue = 3;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;
            Display();
            SelectFirstRow();
        }

        private void UI_BtnKindsSpeech_Click(object sender, EventArgs e)
        {
            kindsValue = 4;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsOther.BackColor = Color.White;
            Display();
            SelectFirstRow();
        }

        private void UI_BtnKindsOther_Click(object sender, EventArgs e)
        {
            kindsValue = 5;

            UI_BtnKindsImage.BackColor = Color.White;
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.FromArgb(192, 192, 255);
            Display();
            SelectFirstRow();
        }

        private void UI_DataGridView_Click(object sender, EventArgs e)
        {
            SelectRow();
        }


        private void FormMain_Actibated(object sender, EventArgs e)
        {
            Display();
            SelectRow();

            UI_TextWorkFile.Text = C_ManageWorkDataFile.GetWorkDataFilePath();
        }



        ////////////////////////////////////////////////////////////
        // リスト
        ////////////////////////////////////////////////////////////

        internal class CD_ListSort
        {
            private DataGridViewColumn m_column;
            private SortOrder m_order;

            public const string NOT_SORT_COLUMN = "NotSortColumn";

            public CD_ListSort(DataGridViewColumn column, SortOrder order)
            {
                if (column == null)
                {
                    m_column = new DataGridViewColumn();
                    m_column.Name = NOT_SORT_COLUMN;
                }
                else
                {
                    m_column = column;
                }

                m_order = order;
                return;
            }

            public DataGridViewColumn GetColumn() { return m_column; }
            public System.ComponentModel.ListSortDirection GetOrder()
            {
                if (m_order == SortOrder.Descending)
                {
                    return System.ComponentModel.ListSortDirection.Descending;
                }
                return System.ComponentModel.ListSortDirection.Ascending;
            }

        }

        // 画面有効時
        private void Display()
        {
            // リストのソート条件を取得
            CD_ListSort listSort = new CD_ListSort(UI_DataGridView.SortedColumn, UI_DataGridView.SortOrder);

            string currentFocusId = "";
            // フォーカスするIDがない場合
            if (currentFocusId == "")
            {
                currentFocusId = UI_DataGridView.CurrentRow?.Cells["id"]?.Value?.ToString() ?? "";
            }

            // リストのクリア
            UI_DataGridView.Rows.Clear();
            // データの取得
            Dictionary<int, Dictionary<string, string>> dataList = TD_ASSET.SelectData(kindsValue);
            Dictionary<int, Dictionary<string, string>> holderList = TD_HOLDER.SelectData();
            if (dataList == null)
            {
                return;
            }
            // リストにデータを出力
            for (int count = 0; count < dataList.Count; count++)
            {
                Dictionary<string, string> data = dataList[count];
                string bookmarkStr = "";
                if (data["bookmark"] == "1")
                {
                    bookmarkStr = "★";
                }

                string holderName = "";
                for (int hCnt = 0; hCnt < holderList.Count; hCnt++)
                {
                    Dictionary<string, string> holder = holderList[hCnt];
                    if (holder["id"] == data["holder_id"])
                    {
                        holderName = holder["name"];
                        break;
                    }
                }

                UI_DataGridView.Rows.Add(Convert.ToInt32(data["id"]), data["name"], holderName, bookmarkStr);
            }

            // ソートを元に戻す
            if (listSort.GetColumn().Name != CD_ListSort.NOT_SORT_COLUMN)
            {
                UI_DataGridView.Sort(listSort.GetColumn(), listSort.GetOrder());
            }

            // 行がない場合
            if (UI_DataGridView.RowCount <= 0)
            {
                return;
            }

            // フォーカス
            for (int count = 0; count < UI_DataGridView.RowCount; count++)
            {
                if (UI_DataGridView?.Rows[count]?.Cells["id"]?.Value?.ToString() == currentFocusId)
                {
                    UI_DataGridView.CurrentCell = UI_DataGridView[0, count];
                    break;
                }
            }

            return;
        }

        private void SelectFirstRow()
        {
            if (UI_DataGridView.Rows.Count > 0)
            {
                UI_DataGridView.Rows[0].Selected = true;
                SelectRow();
            }
            return;
        }


        // 行選択時
        private void SelectRow()
        {
            if (UI_DataGridView?.CurrentRow == null)
            {
                return;
            }
            string assetId = UI_DataGridView?.CurrentRow.Cells["id"].Value?.ToString() ?? "";
            // SELECT
            Dictionary<string, string> assetData = TD_ASSET.SelectDataOne(assetId);

            UI_TextParent.Text = assetData["parent"];
            UI_TextTerms.Text = assetData["terms"];
            UI_TextMemo.Text = assetData["memo"];

            // SELECT: HOLDER
            Dictionary<string, string> holderData = TD_HOLDER.SelectDataOne(assetData["holder_id"]);
            UI_TextCommonTerms.Text = holderData["terms"];

            // 使用中の場合
            if (C_ManageWorkDataFile.CheckUsedAsset(assetId) == true)
            {
                UI_BtnAssetUse.BackColor = Color.FromArgb(192, 255, 192);
            }
            // 未使用の場合
            else
            {
                UI_BtnAssetUse.BackColor = Color.White;
            }


            return;
        }

        private void UI_DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            SelectRow();

            if (kindsValue == 3 || kindsValue == 4 || kindsValue == 5)
            {
                return;
            }

            // マウスの位置にあるセルを取得
            var hitTest = UI_DataGridView.HitTest(e.X, e.Y);

            // 左クリックが行われた場合
            if (e.Button == MouseButtons.Left)
            {
                if (UI_DataGridView.Rows.Count < hitTest.RowIndex || hitTest.RowIndex < 0)
                {
                    return;
                }

                // ファイルを取得してファイルパスにする
                string id = UI_DataGridView.Rows[hitTest.RowIndex]?.Cells["id"]?.Value?.ToString() ?? "";
                if (id == "")
                {
                    return;
                }

                string workAssetIdPath = C_CreatePath.WorkFileAssetIdPath(id);
                if (!Directory.Exists(workAssetIdPath))
                {
                    // フォルダがないためドラッグを行わない
                    return;
                }

                string[] files = System.IO.Directory.GetFiles(workAssetIdPath, "*", System.IO.SearchOption.AllDirectories);
                if (files.Length == 0)
                {
                    // ファイルがないためドラッグを行わない
                    return;
                }

                string filePath = files[0];
                string FullFilePath = Path.GetFullPath(filePath);
                System.Windows.Forms.DataObject data = new System.Windows.Forms.DataObject(DataFormats.FileDrop, new string[] { FullFilePath });

                // ドラッグ操作を開始
                DragDropEffects result = UI_DataGridView.DoDragDrop(data, DragDropEffects.Copy);

                // ドロップ処理成功時
                if (result != DragDropEffects.None)
                {
                    C_ManageWorkDataFile.UsedAsset(id);

                    UI_BtnAssetUse.BackColor = Color.FromArgb(192, 255, 192);
                }

                return;
            }
        }

        private void UI_BtnAssetUse_Click(object sender, EventArgs e)
        {
            string id = UI_DataGridView.CurrentRow?.Cells["id"].Value?.ToString() ?? "";
            if (id == "")
            {
                return;
            }

            // 使用中の場合
            if (C_ManageWorkDataFile.CheckUsedAsset(id) == true)
            {
                C_ManageWorkDataFile.UnUsedAsset(id);

                UI_BtnAssetUse.BackColor = Color.White;
            }
            // 未使用の場合
            else
            {
                C_ManageWorkDataFile.UsedAsset(id);

                UI_BtnAssetUse.BackColor = Color.FromArgb(192, 255, 192);
            }

            return;
        }






    }
}
