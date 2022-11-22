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
    public partial class Customer : Form
    {
        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=AGUSPRASETYO\SQLEXPRESS;Initial Catalog=db_warung;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection_string);

            return conn;
        }

        public Customer()
        {
            InitializeComponent();

            displayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO customer (name) VALUES ('" +
                txtName.Text + "')";

            cmd.ExecuteNonQuery();
            conn.Close();
            displayData();

            MessageBox.Show("Simpan data berhasil!!", "Alert");

            deleteValueTextBox();
        }

        public void displayData()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id AS 'ID', name AS 'Nama Pelanggan' FROM customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            tblCustomer.DataSource = dt;
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE customer SET " +
                "name = '" + txtName.Text + "'" + " WHERE id = " + Convert.ToInt32(txtIdCustomer.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            displayData();

            MessageBox.Show("Update data berhasil!!", "Alert");

            deleteValueTextBox();
        }

        private void deleteValueTextBox()
        {
            txtName.Text = "";
            txtIdCustomer.Text = "";
        }

        private void tblCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCustomer.Text = tblCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = tblCustomer.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
