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
    public partial class frmAuthorInsert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog=BookShopDB; Integrated Security=True ");
        public frmAuthorInsert()
        {
            InitializeComponent();
        }

        // Save Or insert data into database.
        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPictureFile.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblAuthors(authorName, genderID, authorEmail, authorPhone, authorImage)VALUES(@n, @g, @e, @p, @i)";
            
            cmd.Parameters.AddWithValue("@n", txtAuthorName.Text);
            cmd.Parameters.AddWithValue("@g", cmbAuthorGender.SelectedValue);
            cmd.Parameters.AddWithValue("@e", txtAuthorEmail.Text);
            cmd.Parameters.AddWithValue("@p", txtAuthorPhone.Text);
            cmd.Parameters.Add(new SqlParameter("@i", SqlDbType.VarBinary) { Value = ms.ToArray()});

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Saved Successfully!!!");
            }

            con.Close();
            AllClear();
        }


        private void AllClear()
        {
            txtAuthorName.Clear();
            txtAuthorEmail.Clear();
            txtAuthorPhone.Clear();
            txtPictureFile.Clear();
            cmbAuthorGender.SelectedIndex = -1;
        }

        // Lode Combobox Data From Data Base
        private void frmAuthorInsert_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblGender", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            cmbAuthorGender.DataSource = ds.Tables[0];
            cmbAuthorGender.DisplayMember = "genderType";
            cmbAuthorGender.ValueMember = "genderID";
        }

        // Open and show picture
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
