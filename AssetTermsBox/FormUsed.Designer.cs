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
            textBox4 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.AcceptsReturn = true;
            textBox4.Location = new Point(12, 37);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ScrollBars = ScrollBars.Both;
            textBox4.Size = new Size(548, 312);
            textBox4.TabIndex = 41;
            textBox4.WordWrap = false;
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
            label1.Text = "権利情報";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 380);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(548, 31);
            textBox1.TabIndex = 45;
            // 
            // button1
            // 
            button1.Location = new Point(566, 289);
            button1.Name = "button1";
            button1.Size = new Size(98, 60);
            button1.TabIndex = 46;
            button1.Text = "コピー";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(566, 355);
            button2.Name = "button2";
            button2.Size = new Size(98, 56);
            button2.TabIndex = 47;
            button2.Text = "コピー";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(566, 442);
            button3.Name = "button3";
            button3.Size = new Size(98, 56);
            button3.TabIndex = 48;
            button3.Text = "閉じる";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormUsed
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 512);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Name = "FormUsed";
            Text = "使用素材";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}