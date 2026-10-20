namespace AssetTermsBox
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            UI_BtnWorkCreate = new Button();
            UI_DataGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            holderName = new DataGridViewTextBoxColumn();
            bookmark = new DataGridViewTextBoxColumn();
            UI_BtnWorkOpen = new Button();
            UI_BtnWorkDelete = new Button();
            UI_BtnKindsImage = new Button();
            UI_BtnKindsSound = new Button();
            UI_BtnKindsFont = new Button();
            UI_BtnKindsSpeech = new Button();
            UI_BtnKindsOther = new Button();
            UI_BtnUsed = new Button();
            UI_BtnAssetUse = new Button();
            UI_BtnAssetAlwaysUse = new Button();
            UI_BtnTagDelete = new Button();
            UI_BtnTagUpdate = new Button();
            UI_BtnTagInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            button18 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            UI_TextTag = new TextBox();
            UI_TextMemo = new TextBox();
            UI_TextParent = new TextBox();
            label3 = new Label();
            textBox6 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            UI_BtnSearch = new Button();
            UI_BtnReset = new Button();
            UI_TextTerms = new TextBox();
            UI_TextCommonTerms = new TextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            UI_BtnAssetInsert = new Button();
            UI_BtnAssetUpdate = new Button();
            UI_BtnAssetDelete = new Button();
            UI_TextWorkFile = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)UI_DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UI_BtnWorkCreate
            // 
            UI_BtnWorkCreate.Location = new Point(12, 12);
            UI_BtnWorkCreate.Name = "UI_BtnWorkCreate";
            UI_BtnWorkCreate.Size = new Size(98, 65);
            UI_BtnWorkCreate.TabIndex = 0;
            UI_BtnWorkCreate.Text = "新規作成";
            UI_BtnWorkCreate.UseVisualStyleBackColor = true;
            UI_BtnWorkCreate.Click += UI_BtnWorkCreate_Click;
            // 
            // UI_DataGridView
            // 
            UI_DataGridView.AllowUserToAddRows = false;
            UI_DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UI_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UI_DataGridView.Columns.AddRange(new DataGridViewColumn[] { id, name, holderName, bookmark });
            UI_DataGridView.Location = new Point(347, 80);
            UI_DataGridView.MultiSelect = false;
            UI_DataGridView.Name = "UI_DataGridView";
            UI_DataGridView.RowHeadersWidth = 62;
            UI_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UI_DataGridView.Size = new Size(708, 772);
            UI_DataGridView.TabIndex = 1;
            UI_DataGridView.MouseDown += UI_DataGridView_MouseDown;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // name
            // 
            name.HeaderText = "素材";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 400;
            // 
            // holderName
            // 
            holderName.HeaderText = "権利元";
            holderName.MinimumWidth = 8;
            holderName.Name = "holderName";
            holderName.ReadOnly = true;
            holderName.Width = 150;
            // 
            // bookmark
            // 
            bookmark.HeaderText = "★";
            bookmark.MinimumWidth = 8;
            bookmark.Name = "bookmark";
            bookmark.ReadOnly = true;
            bookmark.Width = 50;
            // 
            // UI_BtnWorkOpen
            // 
            UI_BtnWorkOpen.Location = new Point(116, 12);
            UI_BtnWorkOpen.Name = "UI_BtnWorkOpen";
            UI_BtnWorkOpen.Size = new Size(98, 65);
            UI_BtnWorkOpen.TabIndex = 2;
            UI_BtnWorkOpen.Text = "開く";
            UI_BtnWorkOpen.UseVisualStyleBackColor = true;
            UI_BtnWorkOpen.Click += UI_BtnWorkOpen_Click;
            // 
            // UI_BtnWorkDelete
            // 
            UI_BtnWorkDelete.BackColor = Color.FromArgb(255, 192, 192);
            UI_BtnWorkDelete.Location = new Point(220, 12);
            UI_BtnWorkDelete.Name = "UI_BtnWorkDelete";
            UI_BtnWorkDelete.Size = new Size(98, 65);
            UI_BtnWorkDelete.TabIndex = 3;
            UI_BtnWorkDelete.Text = "未実装";
            UI_BtnWorkDelete.UseVisualStyleBackColor = false;
            // 
            // UI_BtnKindsImage
            // 
            UI_BtnKindsImage.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsImage.Location = new Point(347, 12);
            UI_BtnKindsImage.Name = "UI_BtnKindsImage";
            UI_BtnKindsImage.Size = new Size(98, 65);
            UI_BtnKindsImage.TabIndex = 4;
            UI_BtnKindsImage.Text = "画像";
            UI_BtnKindsImage.UseVisualStyleBackColor = false;
            UI_BtnKindsImage.Click += UI_BtnKindsImage_Click;
            // 
            // UI_BtnKindsSound
            // 
            UI_BtnKindsSound.Location = new Point(451, 12);
            UI_BtnKindsSound.Name = "UI_BtnKindsSound";
            UI_BtnKindsSound.Size = new Size(98, 65);
            UI_BtnKindsSound.TabIndex = 5;
            UI_BtnKindsSound.Text = "音声";
            UI_BtnKindsSound.UseVisualStyleBackColor = true;
            UI_BtnKindsSound.Click += UI_BtnKindsSound_Click;
            // 
            // UI_BtnKindsFont
            // 
            UI_BtnKindsFont.Location = new Point(555, 12);
            UI_BtnKindsFont.Name = "UI_BtnKindsFont";
            UI_BtnKindsFont.Size = new Size(98, 65);
            UI_BtnKindsFont.TabIndex = 6;
            UI_BtnKindsFont.Text = "フォント";
            UI_BtnKindsFont.UseVisualStyleBackColor = true;
            UI_BtnKindsFont.Click += UI_BtnKindsFont_Click;
            // 
            // UI_BtnKindsSpeech
            // 
            UI_BtnKindsSpeech.Location = new Point(659, 12);
            UI_BtnKindsSpeech.Name = "UI_BtnKindsSpeech";
            UI_BtnKindsSpeech.Size = new Size(98, 65);
            UI_BtnKindsSpeech.TabIndex = 7;
            UI_BtnKindsSpeech.Text = "合成音声";
            UI_BtnKindsSpeech.UseVisualStyleBackColor = true;
            UI_BtnKindsSpeech.Click += UI_BtnKindsSpeech_Click;
            // 
            // UI_BtnKindsOther
            // 
            UI_BtnKindsOther.Location = new Point(763, 12);
            UI_BtnKindsOther.Name = "UI_BtnKindsOther";
            UI_BtnKindsOther.Size = new Size(98, 65);
            UI_BtnKindsOther.TabIndex = 8;
            UI_BtnKindsOther.Text = "その他";
            UI_BtnKindsOther.UseVisualStyleBackColor = true;
            UI_BtnKindsOther.Click += UI_BtnKindsOther_Click;
            // 
            // UI_BtnUsed
            // 
            UI_BtnUsed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UI_BtnUsed.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnUsed.Location = new Point(12, 858);
            UI_BtnUsed.Name = "UI_BtnUsed";
            UI_BtnUsed.Size = new Size(202, 74);
            UI_BtnUsed.TabIndex = 9;
            UI_BtnUsed.Text = "使用素材";
            UI_BtnUsed.UseVisualStyleBackColor = false;
            UI_BtnUsed.Click += UI_BtnUsed_Click;
            // 
            // UI_BtnAssetUse
            // 
            UI_BtnAssetUse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UI_BtnAssetUse.Location = new Point(347, 863);
            UI_BtnAssetUse.Name = "UI_BtnAssetUse";
            UI_BtnAssetUse.Size = new Size(202, 74);
            UI_BtnAssetUse.TabIndex = 10;
            UI_BtnAssetUse.Text = "選択素材を使用";
            UI_BtnAssetUse.UseVisualStyleBackColor = true;
            UI_BtnAssetUse.Click += UI_BtnAssetUse_Click;
            // 
            // UI_BtnAssetAlwaysUse
            // 
            UI_BtnAssetAlwaysUse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UI_BtnAssetAlwaysUse.BackColor = Color.White;
            UI_BtnAssetAlwaysUse.Location = new Point(555, 863);
            UI_BtnAssetAlwaysUse.Name = "UI_BtnAssetAlwaysUse";
            UI_BtnAssetAlwaysUse.Size = new Size(202, 74);
            UI_BtnAssetAlwaysUse.TabIndex = 11;
            UI_BtnAssetAlwaysUse.Text = "未実装";
            UI_BtnAssetAlwaysUse.UseVisualStyleBackColor = false;
            // 
            // UI_BtnTagDelete
            // 
            UI_BtnTagDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_BtnTagDelete.BackColor = Color.FromArgb(255, 192, 192);
            UI_BtnTagDelete.Location = new Point(1466, 882);
            UI_BtnTagDelete.Name = "UI_BtnTagDelete";
            UI_BtnTagDelete.Size = new Size(100, 50);
            UI_BtnTagDelete.TabIndex = 12;
            UI_BtnTagDelete.Text = "未実装";
            UI_BtnTagDelete.UseVisualStyleBackColor = false;
            // 
            // UI_BtnTagUpdate
            // 
            UI_BtnTagUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_BtnTagUpdate.Location = new Point(1360, 882);
            UI_BtnTagUpdate.Name = "UI_BtnTagUpdate";
            UI_BtnTagUpdate.Size = new Size(100, 50);
            UI_BtnTagUpdate.TabIndex = 13;
            UI_BtnTagUpdate.Text = "未実装";
            UI_BtnTagUpdate.UseVisualStyleBackColor = true;
            // 
            // UI_BtnTagInsert
            // 
            UI_BtnTagInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_BtnTagInsert.Location = new Point(1254, 882);
            UI_BtnTagInsert.Name = "UI_BtnTagInsert";
            UI_BtnTagInsert.Size = new Size(100, 50);
            UI_BtnTagInsert.TabIndex = 14;
            UI_BtnTagInsert.Text = "未実装";
            UI_BtnTagInsert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1208, 895);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 15;
            label1.Text = "タグ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1164, 839);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 19;
            label2.Text = "素材管理";
            // 
            // button18
            // 
            button18.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button18.BackColor = Color.FromArgb(255, 255, 192);
            button18.Location = new Point(957, 863);
            button18.Name = "button18";
            button18.Size = new Size(98, 74);
            button18.TabIndex = 20;
            button18.Text = "未実装";
            button18.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1143, 590);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 22;
            label4.Text = "メモ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1097, 434);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 23;
            label5.Text = "権利情報";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(1061, 272);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 24;
            label6.Text = "共通権利情報";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1097, 238);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 25;
            label7.Text = "親登録ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 157);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 26;
            label8.Text = "権利元";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 250);
            label10.Name = "label10";
            label10.Size = new Size(40, 25);
            label10.TabIndex = 28;
            label10.Text = "タグ";
            // 
            // UI_TextTag
            // 
            UI_TextTag.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_TextTag.Location = new Point(1187, 749);
            UI_TextTag.Name = "UI_TextTag";
            UI_TextTag.ReadOnly = true;
            UI_TextTag.Size = new Size(379, 31);
            UI_TextTag.TabIndex = 29;
            // 
            // UI_TextMemo
            // 
            UI_TextMemo.AcceptsReturn = true;
            UI_TextMemo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_TextMemo.Location = new Point(1187, 590);
            UI_TextMemo.Multiline = true;
            UI_TextMemo.Name = "UI_TextMemo";
            UI_TextMemo.ReadOnly = true;
            UI_TextMemo.ScrollBars = ScrollBars.Both;
            UI_TextMemo.Size = new Size(379, 153);
            UI_TextMemo.TabIndex = 30;
            UI_TextMemo.WordWrap = false;
            // 
            // UI_TextParent
            // 
            UI_TextParent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_TextParent.Location = new Point(1187, 235);
            UI_TextParent.Name = "UI_TextParent";
            UI_TextParent.ReadOnly = true;
            UI_TextParent.Size = new Size(379, 31);
            UI_TextParent.TabIndex = 33;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1141, 752);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 34;
            label3.Text = "タグ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 185);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(306, 31);
            textBox6.TabIndex = 35;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 278);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(306, 200);
            checkedListBox1.TabIndex = 36;
            // 
            // UI_BtnSearch
            // 
            UI_BtnSearch.Location = new Point(12, 484);
            UI_BtnSearch.Name = "UI_BtnSearch";
            UI_BtnSearch.Size = new Size(98, 50);
            UI_BtnSearch.TabIndex = 37;
            UI_BtnSearch.Text = "未実装";
            UI_BtnSearch.UseVisualStyleBackColor = true;
            // 
            // UI_BtnReset
            // 
            UI_BtnReset.Location = new Point(116, 484);
            UI_BtnReset.Name = "UI_BtnReset";
            UI_BtnReset.Size = new Size(98, 50);
            UI_BtnReset.TabIndex = 38;
            UI_BtnReset.Text = "未実装";
            UI_BtnReset.UseVisualStyleBackColor = true;
            // 
            // UI_TextTerms
            // 
            UI_TextTerms.AcceptsReturn = true;
            UI_TextTerms.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_TextTerms.Location = new Point(1187, 431);
            UI_TextTerms.Multiline = true;
            UI_TextTerms.Name = "UI_TextTerms";
            UI_TextTerms.ReadOnly = true;
            UI_TextTerms.ScrollBars = ScrollBars.Both;
            UI_TextTerms.Size = new Size(379, 153);
            UI_TextTerms.TabIndex = 39;
            UI_TextTerms.WordWrap = false;
            // 
            // UI_TextCommonTerms
            // 
            UI_TextCommonTerms.AcceptsReturn = true;
            UI_TextCommonTerms.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_TextCommonTerms.Location = new Point(1187, 272);
            UI_TextCommonTerms.Multiline = true;
            UI_TextCommonTerms.Name = "UI_TextCommonTerms";
            UI_TextCommonTerms.ReadOnly = true;
            UI_TextCommonTerms.ScrollBars = ScrollBars.Both;
            UI_TextCommonTerms.Size = new Size(379, 153);
            UI_TextCommonTerms.TabIndex = 40;
            UI_TextCommonTerms.WordWrap = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(1097, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 217);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(12, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 29);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "ブックマーク";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // UI_BtnAssetInsert
            // 
            UI_BtnAssetInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_BtnAssetInsert.Location = new Point(1254, 826);
            UI_BtnAssetInsert.Name = "UI_BtnAssetInsert";
            UI_BtnAssetInsert.Size = new Size(100, 50);
            UI_BtnAssetInsert.TabIndex = 45;
            UI_BtnAssetInsert.Text = "登録";
            UI_BtnAssetInsert.UseVisualStyleBackColor = true;
            UI_BtnAssetInsert.Click += UI_BtnAssetInsert_Click;
            // 
            // UI_BtnAssetUpdate
            // 
            UI_BtnAssetUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_BtnAssetUpdate.Location = new Point(1360, 826);
            UI_BtnAssetUpdate.Name = "UI_BtnAssetUpdate";
            UI_BtnAssetUpdate.Size = new Size(100, 50);
            UI_BtnAssetUpdate.TabIndex = 44;
            UI_BtnAssetUpdate.Text = "未実装";
            UI_BtnAssetUpdate.UseVisualStyleBackColor = true;
            // 
            // UI_BtnAssetDelete
            // 
            UI_BtnAssetDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_BtnAssetDelete.BackColor = Color.FromArgb(255, 192, 192);
            UI_BtnAssetDelete.Location = new Point(1466, 826);
            UI_BtnAssetDelete.Name = "UI_BtnAssetDelete";
            UI_BtnAssetDelete.Size = new Size(100, 50);
            UI_BtnAssetDelete.TabIndex = 43;
            UI_BtnAssetDelete.Text = "未実装";
            UI_BtnAssetDelete.UseVisualStyleBackColor = false;
            // 
            // UI_TextWorkFile
            // 
            UI_TextWorkFile.Location = new Point(12, 83);
            UI_TextWorkFile.Name = "UI_TextWorkFile";
            UI_TextWorkFile.ReadOnly = true;
            UI_TextWorkFile.Size = new Size(306, 31);
            UI_TextWorkFile.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 827);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 47;
            label9.Text = "Ver.0.1.1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1578, 944);
            Controls.Add(label9);
            Controls.Add(UI_TextWorkFile);
            Controls.Add(UI_BtnAssetInsert);
            Controls.Add(UI_BtnAssetUpdate);
            Controls.Add(UI_BtnAssetDelete);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(UI_TextCommonTerms);
            Controls.Add(UI_TextTerms);
            Controls.Add(UI_BtnReset);
            Controls.Add(UI_BtnSearch);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox6);
            Controls.Add(label3);
            Controls.Add(UI_TextParent);
            Controls.Add(UI_TextMemo);
            Controls.Add(UI_TextTag);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button18);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UI_BtnTagInsert);
            Controls.Add(UI_BtnTagUpdate);
            Controls.Add(UI_BtnTagDelete);
            Controls.Add(UI_BtnAssetAlwaysUse);
            Controls.Add(UI_BtnAssetUse);
            Controls.Add(UI_BtnUsed);
            Controls.Add(UI_BtnKindsOther);
            Controls.Add(UI_BtnKindsSpeech);
            Controls.Add(UI_BtnKindsFont);
            Controls.Add(UI_BtnKindsSound);
            Controls.Add(UI_BtnKindsImage);
            Controls.Add(UI_BtnWorkDelete);
            Controls.Add(UI_BtnWorkOpen);
            Controls.Add(UI_DataGridView);
            Controls.Add(UI_BtnWorkCreate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1600, 1000);
            Name = "FormMain";
            Text = "素材規約箱";
            Activated += FormMain_Actibated;
            ((System.ComponentModel.ISupportInitialize)UI_DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UI_BtnWorkCreate;
        private DataGridView UI_DataGridView;
        private Button UI_BtnWorkOpen;
        private Button UI_BtnWorkDelete;
        private Button UI_BtnKindsImage;
        private Button UI_BtnKindsSound;
        private Button UI_BtnKindsFont;
        private Button UI_BtnKindsSpeech;
        private Button UI_BtnKindsOther;
        private Button UI_BtnUsed;
        private Button UI_BtnAssetUse;
        private Button UI_BtnAssetAlwaysUse;
        private Button UI_BtnTagDelete;
        private Button UI_BtnTagUpdate;
        private Button UI_BtnTagInsert;
        private Label label1;
        private Label label2;
        private Button button18;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox UI_TextTag;
        private TextBox UI_TextMemo;
        private TextBox UI_TextParent;
        private Label label3;
        private TextBox textBox6;
        private CheckedListBox checkedListBox1;
        private Button UI_BtnSearch;
        private Button UI_BtnReset;
        private TextBox UI_TextTerms;
        private TextBox UI_TextCommonTerms;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Button UI_BtnAssetInsert;
        private Button UI_BtnAssetUpdate;
        private Button UI_BtnAssetDelete;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn holderName;
        private DataGridViewTextBoxColumn bookmark;
        private TextBox UI_TextWorkFile;
        private Label label9;
    }
}
