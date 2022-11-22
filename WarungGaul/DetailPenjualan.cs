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
    public partial class DetailPenjualan : Form
    {
        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=AGUSPRASETYO\SQLEXPRESS;Initial Catalog=db_warung;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection_string);

            return conn;
        }

        public DetailPenjualan()
        {
            InitializeComponent();
        }

        private void DetailPenjualan_Load(object sender, EventArgs e)
        {
            displayData(txtIdSales.Text);
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
            tblPenjualanDetail.DataSource = dt;
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
