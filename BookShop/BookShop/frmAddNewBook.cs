using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class frmAddNewBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmAddNewBook()
        {
            InitializeComponent();
        }

        private void LoadCombo()
        {
            // Load Author Name
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT authorID, authorName FROM tblAuthors", con);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);
            cmbBookAuthors.DataSource = ds1.Tables[0];
            cmbBookAuthors.ValueMember = "authorID";
            cmbBookAuthors.DisplayMember = "authorName";

            // Load Publishers Name

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT publisherID, publisherName FROM tblPublishers", con);
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2);
            cmbBookPublishers.DataSource = ds2.Tables[0];
            cmbBookPublishers.DisplayMember = "publisherName";
            cmbBookPublishers.ValueMember = "publisherID";
            

            // Load Catagory Name

            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT categoryID, categoryType FROM tblBookCategory", con);
            DataSet ds3 = new DataSet();
            sda3.Fill(ds3);
            cmbBookCatagories.DataSource = ds3.Tables[0];
            cmbBookCatagories.DisplayMember = "categoryType";
            cmbBookCatagories.ValueMember = "categoryID";
            
            con.Close();
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        // Open and show picture
 

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPictureFile.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblBooks(authorID, publisherID, bookName, categoryID, bookPrice, bookImage, bookAvailable)VALUES(@ba, @bp, @bn, @bc, @bpr, @bi, @bs)";

            cmd.Parameters.AddWithValue("@ba", cmbBookAuthors.SelectedValue);
            cmd.Parameters.AddWithValue("@bp", cmbBookPublishers.SelectedValue);
            cmd.Parameters.AddWithValue("@bn", txtBookName.Text);
            cmd.Parameters.AddWithValue("@bc", cmbBookCatagories.SelectedValue);
            cmd.Parameters.AddWithValue("@bpr", txtBookPrice.Text);
            cmd.Parameters.Add(new SqlParameter("@bi", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@bs", txtBookAvailable.Text);
           

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Saved Successfully!!!");
            }

            con.Close();
            AllClear();
        }

        private void AllClear()
        {
            cmbBookAuthors.SelectedIndex = -1;
            cmbBookPublishers.SelectedIndex = -1;
            txtBookName.Clear();
            cmbBookCatagories.SelectedIndex = -1;
            txtBookPrice.Clear();
            txtBookAvailable.Clear();
            txtPictureFile.Clear();
            
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPictureFile.Text = openFileDialog1.FileName;
            }
        }
    }
}
