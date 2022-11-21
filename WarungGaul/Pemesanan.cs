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
            // TODO: This line of code loads data into the 'db_warungDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.db_warungDataSet.customer);
            listComboMakanan();
            listComboMinuman();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboSex.SelectedValue.ToString());
        }

        private void comboSex_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    txtJenisKelamin.Text = comboSex.SelectedValue.ToString();
            //if()
            //{

            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboMakanan.SelectedItem;

            txtHargaMakanan.Text = drv["price"].ToString();
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
    }
}
