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
    public partial class frmBookUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmBookUpdateDelete()
        {
            InitializeComponent();
        }

        private void LoadCombo()
        {
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

            // Load Book ID

            SqlDataAdapter sda4 = new SqlDataAdapter("SELECT bookID FROM tblBooks", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            cmbBookId.DisplayMember = "bookID";
            cmbBookId.ValueMember = "bookID";
            cmbBookId.DataSource = dt4;

        }

        private void frmBookUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbBookId_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT bookID, authorID, publisherID, bookName, categoryID, bookPrice, bookImage, bookAvailable FROM tblBooks WHERE bookID =@bid";
            cmd.Parameters.AddWithValue("@bid", cmbBookId.SelectedValue);



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cmbBookAuthors.SelectedValue = dr.GetInt32(1);
                cmbBookPublishers.SelectedValue = dr.GetInt32(2);
                txtBookName.Text = dr.GetString(3);
                cmbBookCatagories.SelectedValue = dr.GetInt32(4);
                txtBookPrice.Text = Convert.ToString(dr.GetDecimal(5));
                pictureBox1.Image = Image.FromStream(dr.GetStream(6));
                txtBookAvailable.Text = Convert.ToString(dr.GetBoolean(7));
               
            }

            con.Close();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPictureFile.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);



            SqlCommand cmd = new SqlCommand("UPDATE tblBooks SET authorID=@ba, publisherID=@bp, bookName=@bn, categoryID=@bc, bookPrice= @bpr, bookImage= @bi, bookAvailable=@bs WHERE bookID = @bid", con);

            cmd.Parameters.AddWithValue("@bid", cmbBookId.SelectedValue);
            cmd.Parameters.AddWithValue("@ba", cmbBookAuthors.SelectedValue);
            cmd.Parameters.AddWithValue("@bp", cmbBookPublishers.SelectedValue);
            cmd.Parameters.AddWithValue("@bn", txtBookName.Text);
            cmd.Parameters.AddWithValue("@bc", cmbBookCatagories.SelectedValue);
            cmd.Parameters.AddWithValue("@bpr", txtBookPrice.Text);
            cmd.Parameters.Add(new SqlParameter("@bi", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@bs", txtBookAvailable.Text);

            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Updated Successfully!!!");
            }

            con.Close();
            LoadCombo();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName); //Exception File Path Is Not Legal.
                this.pictureBox1.Image = img;
                txtPictureFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblBooks WHERE bookID=@bid", con);
            cmd.Parameters.AddWithValue("@bid", cmbBookId.SelectedValue);
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
