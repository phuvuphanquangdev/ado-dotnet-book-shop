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
    public partial class frmSellUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmSellUpdateDelete()
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

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT bookID, bookName FROM tblBooks", con);
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2);
            cmbSellBook.DataSource = ds2.Tables[0];
            cmbSellBook.DisplayMember = "bookName";
            cmbSellBook.ValueMember = "bookID";

            con.Close();
            SqlDataAdapter sda4 = new SqlDataAdapter("SELECT sellID FROM tblsells", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            cmbSellsId.DisplayMember = "sellID";
            cmbSellsId.ValueMember = "sellID";
            cmbSellsId.DataSource = dt4;
        }

        private void frmSellUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbSellsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT sellID, customerID, bookID,sellPrice FROM tblsells WHERE sellID =@sid";
            cmd.Parameters.AddWithValue("@sid", cmbSellsId.SelectedValue);



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cmbSellCustomer.SelectedValue = dr.GetInt32(1);
                cmbSellBook.SelectedValue = dr.GetInt32(2);
                txtSellBookPrice.Text = Convert.ToString(dr.GetDecimal(3));
            };

            con.Close();
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tblsells SET customerID = @cid, bookID = @bid, sellPrice = @bp WHERE sellID = @sid", con);
            cmd.Parameters.AddWithValue("@sid", cmbSellsId.SelectedValue);
            cmd.Parameters.AddWithValue("@cid", cmbSellCustomer.SelectedValue);
            cmd.Parameters.AddWithValue("@bid", cmbSellBook.SelectedValue);
            cmd.Parameters.AddWithValue("@bp", txtSellBookPrice.Text);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Updated Successfully!!!");
            }

            con.Close();
            LoadCombo();
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblsells WHERE sellID=@id", con);
            cmd.Parameters.AddWithValue("@id", cmbSellsId.SelectedValue);
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
