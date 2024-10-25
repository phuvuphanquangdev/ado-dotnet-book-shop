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
    public partial class frmCreateNewSell : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmCreateNewSell()
        {
            InitializeComponent();
        }
        private void LoadCombo()
        {
            con.Open();
            
            // Load Catagory Name

            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT customerID, customerName FROM tblCustomers", con);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            cmbSellCustomer.DataSource = ds1.Tables[0];
            cmbSellCustomer.DisplayMember = "customerName";
            cmbSellCustomer.ValueMember = "customerID";

            con.Close();
            SqlDataAdapter sda4 = new SqlDataAdapter("SELECT bookID, bookName FROM tblBooks", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            cmbSellBook.DisplayMember = "bookName";
            cmbSellBook.ValueMember = "bookID";
            cmbSellBook.DataSource = dt4;
        }

        private void frmCreateNewSell_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbSellBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT bookID, bookName,bookPrice FROM tblBooks WHERE bookID="+cmbSellBook.SelectedValue+"", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtSellBookPrice.Text = dt.Rows[0]["bookPrice"].ToString();

            con.Close();
        }

        private void btnSaveSell_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblsells(customerID,bookID,sellDate,sellPrice)VALUES(@sci,@sbi,@sd,@sbp)";

            cmd.Parameters.AddWithValue("@sci", cmbSellCustomer.SelectedValue);
            cmd.Parameters.AddWithValue("@sbi", cmbSellBook.SelectedValue);
            cmd.Parameters.AddWithValue("@sd", Convert.ToDateTime(txtSelldateTimePicker.Text));
            cmd.Parameters.AddWithValue("@sbp", txtSellBookPrice.Text);


            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Saved Successfully!!!");
                
            }

            con.Close();
            AllClear();
        }
        private void AllClear()
        {
            cmbSellCustomer.SelectedIndex = -1;
            txtSellBookPrice.Clear();
        }
    }
}
