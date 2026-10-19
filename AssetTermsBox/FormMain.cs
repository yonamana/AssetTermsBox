
using System.Collections;

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
        }

        private void UI_DataGridView_Click(object sender, EventArgs e)
        {
            SelectRow();
        }


        private void FormMain_Actibated(object sender, EventArgs e)
        {
            Display();
            SelectRow();
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

            return;
        }








        // ドラッグ時


    }
}
