namespace AssetTermsBox
{
    partial class FormUsed
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
            label6 = new Label();
            label1 = new Label();
            UI_TextParent = new TextBox();
            UI_BtnTermsCoppy = new Button();
            UI_BtnParentCoppy = new Button();
            UI_BtnClose = new Button();
            UI_TextTerms = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 42;
            label6.Text = "権利情報";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 352);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 44;
            label1.Text = "親登録ID";
            // 
            // UI_TextParent
            // 
            UI_TextParent.Location = new Point(12, 380);
            UI_TextParent.Name = "UI_TextParent";
            UI_TextParent.ReadOnly = true;
            UI_TextParent.Size = new Size(548, 31);
            UI_TextParent.TabIndex = 45;
            // 
            // UI_BtnTermsCoppy
            // 
            UI_BtnTermsCoppy.Location = new Point(566, 289);
            UI_BtnTermsCoppy.Name = "UI_BtnTermsCoppy";
            UI_BtnTermsCoppy.Size = new Size(98, 60);
            UI_BtnTermsCoppy.TabIndex = 46;
            UI_BtnTermsCoppy.Text = "コピー";
            UI_BtnTermsCoppy.UseVisualStyleBackColor = true;
            UI_BtnTermsCoppy.Click += UI_BtnTermsCoppy_Click;
            // 
            // UI_BtnParentCoppy
            // 
            UI_BtnParentCoppy.Location = new Point(566, 355);
            UI_BtnParentCoppy.Name = "UI_BtnParentCoppy";
            UI_BtnParentCoppy.Size = new Size(98, 56);
            UI_BtnParentCoppy.TabIndex = 47;
            UI_BtnParentCoppy.Text = "コピー";
            UI_BtnParentCoppy.UseVisualStyleBackColor = true;
            UI_BtnParentCoppy.Click += UI_BtnParentCoppy_Click;
            // 
            // UI_BtnClose
            // 
            UI_BtnClose.Location = new Point(566, 442);
            UI_BtnClose.Name = "UI_BtnClose";
            UI_BtnClose.Size = new Size(98, 56);
            UI_BtnClose.TabIndex = 48;
            UI_BtnClose.Text = "閉じる";
            UI_BtnClose.UseVisualStyleBackColor = true;
            UI_BtnClose.Click += UI_BtnClose_Click;
            // 
            // UI_TextTerms
            // 
            UI_TextTerms.AcceptsReturn = true;
            UI_TextTerms.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UI_TextTerms.Location = new Point(12, 37);
            UI_TextTerms.Multiline = true;
            UI_TextTerms.Name = "UI_TextTerms";
            UI_TextTerms.ReadOnly = true;
            UI_TextTerms.ScrollBars = ScrollBars.Both;
            UI_TextTerms.Size = new Size(548, 312);
            UI_TextTerms.TabIndex = 49;
            UI_TextTerms.WordWrap = false;
            // 
            // FormUsed
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 512);
            Controls.Add(UI_TextTerms);
            Controls.Add(UI_BtnClose);
            Controls.Add(UI_BtnParentCoppy);
            Controls.Add(UI_BtnTermsCoppy);
            Controls.Add(UI_TextParent);
            Controls.Add(label1);
            Controls.Add(label6);
            Name = "FormUsed";
            Text = "使用素材";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label6;
        private Label label1;
        private TextBox UI_TextParent;
        private Button UI_BtnTermsCoppy;
        private Button UI_BtnParentCoppy;
        private Button UI_BtnClose;
        private TextBox UI_TextTerms;
    }
}