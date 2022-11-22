using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarungGaul
{
    public partial class Pemesanan : Form
    {
        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=AGUSPRASETYO\SQLEXPRESS;Initial Catalog=db_warung;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection_string);

            return conn;
        }
        public Pemesanan()
        {
            InitializeComponent();
        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            listComboMakanan();
            listComboMinuman();
            listComboPelanggan();
            disabledButtonInput();

            //txtHargaMakanan.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboCustomer.SelectedValue.ToString());
        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboMakanan.SelectedItem;

            txtHargaMakanan.Text = drv["price"].ToString();
        }

        private void listComboPelanggan()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            comboCustomer.DataSource = dt;
            comboCustomer.DisplayMember = "name";
            comboCustomer.ValueMember = "id";
        }

        private void listComboMakanan()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM item WHERE category = 'Makanan'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            comboMakanan.DataSource = dt;
            comboMakanan.DisplayMember = "name";
            comboMakanan.ValueMember = "id";
        }

        private void listComboMinuman()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM item WHERE category = 'Minuman'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            comboMinuman.DataSource = dt;
            comboMinuman.DisplayMember = "name";
            comboMinuman.ValueMember = "id";
        }

        private void comboMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboMinuman.SelectedItem;

            txtHargaMinuman.Text = drv["price"].ToString();
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
           //txtIdCustomer.Text = comboCustomer.SelectedValue.ToString();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            Int32 idProd = 0;
            SqlConnection conn = koneksi();
            DateTime time = DateTime.Now;
            String dateTimeformat = time.ToString("yyyy-MM-dd HH:mm:ss");
            txtIdCustomer.Text = comboCustomer.SelectedValue.ToString();

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO sales (customer_id, total, transaction_date) VALUES ('" +
                txtIdCustomer.Text + "','" +
                0 + "','" +
                dateTimeformat + "'); SELECT CAST(scope_identity() AS int)";

            //cmd.ExecuteNonQuery();


            idProd = (Int32)cmd.ExecuteScalar();
            conn.Close();
            
            MessageBox.Show("Pesanan berhasil dibuat", "Alert");
            
            comboCustomer.Enabled = false;
            btnPesan.Enabled = false;
            enabledButtonInput();

            

            displayData(idProd.ToString());
            txtIdSales.Text = idProd.ToString();

            // txtIdSales.Text = "19";
        }

        private void disabledButtonInput()
        {
            comboMakanan.Enabled = false;
            comboMinuman.Enabled = false;
            btnTambahMakanan.Enabled = false;
            btnTambahMinuman.Enabled = false;
            txtJumlahBeliMakanan.ReadOnly = true;
            txtJumlahBeliMinuman.ReadOnly = true;
        }

        private void enabledButtonInput()
        {
            comboMakanan.Enabled = true;
            comboMinuman.Enabled = true;
            btnTambahMakanan.Enabled = true;
            btnTambahMinuman.Enabled = true;
            txtJumlahBeliMakanan.ReadOnly = false;
            txtJumlahBeliMinuman.ReadOnly = false;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM sales_detail WHERE sales_id =" + txtIdSales.Text;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "DELETE FROM sales WHERE id =" + txtIdSales.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            displayData(txtIdSales.Text);

            MessageBox.Show("Delete Success");

            //deleteValueTextBox();

            disabledButtonInput();
            comboCustomer.Enabled = true;
            btnPesan.Enabled = true;
            txtJumlahBeliMakanan.Text = "";
            txtJumlahBeliMinuman.Text = "";
        }

        public void displayData(String id_sales)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT it.name AS 'Nama Item', it.price AS 'Harga', sd.amount AS 'jumlah', sd.sub_total AS 'Sub Total' FROM sales_detail sd INNER JOIN " +
                " item it ON sd.item_id = it.id INNER JOIN " +
                " sales sal ON sd.sales_id = sal.id" +
                " WHERE sales_id = " + id_sales;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            tblTransaction.DataSource = dt;
            conn.Close();
        }

        private void btnTambahMakanan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            Double sub_total = Convert.ToDouble(txtHargaMakanan.Text) * Convert.ToDouble(txtJumlahBeliMakanan.Text);
            
            cmd.CommandText = "INSERT INTO sales_detail (sales_id, item_id, amount, sub_total) VALUES ('" +
                txtIdSales.Text + "','" +
                comboMakanan.SelectedValue.ToString() + "','" +
                txtJumlahBeliMakanan.Text + "','" +
                sub_total + "')";

            cmd.ExecuteNonQuery();
            conn.Close();
            displayData(txtIdSales.Text);

            txtJumlahBeliMakanan.Text = "";
            MessageBox.Show("Tambah makanan berhasil!!", "Alert");
        }

        private void btnTambahMinuman_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            Double sub_total = Convert.ToDouble(txtHargaMinuman.Text) * Convert.ToDouble(txtJumlahBeliMinuman.Text);

            cmd.CommandText = "INSERT INTO sales_detail (sales_id, item_id, amount, sub_total) VALUES ('" +
                txtIdSales.Text + "','" +
                comboMinuman.SelectedValue.ToString() + "','" +
                txtJumlahBeliMinuman.Text + "','" +
                sub_total + "')";

            cmd.ExecuteNonQuery();
            conn.Close();
            displayData(txtIdSales.Text);

            txtJumlahBeliMinuman.Text = "";
            MessageBox.Show("Tambah minuman berhasil!!", "Alert");
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();

            // Hitung Total
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select SUM([sub_total]) as total FROM dbo.sales_detail WHERE sales_id = '" + txtIdSales.Text + "' GROUP BY sales_id";

            conn.Open();
            Decimal amount = (Decimal)cmd.ExecuteScalar();
            conn.Close();

            // Memasukan total amount barang ke sales
            conn.Open();
            
            cmd.CommandText = "UPDATE sales SET " +
               "total = " + amount + " WHERE id = " + Convert.ToInt32(txtIdSales.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            displayData(txtIdSales.Text);

            txtJumlahBeliMakanan.Text = "";
            
            MessageBox.Show("Transaksi sukses, terima kasih!!", "Alert");
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
