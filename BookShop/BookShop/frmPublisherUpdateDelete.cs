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
    public partial class frmPublisherUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmPublisherUpdateDelete()
        {
            InitializeComponent();
        }

        private void LoadCombo()
        {
            // Load Publisher ID
            SqlDataAdapter sda = new SqlDataAdapter("SELECT publisherID FROM tblPublishers", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbPublisherId.DisplayMember = "publisherID";
            cmbPublisherId.ValueMember = "publisherID";
            cmbPublisherId.DataSource = dt;
        }

        private void frmPublisherUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbPublisherId_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT publisherID, publisherName, publisherAddress, publisherEmail, publisherPhone FROM tblPublishers WHERE publisherID =@pid";
            cmd.Parameters.AddWithValue("@pid", cmbPublisherId.SelectedValue);



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtPublisherName.Text = dr.GetString(1);
                txtPublisherAddress.Text = dr.GetString(2);
                txtPublisherEmail.Text = dr.GetString(3);
                txtPublisherPhone.Text = dr.GetString(4);
            }

            con.Close();
        }

        private void btnUpdatePublisher_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("UPDATE tblPublishers SET publisherName = @pn, publisherAddress = @pa, publisherEmail = @pe, publisherPhone = @pp  WHERE publisherID = @pid", con);
            cmd.Parameters.AddWithValue("@pid", cmbPublisherId.SelectedValue);
            cmd.Parameters.AddWithValue("@pn", txtPublisherName.Text);
            cmd.Parameters.AddWithValue("@pa", txtPublisherAddress.Text);
            cmd.Parameters.AddWithValue("@pe", txtPublisherEmail.Text);
            cmd.Parameters.AddWithValue("@pp", txtPublisherPhone.Text);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Updated Successfully!!!");
            }

            con.Close();
            LoadCombo();
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblPublishers WHERE publisherID=@pid", con);
            cmd.Parameters.AddWithValue("@pid", cmbPublisherId.SelectedValue);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Deleted successfully!!!");
            }
            con.Close();
            LoadCombo();
        }
    }
}
