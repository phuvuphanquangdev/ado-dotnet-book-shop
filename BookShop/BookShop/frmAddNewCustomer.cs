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
    public partial class frmAddNewCustomer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }


        
        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblGender", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            cmbCustomerGender.DataSource = ds.Tables[0];
            cmbCustomerGender.DisplayMember = "genderType";
            cmbCustomerGender.ValueMember = "genderID";
        }

       

        private void AllClear()
        {
            txtCustomerName.Clear();
            cmbCustomerGender.SelectedIndex = -1;
            txtCustomerAddress.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblCustomers(customerName, genderID, customerLocation, customerEmail, customerPhone)VALUES(@cn, @cg, @ca, @ce, @cp)";

            cmd.Parameters.AddWithValue("@cn", txtCustomerName.Text);
            cmd.Parameters.AddWithValue("@cg", cmbCustomerGender.SelectedValue);
            cmd.Parameters.AddWithValue("@ca", txtCustomerAddress.Text);
            cmd.Parameters.AddWithValue("@ce", txtCustomerEmail.Text);
            cmd.Parameters.AddWithValue("@cp", txtCustomerPhone.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Saved Successfully!!!");
            }

            con.Close();
            AllClear();
        }
    }
}
