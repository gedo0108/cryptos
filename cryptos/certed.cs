using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cryptos
{
    public partial class certed : Form
    {

        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }



        public certed()
        {
            InitializeComponent();
        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            key = txt_key.Text;
            this.Hide();
        }

        private void certed_FormClosing(object sender, FormClosingEventArgs e)

        {


        }
    }
}
