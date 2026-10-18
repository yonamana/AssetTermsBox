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
            textBox6 = new TextBox();
            label8 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(112, 94);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(390, 31);
            textBox6.TabIndex = 53;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(390, 33);
            comboBox1.TabIndex = 55;
            // 
            // button3
            // 
            button3.Location = new Point(452, 163);
            button3.Name = "button3";
            button3.Size = new Size(98, 56);
            button3.TabIndex = 56;
            button3.Text = "更新";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormTagUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 228);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Name = "FormTagUpdate";
            Text = "タグ：更新";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Label label8;
        private Label label1;
        private ComboBox comboBox1;
        private Button button3;
    }
}