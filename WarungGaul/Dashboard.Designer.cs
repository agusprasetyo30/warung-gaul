namespace WarungGaul
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.btnPemesanan = new System.Windows.Forms.Button();
            this.btnListItem = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warung Pack Nurhadi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kami tetap melayani pelanggan meskipun permintaan yang aneh-aneh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnListCustomer
            // 
            this.btnListCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnListCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnListCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCustomer.Location = new System.Drawing.Point(20, 19);
            this.btnListCustomer.Name = "btnListCustomer";
            this.btnListCustomer.Size = new System.Drawing.Size(141, 52);
            this.btnListCustomer.TabIndex = 3;
            this.btnListCustomer.Text = "Daftar Customer";
            this.btnListCustomer.UseVisualStyleBackColor = false;
            this.btnListCustomer.Click += new System.EventHandler(this.btnListCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnPenjualan);
            this.groupBox1.Controls.Add(this.btnPemesanan);
            this.groupBox1.Controls.Add(this.btnListItem);
            this.groupBox1.Controls.Add(this.btnListCustomer);
            this.groupBox1.Location = new System.Drawing.Point(214, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPenjualan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPenjualan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPenjualan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenjualan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.Location = new System.Drawing.Point(20, 81);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(296, 52);
            this.btnPenjualan.TabIndex = 6;
            this.btnPenjualan.Text = "Daftar Penjualan";
            this.btnPenjualan.UseVisualStyleBackColor = false;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // btnPemesanan
            // 
            this.btnPemesanan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPemesanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPemesanan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPemesanan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPemesanan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPemesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPemesanan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPemesanan.Location = new System.Drawing.Point(20, 142);
            this.btnPemesanan.Name = "btnPemesanan";
            this.btnPemesanan.Size = new System.Drawing.Size(296, 52);
            this.btnPemesanan.TabIndex = 5;
            this.btnPemesanan.Text = "Pemesanan";
            this.btnPemesanan.UseVisualStyleBackColor = false;
            this.btnPemesanan.Click += new System.EventHandler(this.btnPemesanan_Click);
            // 
            // btnListItem
            // 
            this.btnListItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnListItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnListItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListItem.Location = new System.Drawing.Point(175, 19);
            this.btnListItem.Name = "btnListItem";
            this.btnListItem.Size = new System.Drawing.Size(141, 52);
            this.btnListItem.TabIndex = 4;
            this.btnListItem.Text = "Daftar Makanan \r\ndan Minuman";
            this.btnListItem.UseVisualStyleBackColor = false;
            this.btnListItem.Click += new System.EventHandler(this.btnListItem_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuote.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuote.Location = new System.Drawing.Point(25, 337);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(152, 28);
            this.btnQuote.TabIndex = 7;
            this.btnQuote.Text = "Quote Pack Nurhadi";
            this.btnQuote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuote.UseVisualStyleBackColor = false;
            this.btnQuote.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(570, 374);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnPemesanan;
        private System.Windows.Forms.Button btnListItem;
        private System.Windows.Forms.Button btnQuote;
    }
}

