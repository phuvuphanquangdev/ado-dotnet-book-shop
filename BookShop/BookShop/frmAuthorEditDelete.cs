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
    public partial class frmAuthorEditDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmAuthorEditDelete()
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

            cmbAuthorGender.DataSource = ds.Tables[0];
            cmbAuthorGender.DisplayMember = "genderType";
            cmbAuthorGender.ValueMember = "genderID";

            con.Close();

            // Load Author ID

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT authorID FROM tblAuthors", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmbAuthorId.DisplayMember = "authorID";
            cmbAuthorId.ValueMember = "authorID";
            cmbAuthorId.DataSource = dt2;

        }

        private void frmAuthorEditDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbAuthorId_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT authorID, authorName, genderID, authorEmail, authorPhone, authorImage FROM tblAuthors WHERE authorID =@i";
            cmd.Parameters.AddWithValue("@i", cmbAuthorId.SelectedValue);


           
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtAuthorName.Text = dr.GetString(1);
                cmbAuthorGender.SelectedValue = dr.GetInt32(2);
                txtAuthorEmail.Text = dr.GetString(3);
                txtAuthorPhone.Text = dr.GetString(4);
                pictureBox1.Image = Image.FromStream(dr.GetStream(5));
            }

            con.Close();
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPictureFile.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            

            SqlCommand cmd = new SqlCommand("UPDATE tblAuthors SET authorName = @n, genderID = @g, authorEmail = @e, authorPhone = @p, authorImage = @i WHERE authorID = @id",con);
            cmd.Parameters.AddWithValue("@id", cmbAuthorId.SelectedValue);
            cmd.Parameters.AddWithValue("@n", txtAuthorName.Text);
            cmd.Parameters.AddWithValue("@g", cmbAuthorGender.SelectedValue);
            cmd.Parameters.AddWithValue("@e", txtAuthorEmail.Text);
            cmd.Parameters.AddWithValue("@p", txtAuthorPhone.Text);
            cmd.Parameters.Add(new SqlParameter("@i", SqlDbType.VarBinary) { Value = ms.ToArray() });
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

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tblAuthors WHERE authorID=@id", con);
            cmd.Parameters.AddWithValue("@id", cmbAuthorId.SelectedValue);
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
