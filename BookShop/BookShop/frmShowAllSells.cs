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
    public partial class frmShowAllSells : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmShowAllSells()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT c.customerName, b.bookName, b.bookPrice, s.sellPrice FROM tblsells s INNER JOIN tblCustomers c ON s.customerID = c.customerID INNER JOIN tblBooks b ON s.bookID = b.bookID", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void frmShowAllSells_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
