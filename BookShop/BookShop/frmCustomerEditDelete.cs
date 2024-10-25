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
    public partial class frmCustomerEditDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmCustomerEditDelete()
        {
            InitializeComponent();
        }

        private void LoadCombo()
        {
          
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblGender", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            cmbCustomerGender.DataSource = ds.Tables[0];
            cmbCustomerGender.DisplayMember = "genderType";
            cmbCustomerGender.ValueMember = "genderID";

            con.Close();

            // Load Customer ID

            SqlDataAdapter sda = new SqlDataAdapter("SELECT customerID FROM tblCustomers", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbCustomerId.DisplayMember = "customerID";
            cmbCustomerId.ValueMember = "customerID";
            cmbCustomerId.DataSource = dt;

        }
        private void frmCustomerEditDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT customerID, customerName, genderID, customerLocation, customerEmail, customerPhone FROM tblCustomers WHERE customerID =@cid";
            cmd.Parameters.AddWithValue("@cid", cmbCustomerId.SelectedValue);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtCustomerName.Text = dr.GetString(1);
                cmbCustomerGender.SelectedValue = dr.GetInt32(2);
                txtCustomerAddress.Text = dr.GetString(3);
                txtCustomerEmail.Text = dr.GetString(4);
                txtCustomerPhone.Text = dr.GetString(5);
            }

            con.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tblCustomers SET customerName = @cn, genderID = @cg, customerLocation = @ca, customerEmail = @ce, customerPhone = @cp WHERE customerID = @cid", con);
            cmd.Parameters.AddWithValue("@cid", cmbCustomerId.SelectedValue);
            cmd.Parameters.AddWithValue("@cn", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@cg", cmbCustomerGender.SelectedValue);
            cmd.Parameters.AddWithValue("@ca", txtCustomerAddress.Text);
            cmd.Parameters.AddWithValue("@ce", txtCustomerEmail.Text);
            cmd.Parameters.AddWithValue("@cp", txtCustomerPhone.Text);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Updated Successfully!!!");
            }

            con.Close();
            LoadCombo();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblCustomers WHERE customerID=@cid", con);
            cmd.Parameters.AddWithValue("@cid", cmbCustomerId.SelectedValue);
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
