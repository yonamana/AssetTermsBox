namespace AssetTermsBox
{
    partial class FormTagUpdate
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
            UI_TextTag = new TextBox();
            label8 = new Label();
            label1 = new Label();
            UI_ComboTag = new ComboBox();
            UI_BtnUpdate = new Button();
            SuspendLayout();
            // 
            // UI_TextTag
            // 
            UI_TextTag.BackColor = Color.FromArgb(255, 224, 192);
            UI_TextTag.Location = new Point(112, 94);
            UI_TextTag.MaxLength = 40;
            UI_TextTag.Name = "UI_TextTag";
            UI_TextTag.Size = new Size(390, 31);
            UI_TextTag.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 97);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 52;
            label8.Text = "新規タグ名";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 54;
            label1.Text = "変更タグ";
            // 
            // UI_ComboTag
            // 
            UI_ComboTag.BackColor = Color.FromArgb(255, 224, 192);
            UI_ComboTag.DropDownStyle = ComboBoxStyle.DropDownList;
            UI_ComboTag.FormattingEnabled = true;
            UI_ComboTag.Location = new Point(112, 12);
            UI_ComboTag.Name = "UI_ComboTag";
            UI_ComboTag.Size = new Size(390, 33);
            UI_ComboTag.TabIndex = 55;
            // 
            // UI_BtnUpdate
            // 
            UI_BtnUpdate.Location = new Point(452, 163);
            UI_BtnUpdate.Name = "UI_BtnUpdate";
            UI_BtnUpdate.Size = new Size(98, 56);
            UI_BtnUpdate.TabIndex = 56;
            UI_BtnUpdate.Text = "更新";
            UI_BtnUpdate.UseVisualStyleBackColor = true;
            UI_BtnUpdate.Click += UI_BtnUpdate_Click;
            // 
            // FormTagUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 228);
            Controls.Add(UI_BtnUpdate);
            Controls.Add(UI_ComboTag);
            Controls.Add(label1);
            Controls.Add(UI_TextTag);
            Controls.Add(label8);
            Name = "FormTagUpdate";
            Text = "タグ：更新";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UI_TextTag;
        private Label label8;
        private Label label1;
        private ComboBox UI_ComboTag;
        private Button UI_BtnUpdate;
    }
}