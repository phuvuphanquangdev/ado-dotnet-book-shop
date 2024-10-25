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
    public partial class frmBookInformation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmBookInformation()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT b.bookName, c.categoryType, a.authorName, p.publisherName, b.bookPrice, b.bookAvailable FROM tblBooks b INNER JOIN tblBookCategory c ON b.categoryID = c.categoryID INNER JOIN tblAuthors a ON a.authorID = b.authorID INNER JOIN tblPublishers p ON p.publisherID = b.publisherID", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void frmBookInformation_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
