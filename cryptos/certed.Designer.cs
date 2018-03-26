namespace cryptos
{
    partial class certed
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
            this.desc = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.SystemColors.Control;
            this.desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desc.Enabled = false;
            this.desc.Location = new System.Drawing.Point(12, 12);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(294, 19);
            this.desc.TabIndex = 0;
            this.desc.Text = "Please enter your personal security key, to share it with others.";
            this.desc.TextChanged += new System.EventHandler(this.desc_TextChanged);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(17, 37);
            this.txt_key.Multiline = true;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(284, 118);
            this.txt_key.TabIndex = 1;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(226, 161);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 2;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(17, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Randomize";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // certed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 199);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.create);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "certed";
            this.Text = "Certificate Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.certed_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button button2;
    }
}