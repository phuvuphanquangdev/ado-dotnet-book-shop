using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorInsert ai = new frmAuthorInsert();
            //ai.MdiParent = this;
            ai.Show();
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorEditDelete fud = new frmAuthorEditDelete();
            //fud.MdiParent = this;
            fud.Show();
        }

        private void viewAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthorsDataView adv = new frmAuthorsDataView();
            //    adv.MdiParent = this;
            adv.Show();
        }

        private void addPublisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPublisher ap = new frmAddPublisher();
            //    ap.MdiParent = this;
            ap.Show();
        }

        private void updateDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPublisherUpdateDelete pud = new frmPublisherUpdateDelete();
            //    pud.MdiParent = this;
            pud.Show();
        }

        private void viewInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublishersDataView pdv = new frmPublishersDataView();
            //    pdv.MdiParent = this;
            pdv.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer anc = new frmAddNewCustomer();
            //    anc.MdiParent = this;
            anc.Show();
        }

        private void updateDeleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCustomerEditDelete ced = new frmCustomerEditDelete();
            //    ced.MdiParent = this;
            ced.Show();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerInformationView civ = new frmCustomerInformationView();
            //    civ.MdiParent = this;
            civ.Show();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewBook anb = new frmAddNewBook();
            //    anb.MdiParent = this;
            anb.Show();
        }

        private void updateDeleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmBookUpdateDelete bud = new frmBookUpdateDelete();
            //    bud.MdiParent = this;
            bud.Show();
        }

        private void allBookInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookInformation bi = new frmBookInformation();
            //    bi.MdiParent = this;
            bi.Show();
        }

        private void createSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateNewSell cs = new frmCreateNewSell();
            //    cs.MdiParent = this;
            cs.Show();
        }

        private void allSellInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellUpdateDelete sud = new frmSellUpdateDelete();
            //    sud.MdiParent = this;
            sud.Show();
        }

        private void showAllSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowAllSells sas = new frmShowAllSells();
            //    sas.MdiParent = this;
            sas.Show();
        }

        private void authorsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptAuthorsInformationView aai = new rptAuthorsInformationView();
            aai.Show();
        }

        private void bookListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListofBooksReport lbr = new frmListofBooksReport();
            lbr.Show();
        }

        private void totalSellsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllBookshopSalesReport abs = new frmAllBookshopSalesReport();
            abs.Show();
        }

        private void addNewCategoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCategory nc = new frmAddNewCategory();
            nc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
