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
    public partial class Item : Form
    {
        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=AGUSPRASETYO\SQLEXPRESS;Initial Catalog=db_warung;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connection_string);

            return conn;
        }

        public Item()
        {
            InitializeComponent();

            displayData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void displayData()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id AS 'ID Makanan', name AS 'Nama Makanan', category AS Kategori, price AS Harga, description AS Deskripsi FROM item";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            tblItem.DataSource = dt;
            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO item (name, category, price, description) VALUES ('" +
                txtName.Text + "','" +
                comboCategory.Text + "','" +
                txtPrice.Text + "','" +
                txtDescription.Text + "')";

           cmd.ExecuteNonQuery();
           conn.Close();
           displayData();

            MessageBox.Show("Simpan data berhasil!!");

            deleteValueTextBox();
        }

        private void deleteValueTextBox()
        {
            txtName.Text = "";
            txtIdItem.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }

        private void tblItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdItem.Text = tblItem.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = tblItem.CurrentRow.Cells[1].Value.ToString();
            comboCategory.Text = tblItem.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = tblItem.CurrentRow.Cells[3].Value.ToString();
            txtDescription.Text = tblItem.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE item SET " +
                "name = '" + txtName.Text + "', " +
                "category = '" + comboCategory.Text + "', " +
                "price = '" + txtPrice.Text + "', " +
                "description = '" + txtDescription.Text + "' WHERE id = " + Convert.ToInt32(txtIdItem.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            displayData();

            MessageBox.Show("Update data berhasil!!");

            deleteValueTextBox();
        }
    }

}
