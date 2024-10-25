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
    public partial class frmAddNewCategory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmAddNewCategory()
        {
            InitializeComponent();
        }

        private void frmAddNewCategory_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblBookCategory(categoryID, categoryType)VALUES(@cid, @cn)";

            cmd.Parameters.AddWithValue("@cid", txtCategoryId.Text);
            cmd.Parameters.AddWithValue("@cn", txtCategoryName.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Saved Successfully!!!");
            }

            con.Close();
            AllClear();
        }

        private void AllClear()
        {
            txtCategoryId.Clear();
            txtCategoryName.Clear();
        }
    }
}
