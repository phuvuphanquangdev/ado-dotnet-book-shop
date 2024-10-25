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
    public partial class frmPublishersDataView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmPublishersDataView()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblPublishers", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void frmPublishersDataView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
