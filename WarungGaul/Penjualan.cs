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
    public partial class Penjualan : Form
    {
        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=AGUSPRASETYO\SQLEXPRESS;Initial Catalog=db_warung;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection_string);

            return conn;
        }

        public Penjualan()
        {
            InitializeComponent();
        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            //cmd.CommandText = "SELECT it.name AS 'Nama Item', it.price AS 'Harga', sd.amount AS 'jumlah', sd.sub_total AS 'Sub Total' FROM sales_detail sd INNER JOIN " +
            //  " item it ON sd.item_id = it.id INNER JOIN " +
            //" sales sal ON sd.sales_id = sal.id" +
            //" WHERE sales_id = " + id_sales;

            cmd.CommandText = "SELECT s.id as ID, c.name as 'Nama Pelanggan', s.transaction_date as 'Tanggal Transaksi', s.total " + 
                "FROM sales s " + 
                "INNER JOIN customer c ON s.customer_id = c.id ";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            tblPenjualan.DataSource = dt;
            conn.Close();
        }

        private void tblPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailPenjualan detailPenjualan = new DetailPenjualan();
            detailPenjualan.txtIdSales.Text = tblPenjualan.CurrentRow.Cells[0].Value.ToString();
            detailPenjualan.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
