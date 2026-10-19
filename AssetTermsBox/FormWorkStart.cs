using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssetTermsBox
{
    public partial class FormWorkStart : Form
    {
        public FormWorkStart()
        {
            InitializeComponent();
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
