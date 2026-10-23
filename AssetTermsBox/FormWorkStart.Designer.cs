namespace AssetTermsBox
{
    partial class FormWorkStart
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
            UI_TextNewName = new TextBox();
            label8 = new Label();
            UI_BtnCreate = new Button();
            SuspendLayout();
            // 
            // UI_TextNewName
            // 
            UI_TextNewName.BackColor = Color.FromArgb(255, 224, 192);
            UI_TextNewName.Location = new Point(12, 37);
            UI_TextNewName.MaxLength = 50;
            UI_TextNewName.Name = "UI_TextNewName";
            UI_TextNewName.Size = new Size(354, 31);
            UI_TextNewName.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(84, 25);
            label8.TabIndex = 36;
            label8.Text = "新作業名";
            // 
            // UI_BtnCreate
            // 
            UI_BtnCreate.Location = new Point(268, 111);
            UI_BtnCreate.Name = "UI_BtnCreate";
            UI_BtnCreate.Size = new Size(98, 56);
            UI_BtnCreate.TabIndex = 49;
            UI_BtnCreate.Text = "作成";
            UI_BtnCreate.UseVisualStyleBackColor = true;
            UI_BtnCreate.Click += UI_BtnCreate_Click;
            // 
            // FormWorkStart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 179);
            Controls.Add(UI_BtnCreate);
            Controls.Add(UI_TextNewName);
            Controls.Add(label8);
            Name = "FormWorkStart";
            Text = "作業：新規作成";
            FormClosed += FormClose;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UI_TextNewName;
        private Label label8;
        private Button UI_BtnCreate;
    }
}