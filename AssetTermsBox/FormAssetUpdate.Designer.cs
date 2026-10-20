namespace AssetTermsBox
{
    partial class FormAssetUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UI_CheckBookmark = new CheckBox();
            UI_ComboHolderName = new ComboBox();
            label2 = new Label();
            UI_TextParent = new TextBox();
            UI_BtnUpdate = new Button();
            button2 = new Button();
            UI_CheckedListTag = new CheckedListBox();
            label10 = new Label();
            UI_TextCommonTerms = new TextBox();
            UI_TextTerms = new TextBox();
            UI_TextMemo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            UI_TextAssetName = new TextBox();
            UI_BtnKindsOther = new Button();
            UI_BtnKindsSpeech = new Button();
            UI_BtnKindsFont = new Button();
            UI_BtnKindsSound = new Button();
            UI_BtnKindsImage = new Button();
            SuspendLayout();
            // 
            // UI_CheckBookmark
            // 
            UI_CheckBookmark.AutoSize = true;
            UI_CheckBookmark.CheckAlign = ContentAlignment.MiddleRight;
            UI_CheckBookmark.Location = new Point(695, 619);
            UI_CheckBookmark.Name = "UI_CheckBookmark";
            UI_CheckBookmark.Size = new Size(115, 29);
            UI_CheckBookmark.TabIndex = 78;
            UI_CheckBookmark.Text = "ブックマーク";
            UI_CheckBookmark.UseVisualStyleBackColor = true;
            // 
            // UI_ComboHolderName
            // 
            UI_ComboHolderName.FormattingEnabled = true;
            UI_ComboHolderName.Location = new Point(131, 206);
            UI_ComboHolderName.Name = "UI_ComboHolderName";
            UI_ComboHolderName.Size = new Size(535, 33);
            UI_ComboHolderName.TabIndex = 77;
            UI_ComboHolderName.Leave += UI_ComboHolderName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 569);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 76;
            label2.Text = "親登録ID";
            // 
            // UI_TextParent
            // 
            UI_TextParent.Location = new Point(131, 563);
            UI_TextParent.Name = "UI_TextParent";
            UI_TextParent.Size = new Size(535, 31);
            UI_TextParent.TabIndex = 75;
            // 
            // UI_BtnUpdate
            // 
            UI_BtnUpdate.Location = new Point(1004, 664);
            UI_BtnUpdate.Name = "UI_BtnUpdate";
            UI_BtnUpdate.Size = new Size(161, 89);
            UI_BtnUpdate.TabIndex = 74;
            UI_BtnUpdate.Text = "更新";
            UI_BtnUpdate.UseVisualStyleBackColor = true;
            UI_BtnUpdate.Click += UI_BtnUpdate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1007, 536);
            button2.Name = "button2";
            button2.Size = new Size(98, 65);
            button2.TabIndex = 73;
            button2.Text = "未実装";
            button2.UseVisualStyleBackColor = true;
            // 
            // UI_CheckedListTag
            // 
            UI_CheckedListTag.FormattingEnabled = true;
            UI_CheckedListTag.Location = new Point(695, 149);
            UI_CheckedListTag.Name = "UI_CheckedListTag";
            UI_CheckedListTag.Size = new Size(306, 452);
            UI_CheckedListTag.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(695, 121);
            label10.Name = "label10";
            label10.Size = new Size(40, 25);
            label10.TabIndex = 71;
            label10.Text = "タグ";
            // 
            // UI_TextCommonTerms
            // 
            UI_TextCommonTerms.AcceptsReturn = true;
            UI_TextCommonTerms.Location = new Point(131, 245);
            UI_TextCommonTerms.Multiline = true;
            UI_TextCommonTerms.Name = "UI_TextCommonTerms";
            UI_TextCommonTerms.ScrollBars = ScrollBars.Both;
            UI_TextCommonTerms.Size = new Size(535, 153);
            UI_TextCommonTerms.TabIndex = 70;
            UI_TextCommonTerms.WordWrap = false;
            // 
            // UI_TextTerms
            // 
            UI_TextTerms.AcceptsReturn = true;
            UI_TextTerms.Location = new Point(131, 404);
            UI_TextTerms.Multiline = true;
            UI_TextTerms.Name = "UI_TextTerms";
            UI_TextTerms.ScrollBars = ScrollBars.Both;
            UI_TextTerms.Size = new Size(535, 153);
            UI_TextTerms.TabIndex = 69;
            UI_TextTerms.WordWrap = false;
            // 
            // UI_TextMemo
            // 
            UI_TextMemo.AcceptsReturn = true;
            UI_TextMemo.Location = new Point(131, 600);
            UI_TextMemo.Multiline = true;
            UI_TextMemo.Name = "UI_TextMemo";
            UI_TextMemo.ScrollBars = ScrollBars.Both;
            UI_TextMemo.Size = new Size(535, 153);
            UI_TextMemo.TabIndex = 68;
            UI_TextMemo.WordWrap = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 245);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 67;
            label6.Text = "共通権利情報";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 407);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 66;
            label5.Text = "権利情報";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 600);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 65;
            label4.Text = "メモ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 211);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 64;
            label1.Text = "権利元名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 177);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 63;
            label3.Text = "素材名";
            // 
            // UI_TextAssetName
            // 
            UI_TextAssetName.Location = new Point(131, 171);
            UI_TextAssetName.Name = "UI_TextAssetName";
            UI_TextAssetName.Size = new Size(535, 31);
            UI_TextAssetName.TabIndex = 62;
            // 
            // UI_BtnKindsOther
            // 
            UI_BtnKindsOther.Location = new Point(428, 12);
            UI_BtnKindsOther.Name = "UI_BtnKindsOther";
            UI_BtnKindsOther.Size = new Size(98, 65);
            UI_BtnKindsOther.TabIndex = 59;
            UI_BtnKindsOther.Text = "その他";
            UI_BtnKindsOther.UseVisualStyleBackColor = true;
            UI_BtnKindsOther.Click += UI_BtnKindsOther_Click;
            // 
            // UI_BtnKindsSpeech
            // 
            UI_BtnKindsSpeech.Location = new Point(324, 12);
            UI_BtnKindsSpeech.Name = "UI_BtnKindsSpeech";
            UI_BtnKindsSpeech.Size = new Size(98, 65);
            UI_BtnKindsSpeech.TabIndex = 58;
            UI_BtnKindsSpeech.Text = "合成音声";
            UI_BtnKindsSpeech.UseVisualStyleBackColor = true;
            UI_BtnKindsSpeech.Click += UI_BtnKindsSpeech_Click;
            // 
            // UI_BtnKindsFont
            // 
            UI_BtnKindsFont.BackColor = Color.White;
            UI_BtnKindsFont.Location = new Point(220, 12);
            UI_BtnKindsFont.Name = "UI_BtnKindsFont";
            UI_BtnKindsFont.Size = new Size(98, 65);
            UI_BtnKindsFont.TabIndex = 57;
            UI_BtnKindsFont.Text = "フォント";
            UI_BtnKindsFont.UseVisualStyleBackColor = false;
            UI_BtnKindsFont.Click += UI_BtnKindsFont_Click;
            // 
            // UI_BtnKindsSound
            // 
            UI_BtnKindsSound.Location = new Point(116, 12);
            UI_BtnKindsSound.Name = "UI_BtnKindsSound";
            UI_BtnKindsSound.Size = new Size(98, 65);
            UI_BtnKindsSound.TabIndex = 56;
            UI_BtnKindsSound.Text = "音声";
            UI_BtnKindsSound.UseVisualStyleBackColor = true;
            UI_BtnKindsSound.Click += UI_BtnKindsSound_Click;
            // 
            // UI_BtnKindsImage
            // 
            UI_BtnKindsImage.BackColor = Color.FromArgb(192, 192, 255);
            UI_BtnKindsImage.Location = new Point(12, 12);
            UI_BtnKindsImage.Name = "UI_BtnKindsImage";
            UI_BtnKindsImage.Size = new Size(98, 65);
            UI_BtnKindsImage.TabIndex = 55;
            UI_BtnKindsImage.Text = "画像";
            UI_BtnKindsImage.UseVisualStyleBackColor = false;
            UI_BtnKindsImage.Click += UI_BtnKindsImage_Click;
            // 
            // FormAssetUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 768);
            Controls.Add(UI_CheckBookmark);
            Controls.Add(UI_ComboHolderName);
            Controls.Add(label2);
            Controls.Add(UI_TextParent);
            Controls.Add(UI_BtnUpdate);
            Controls.Add(button2);
            Controls.Add(UI_CheckedListTag);
            Controls.Add(label10);
            Controls.Add(UI_TextCommonTerms);
            Controls.Add(UI_TextTerms);
            Controls.Add(UI_TextMemo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(UI_TextAssetName);
            Controls.Add(UI_BtnKindsOther);
            Controls.Add(UI_BtnKindsSpeech);
            Controls.Add(UI_BtnKindsFont);
            Controls.Add(UI_BtnKindsSound);
            Controls.Add(UI_BtnKindsImage);
            Name = "FormAssetUpdate";
            Text = "素材：更新";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox UI_CheckBookmark;
        private ComboBox UI_ComboHolderName;
        private Label label2;
        private TextBox UI_TextParent;
        private Button UI_BtnUpdate;
        private Button button2;
        private CheckedListBox UI_CheckedListTag;
        private Label label10;
        private TextBox UI_TextCommonTerms;
        private TextBox UI_TextTerms;
        private TextBox UI_TextMemo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label3;
        private TextBox UI_TextAssetName;
        private Button UI_BtnKindsOther;
        private Button UI_BtnKindsSpeech;
        private Button UI_BtnKindsFont;
        private Button UI_BtnKindsSound;
        private Button UI_BtnKindsImage;
    }
}