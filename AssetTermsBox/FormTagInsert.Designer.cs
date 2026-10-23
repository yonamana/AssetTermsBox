namespace AssetTermsBox
{
    partial class FormTagInsert
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
            UI_BtnInsert = new Button();
            UI_TextTag = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // UI_BtnInsert
            // 
            UI_BtnInsert.Location = new Point(268, 111);
            UI_BtnInsert.Name = "UI_BtnInsert";
            UI_BtnInsert.Size = new Size(98, 56);
            UI_BtnInsert.TabIndex = 52;
            UI_BtnInsert.Text = "登録";
            UI_BtnInsert.UseVisualStyleBackColor = true;
            UI_BtnInsert.Click += UI_BtnInsert_Click;
            // 
            // UI_TextTag
            // 
            UI_TextTag.Location = new Point(12, 37);
            UI_TextTag.Name = "UI_TextTag";
            UI_TextTag.Size = new Size(354, 31);
            UI_TextTag.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 50;
            label8.Text = "タグ名";
            // 
            // FormTagInsert
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 178);
            Controls.Add(UI_BtnInsert);
            Controls.Add(UI_TextTag);
            Controls.Add(label8);
            Name = "FormTagInsert";
            Text = "タグ：登録";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UI_BtnInsert;
        private TextBox UI_TextTag;
        private Label label8;
    }
}