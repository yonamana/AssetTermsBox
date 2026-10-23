using SqlOperate;
using System.Collections;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Windows;
using System.Windows.Input;
using static System.Net.WebRequestMethods;

namespace AssetTermsBox
{
    public partial class FormMain : Form
    {
        private int kindsValue = 1;

        public FormMain()
        {
            InitializeComponent();

            UI_BtnAssetUse.Enabled = false;
            UI_BtnAssetAlwaysUse.Enabled = false;
            UI_BtnUsed.Enabled = false;

            // ソートの初期値
            DataGridViewColumn column = UI_DataGridView.Columns["id"];
            UI_DataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);

            if (UI_DataGridView.RowCount > 0)
            {
                UI_DataGridView.CurrentCell = UI_DataGridView[0, 0];
            }

            Display(true);
        }

        private void UI_BtnWorkCreate_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartWorkStart(this);
        }
        private void UI_BtnWorkOpen_Click(object sender, EventArgs e)
        {
            string GetFileName = C_Dialog.OpenWorkDataFile();
            if (GetFileName != "")
            {
                C_ManageWorkDataFile.SetWorkDataFilePath(GetFileName);
                C_ManageWorkDataFile.LoadFile();

                SelectRow();
                ReadyOk();
            }
        }

        private void UI_BtnAssetInsert_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartAssetInsert(this);
        }

        private void UI_BtnAssetUpdate_Click(object sender, EventArgs e)
        {
            string assetId = UI_DataGridView.CurrentRow?.Cells["id"]?.Value?.ToString() ?? "";
            if (assetId == "")
            {
                C_MessageBox.Error("素材を選択してください。");
                return;
            }

            C_ManageForm.StartAssetUpdate(this, assetId);
            return;
        }

        private void UI_BtnTagInsert_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartFormTagInsert(this);
        }

        private void UI_BtnTagUpdate_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartFormTagUpdate(this);
        }

        private void UI_BtnUsed_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartFormUsed();
        }

        private void UI_BtnKindsImage_Click(object sender, EventArgs e)
        {
            kindsValue = 1;

            UI_BtnKindsImage.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsSound.BackColor = Color.White;
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsSpeech.BackColor = Color.White;
            UI_BtnKindsOther.BackColor = Color.White;
            Display(false);
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
            Display(false);
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
            Display(false);
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
            Display(false);
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
            Display(false);
            SelectFirstRow();
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

        private Dictionary<int, Dictionary<string, string>> GetDataList()
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "holder_id", "bookmark" };
            string where = "";

            string searchCreator = UI_ComboSearchHolder.Text;
            bool searchFavorite = UI_CheckSearchBookmark.Checked;
            string[] searchTag = new string[UI_CheckedListSearchTag.CheckedItems.Count];
            int cnt = 0;
            foreach (string item in UI_CheckedListSearchTag.CheckedItems)
            {
                searchTag[cnt] = item;
                cnt++;
            }



            // 検索条件（WHERE）
            where += "kinds = " + kindsValue;
            if (searchCreator != "")
            {
                Dictionary<string, string> holderData = TD_HOLDER.SelectDataWhereName(searchCreator);
                if (holderData != null)
                {
                    if (where != "")
                    {
                        where += " AND ";
                    }
                    where += "holder_id = N'" + holderData["id"] + "'";
                }
            }
            if (searchFavorite == true)
            {
                if (where != "")
                {
                    where += " AND ";
                }
                where += "bookmark = 1";
            }
            if (searchTag.Length > 0)
            {
                // SQL: SELECT（タグのid検索）
                string tagSelectWhere = "";
                foreach (string item in searchTag)
                {
                    if (tagSelectWhere != "")
                    {
                        tagSelectWhere += " OR ";
                    }
                    tagSelectWhere += "name = N'" + item + "'";
                }
                string[] tagSelectColumns = { "id" };
                Dictionary<int, Dictionary<string, string>> tagIdResult = sql.Select("TAG", tagSelectColumns, tagSelectWhere);

                string[] tagIdList = new string[tagIdResult.Count];
                for (int count = 0; count < tagIdResult.Count; count++)
                {
                    Dictionary<string, string> tagIdData = tagIdResult[count];
                    tagIdList[count] = tagIdData["id"];
                }

                // tag_idを元にwork_idを取得
                string[] workIdList = TD_ASSET_TAG.SelectAssetIdWhereTagId(tagIdList);

                // WHERE文を作成
                if (workIdList.Count() > 0)
                {
                    string addWhere = "";
                    if (where != "")
                    {
                        where += "AND (";
                    }
                    else
                    {
                        where += "(";
                    }
                    bool flagAddWhere = false;
                    foreach (string item in workIdList)
                    {
                        if (flagAddWhere == true)
                        {
                            addWhere += " OR ";
                        }
                        addWhere += "id = " + item;
                        flagAddWhere = true;
                    }
                    addWhere += ")";
                    where += addWhere;
                }
                else
                {
                    // 他の検索条件が指定されているが、タグが一致するものがすでにない
                    if (where != "")
                    {
                        return null;
                    }
                }
            }

            // タグが指定されているのに検索条件がない
            if (searchTag.Count() > 0 && where == "")
            {
                return null;
            }

            // SELECT
            return sql.Select("ASSET", columns, where);
        }

        // 画面有効時
        public void Display(bool searchUpdate)
        {
            Dictionary<int, Dictionary<string, string>> holderList = TD_HOLDER.SelectData();

            if (searchUpdate == true)
            {
                UI_ComboSearchHolder.Text = "";
                UI_CheckSearchBookmark.Checked = false;
                ////////////////////////////////////////////////////////////
                // 検索条件：権利元名
                ////////////////////////////////////////////////////////////
                UI_ComboSearchHolder.Items.Clear();
                for (int count = 0; count < holderList.Count(); count++)
                {
                    UI_ComboSearchHolder.Items.Add(holderList[count]["name"]);
                }


                ////////////////////////////////////////////////////////////
                /// タグ一覧
                ////////////////////////////////////////////////////////////
                UI_CheckedListSearchTag.Items.Clear();
                Dictionary<int, Dictionary<string, string>> result = TD_TAG.SelectAllData();
                // コンボボックスに値を入れる
                for (int count = 0; count < result.Count; count++)
                {
                    Dictionary<string, string> data = result[count];
                    UI_CheckedListSearchTag.Items.Add(data["name"]);
                }
            }


            ////////////////////////////////////////////////////////////
            /// 素材一覧
            ////////////////////////////////////////////////////////////

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
            Dictionary<int, Dictionary<string, string>> dataList = GetDataList();
            
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
            }
            SelectRow();
            return;
        }


        // 行選択時
        private void SelectRow()
        {
            UI_TextParent.Text = "";
            UI_TextTerms.Text = "";
            UI_TextMemo.Text = "";
            UI_TextCommonTerms.Text = "";
            UI_TextTag.Text = "";

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

            // SELECT: ASSET_TAG
            string[] tagIdList = TD_ASSET_TAG.SelectTagId(assetId);
            if (tagIdList.Count() == 0)
            {
                return;
            }
            string[] tagNameList = TD_TAG.SelectNameList(tagIdList);
            Array.Sort(tagNameList, C_ArraySort.Natural);

            for (int count = 0; count < tagNameList.Count(); count++)
            {
                if (count > 0)
                {
                    UI_TextTag.Text += "、";
                }
                UI_TextTag.Text += tagNameList[count];
            }

            return;
        }

        private void UI_DataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            // マウスの位置にあるセルを取得
            var hitPos = UI_DataGridView.HitTest(e.X, e.Y);
            if (UI_DataGridView.Rows.Count < hitPos.RowIndex || hitPos.RowIndex < 0)
            {
                return;
            }
            ////////////////////////////////////////////////////////////
            // クリック時の処理
            ////////////////////////////////////////////////////////////
            UI_DataGridView.CurrentCell = UI_DataGridView.Rows[hitPos.RowIndex].Cells[0];
            SelectRow();


            ////////////////////////////////////////////////////////////
            // ドラッグ時の処理
            ////////////////////////////////////////////////////////////
            if (UI_BtnAssetUse.Enabled == false)
            {
                return;
            }



            // 左クリックが行われた場合
            if (e.Button == MouseButtons.Left)
            {
                // ファイルを取得してファイルパスにする
                string id = UI_DataGridView.Rows[hitPos.RowIndex]?.Cells["id"]?.Value?.ToString() ?? "";
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

            }

            return;
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


        public void ReadyOk()
        {
            UI_TextWorkFile.Text = C_ManageWorkDataFile.GetWorkDataFilePath();
            if (UI_TextWorkFile.Text == "")
            {
                return;
            }

            UI_BtnAssetUse.Enabled = true;
            UI_BtnAssetAlwaysUse.Enabled = true;
            UI_BtnUsed.Enabled = true;

            return;
        }

        private void UI_ComboSearchHolder_Leave(object sender, EventArgs e)
        {
            Display(false);
            SelectRow();
        }

        private void UI_ComboSearchHolder_Select(object sender, EventArgs e)
        {
            Display(false);
            SelectRow();
        }

        private void UI_CheckedListSearchTag_Leave(object sender, EventArgs e)
        {
            Display(false);
            SelectRow();
        }

        private void UI_CheckSearchBookmark_Checked(object sender, EventArgs e)
        {
            Display(false);
            SelectRow();
        }
    }
}
