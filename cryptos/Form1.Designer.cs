namespace cryptos
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.encrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.decrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.method = new System.Windows.Forms.ToolStripComboBox();
            this.source = new System.Windows.Forms.TextBox();
            this.target = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolstrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstrip
            // 
            this.toolstrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encrypt,
            this.toolStripSeparator1,
            this.decrypt,
            this.toolStripSeparator2,
            this.method});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Size = new System.Drawing.Size(566, 25);
            this.toolstrip.TabIndex = 0;
            this.toolstrip.Text = "toolStrip1";
            // 
            // encrypt
            // 
            this.encrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.encrypt.Image = ((System.Drawing.Image)(resources.GetObject("encrypt.Image")));
            this.encrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(51, 22);
            this.encrypt.Text = "Encrypt";
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // decrypt
            // 
            this.decrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.decrypt.Image = ((System.Drawing.Image)(resources.GetObject("decrypt.Image")));
            this.decrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(52, 22);
            this.decrypt.Text = "Decrypt";
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // method
            // 
            this.method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.method.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.method.Items.AddRange(new object[] {
            "Rijndael (AES)",
            "Binary[nyi]"});
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(121, 25);
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(6, 19);
            this.source.Multiline = true;
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(242, 189);
            this.source.TabIndex = 1;
            // 
            // target
            // 
            this.target.Location = new System.Drawing.Point(15, 19);
            this.target.Multiline = true;
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(242, 189);
            this.target.TabIndex = 2;
            this.target.Click += new System.EventHandler(this.target_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.source);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.target);
            this.groupBox2.Location = new System.Drawing.Point(278, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Einfügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kopieren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Einfügen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Kopieren";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolstrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cryptos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton encrypt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton decrypt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox method;
        private System.Windows.Forms.TextBox source;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

