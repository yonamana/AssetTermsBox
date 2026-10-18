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
            button3 = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(268, 111);
            button3.Name = "button3";
            button3.Size = new Size(98, 56);
            button3.TabIndex = 52;
            button3.Text = "登録";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 37);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(354, 31);
            textBox6.TabIndex = 51;
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
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Name = "FormTagInsert";
            Text = "タグ：登録";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox6;
        private Label label8;
    }
}