namespace AssetTermsBox
{
    partial class FormTagDelete
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(390, 33);
            comboBox1.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 56;
            label1.Text = "削除するタグ";
            // 
            // button3
            // 
            button3.Location = new Point(415, 107);
            button3.Name = "button3";
            button3.Size = new Size(98, 56);
            button3.TabIndex = 58;
            button3.Text = "削除";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormTagDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 179);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "FormTagDelete";
            Text = "FormTagDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button3;
    }
}