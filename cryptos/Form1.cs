using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AutoUpdaterDotNET;

namespace cryptos
{
    public partial class Form1 : Form
    {

        public string cert;

        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            switch (method.SelectedIndex)
            {
                case 0:
                    encrypt_rij();
                    break;
                case 1:
                    MessageBox.Show("feature not yet implemented!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    encrypt_rij();
                    break;

            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            switch (method.SelectedIndex)
            {
                case 0:
                    decrypt_rij();
                    break;
                case 1:
                    MessageBox.Show("feature not yet implemented!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    decrypt_rij();
                    break;

            }
        }

        private void encrypt_rij()
        {
            try
            {
                target.Text = rijndael.Encryption.EncryptString(source.Text, cert);
            }
            catch
            {
                MessageBox.Show("Source or certificate seems not to be valid!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void decrypt_rij()
        {
            try
            {
                target.Text = rijndael.Encryption.DecryptString(source.Text, cert);
            }
            catch
            {
                MessageBox.Show("Source or certificate seems not to be valid!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Updater (hier XML einfügen von meinem server)
            AutoUpdater.Start("http://rbsoft.org/updates/AutoUpdaterTest.xml");

            method.SelectedIndex = 0;
            if (System.IO.File.Exists("cert.key"))
            {
                StreamReader reader = new StreamReader("cert.key");
                cert = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }
            else
            {
                MessageBox.Show("No valid certificate found!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    certed c = new certed();
                    c.ShowDialog();
                    cert = c.Key;
                    c.Close();
                    c.Dispose();
                }

                //while (!(File.Exists("cert.key")))
                //{
                //    File.Create("cert.key");
                //}

                StreamWriter w = new StreamWriter("cert.key");
                w.Write(cert);
                w.Close();
            }

        private void target_Click(object sender, EventArgs e)
        {
            target.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // test!
            string einf = Clipboard.GetText();
            source.Text = einf;

            switch (method.SelectedIndex)
            {
                case 0:
                    decrypt_rij();
                    break;
                case 1:
                    MessageBox.Show("feature not yet implemented!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    decrypt_rij();
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            source.SelectAll();
            source.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string einf2 = Clipboard.GetText();
            target.Text = einf2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            target.SelectAll();
            target.Copy();
        }
    }




    }

