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

namespace BookShop
{
    public partial class frmAddPublisher : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmAddPublisher()
        {
            InitializeComponent();
        }

        private void btnSavePublisher_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblPublishers(publisherName, publisherAddress, publisherEmail, publisherPhone)VALUES(@pn, @pa, @pe, @pp)";

            cmd.Parameters.AddWithValue("@pn", txtPublisherName.Text);
            cmd.Parameters.AddWithValue("@pa", txtPublisherAddress.Text);
            cmd.Parameters.AddWithValue("@pe", txtPublisherEmail.Text);
            cmd.Parameters.AddWithValue("@pp", txtPublisherPhone.Text);
            

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Saved Successfully!!!");
            }

            con.Close();
            AllClear();
        }

        private void AllClear()
        {
            txtPublisherName.Clear();
            txtPublisherAddress.Clear();
            txtPublisherEmail.Clear();
            txtPublisherPhone.Clear();
        }
    }
}
