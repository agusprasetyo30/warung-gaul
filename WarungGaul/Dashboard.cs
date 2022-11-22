using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarungGaul
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quote quote = new Quote();
            quote.Show();
        }

        private void btnListItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
        }

        private void btnListCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void btnPemesanan_Click(object sender, EventArgs e)
        {
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            Penjualan penjualan = new Penjualan();
            penjualan.Show();
        }
    }
}
