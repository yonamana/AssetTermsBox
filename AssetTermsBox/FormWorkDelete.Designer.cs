namespace AssetTermsBox
{
    partial class FormWorkDelete
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
            checkedListBox1 = new CheckedListBox();
            label10 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 37);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(306, 312);
            checkedListBox1.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 37;
            label10.Text = "作業一覧";
            // 
            // button3
            // 
            button3.Location = new Point(363, 372);
            button3.Name = "button3";
            button3.Size = new Size(98, 56);
            button3.TabIndex = 50;
            button3.Text = "削除";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormWorkDelete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 440);
            Controls.Add(button3);
            Controls.Add(checkedListBox1);
            Controls.Add(label10);
            Name = "FormWorkDelete";
            Text = "作業：削除";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label10;
        private Button button3;
    }
}