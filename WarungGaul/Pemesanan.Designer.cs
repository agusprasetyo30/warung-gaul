namespace WarungGaul
{
    partial class Pemesanan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pemesanan));
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_warungDataSet = new WarungGaul.db_warungDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTransaction = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesan = new System.Windows.Forms.Button();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTambahMakanan = new System.Windows.Forms.Button();
            this.txtJumlahBeliMakanan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHargaMakanan = new System.Windows.Forms.TextBox();
            this.comboMakanan = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJumlahBeliMinuman = new System.Windows.Forms.TextBox();
            this.btnTambahMinuman = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHargaMinuman = new System.Windows.Forms.TextBox();
            this.comboMinuman = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WarungGaul.db_warungDataSetTableAdapters.customerTableAdapter();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdSales = new System.Windows.Forms.TextBox();
            this.btnFinished = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_warungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaction)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCustomer
            // 
            this.comboCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboCustomer.Location = new System.Drawing.Point(13, 55);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(287, 28);
            this.comboCustomer.TabIndex = 6;
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "customer";
            this.customerBindingSource2.DataSource = this.db_warungDataSet;
            // 
            // db_warungDataSet
            // 
            this.db_warungDataSet.DataSetName = "db_warungDataSet";
            this.db_warungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pemesanan";
            // 
            // tblTransaction
            // 
            this.tblTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTransaction.Location = new System.Drawing.Point(23, 283);
            this.tblTransaction.Name = "tblTransaction";
            this.tblTransaction.ReadOnly = true;
            this.tblTransaction.RowHeadersVisible = false;
            this.tblTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTransaction.Size = new System.Drawing.Size(319, 166);
            this.tblTransaction.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesan);
            this.groupBox1.Controls.Add(this.comboCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pelanggan";
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPesan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesan.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.ForeColor = System.Drawing.Color.White;
            this.btnPesan.Location = new System.Drawing.Point(91, 89);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(137, 33);
            this.btnPesan.TabIndex = 26;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnTambahMakanan);
            this.groupBox2.Controls.Add(this.txtJumlahBeliMakanan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtHargaMakanan);
            this.groupBox2.Controls.Add(this.comboMakanan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(348, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 195);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Makanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(158, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Jumlah Beli";
            // 
            // btnTambahMakanan
            // 
            this.btnTambahMakanan.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTambahMakanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahMakanan.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahMakanan.ForeColor = System.Drawing.Color.White;
            this.btnTambahMakanan.Location = new System.Drawing.Point(20, 143);
            this.btnTambahMakanan.Name = "btnTambahMakanan";
            this.btnTambahMakanan.Size = new System.Drawing.Size(269, 38);
            this.btnTambahMakanan.TabIndex = 23;
            this.btnTambahMakanan.Text = "Tambah";
            this.btnTambahMakanan.UseVisualStyleBackColor = false;
            this.btnTambahMakanan.Click += new System.EventHandler(this.btnTambahMakanan_Click);
            // 
            // txtJumlahBeliMakanan
            // 
            this.txtJumlahBeliMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJumlahBeliMakanan.Location = new System.Drawing.Point(161, 106);
            this.txtJumlahBeliMakanan.Name = "txtJumlahBeliMakanan";
            this.txtJumlahBeliMakanan.Size = new System.Drawing.Size(128, 26);
            this.txtJumlahBeliMakanan.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Harga";
            // 
            // txtHargaMakanan
            // 
            this.txtHargaMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHargaMakanan.Location = new System.Drawing.Point(21, 106);
            this.txtHargaMakanan.Name = "txtHargaMakanan";
            this.txtHargaMakanan.ReadOnly = true;
            this.txtHargaMakanan.Size = new System.Drawing.Size(126, 26);
            this.txtHargaMakanan.TabIndex = 19;
            // 
            // comboMakanan
            // 
            this.comboMakanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMakanan.DataSource = this.itemBindingSource;
            this.comboMakanan.DisplayMember = "name";
            this.comboMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMakanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboMakanan.Location = new System.Drawing.Point(21, 48);
            this.comboMakanan.Name = "comboMakanan";
            this.comboMakanan.Size = new System.Drawing.Size(268, 28);
            this.comboMakanan.TabIndex = 6;
            this.comboMakanan.ValueMember = "id";
            this.comboMakanan.SelectedIndexChanged += new System.EventHandler(this.comboItem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtJumlahBeliMinuman);
            this.groupBox3.Controls.Add(this.btnTambahMinuman);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtHargaMinuman);
            this.groupBox3.Controls.Add(this.comboMinuman);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(349, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 190);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minuman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Jumlah Beli";
            // 
            // txtJumlahBeliMinuman
            // 
            this.txtJumlahBeliMinuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJumlahBeliMinuman.Location = new System.Drawing.Point(157, 102);
            this.txtJumlahBeliMinuman.Name = "txtJumlahBeliMinuman";
            this.txtJumlahBeliMinuman.Size = new System.Drawing.Size(129, 26);
            this.txtJumlahBeliMinuman.TabIndex = 26;
            // 
            // btnTambahMinuman
            // 
            this.btnTambahMinuman.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTambahMinuman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahMinuman.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahMinuman.ForeColor = System.Drawing.Color.White;
            this.btnTambahMinuman.Location = new System.Drawing.Point(21, 138);
            this.btnTambahMinuman.Name = "btnTambahMinuman";
            this.btnTambahMinuman.Size = new System.Drawing.Size(265, 38);
            this.btnTambahMinuman.TabIndex = 24;
            this.btnTambahMinuman.Text = "Tambah";
            this.btnTambahMinuman.UseVisualStyleBackColor = false;
            this.btnTambahMinuman.Click += new System.EventHandler(this.btnTambahMinuman_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Harga";
            // 
            // txtHargaMinuman
            // 
            this.txtHargaMinuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHargaMinuman.Location = new System.Drawing.Point(20, 102);
            this.txtHargaMinuman.Name = "txtHargaMinuman";
            this.txtHargaMinuman.ReadOnly = true;
            this.txtHargaMinuman.Size = new System.Drawing.Size(121, 26);
            this.txtHargaMinuman.TabIndex = 19;
            // 
            // comboMinuman
            // 
            this.comboMinuman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMinuman.DataSource = this.itemBindingSource;
            this.comboMinuman.DisplayMember = "name";
            this.comboMinuman.Enabled = false;
            this.comboMinuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMinuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboMinuman.Location = new System.Drawing.Point(21, 48);
            this.comboMinuman.Name = "comboMinuman";
            this.comboMinuman.Size = new System.Drawing.Size(265, 28);
            this.comboMinuman.TabIndex = 6;
            this.comboMinuman.ValueMember = "id";
            this.comboMinuman.SelectedIndexChanged += new System.EventHandler(this.comboMinuman_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nama";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(23, 455);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(153, 56);
            this.btnDeleteAll.TabIndex = 26;
            this.btnDeleteAll.Text = "Hapus Semua";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Orange;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(566, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 46);
            this.button7.TabIndex = 27;
            this.button7.Text = "Kembali";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(553, 12);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtIdCustomer.TabIndex = 28;
            this.txtIdCustomer.Text = "1";
            this.txtIdCustomer.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Daftar Beli";
            // 
            // txtIdSales
            // 
            this.txtIdSales.Location = new System.Drawing.Point(553, 38);
            this.txtIdSales.Name = "txtIdSales";
            this.txtIdSales.Size = new System.Drawing.Size(100, 20);
            this.txtIdSales.TabIndex = 29;
            this.txtIdSales.Visible = false;
            // 
            // btnFinished
            // 
            this.btnFinished.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFinished.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinished.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.ForeColor = System.Drawing.Color.White;
            this.btnFinished.Location = new System.Drawing.Point(182, 455);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(161, 56);
            this.btnFinished.TabIndex = 28;
            this.btnFinished.Text = "Finished !!!";
            this.btnFinished.UseVisualStyleBackColor = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(665, 523);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.txtIdSales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblTransaction);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Pemesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pemesanan";
            this.Load += new System.EventHandler(this.Pemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_warungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaction)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblTransaction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboMakanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TextBox txtHargaMakanan;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.BindingSource itemBindingSource2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHargaMinuman;
        private System.Windows.Forms.ComboBox comboMinuman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTambahMakanan;
        private System.Windows.Forms.Button btnTambahMinuman;
        private System.Windows.Forms.BindingSource bindingSource1;
        private db_warungDataSet db_warungDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private db_warungDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJumlahBeliMakanan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJumlahBeliMinuman;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdSales;
        private System.Windows.Forms.Button btnFinished;
    }
}