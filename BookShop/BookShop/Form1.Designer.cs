
namespace BookShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aUTHORSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUBLISHERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPublisherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.allBookInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSellInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllSellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSellsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTHORSToolStripMenuItem,
            this.pUBLISHERSToolStripMenuItem,
            this.bOOKSToolStripMenuItem,
            this.cUSTOMERSToolStripMenuItem,
            this.sELLSToolStripMenuItem,
            this.globalPropertiesToolStripMenuItem,
            this.rEPORTSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aUTHORSToolStripMenuItem
            // 
            this.aUTHORSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.aUTHORSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAuthorToolStripMenuItem,
            this.updateDeleteToolStripMenuItem,
            this.viewAuthorToolStripMenuItem});
            this.aUTHORSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aUTHORSToolStripMenuItem.Name = "aUTHORSToolStripMenuItem";
            this.aUTHORSToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.aUTHORSToolStripMenuItem.Text = "AUTHORS";
            // 
            // addAuthorToolStripMenuItem
            // 
            this.addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            this.addAuthorToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addAuthorToolStripMenuItem.Text = "Add Author";
            this.addAuthorToolStripMenuItem.Click += new System.EventHandler(this.addAuthorToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.updateDeleteToolStripMenuItem.Text = "Update / Delete";
            this.updateDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem_Click);
            // 
            // viewAuthorToolStripMenuItem
            // 
            this.viewAuthorToolStripMenuItem.Name = "viewAuthorToolStripMenuItem";
            this.viewAuthorToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.viewAuthorToolStripMenuItem.Text = "View All Author";
            this.viewAuthorToolStripMenuItem.Click += new System.EventHandler(this.viewAuthorToolStripMenuItem_Click);
            // 
            // pUBLISHERSToolStripMenuItem
            // 
            this.pUBLISHERSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.pUBLISHERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPublisherToolStripMenuItem,
            this.updateDeleteToolStripMenuItem1,
            this.viewInformationToolStripMenuItem});
            this.pUBLISHERSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pUBLISHERSToolStripMenuItem.Name = "pUBLISHERSToolStripMenuItem";
            this.pUBLISHERSToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.pUBLISHERSToolStripMenuItem.Text = "PUBLISHERS";
            // 
            // addPublisherToolStripMenuItem
            // 
            this.addPublisherToolStripMenuItem.Name = "addPublisherToolStripMenuItem";
            this.addPublisherToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.addPublisherToolStripMenuItem.Text = "Add Publisher";
            this.addPublisherToolStripMenuItem.Click += new System.EventHandler(this.addPublisherToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem1
            // 
            this.updateDeleteToolStripMenuItem1.Name = "updateDeleteToolStripMenuItem1";
            this.updateDeleteToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.updateDeleteToolStripMenuItem1.Text = "Update / Delete";
            this.updateDeleteToolStripMenuItem1.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem1_Click);
            // 
            // viewInformationToolStripMenuItem
            // 
            this.viewInformationToolStripMenuItem.Name = "viewInformationToolStripMenuItem";
            this.viewInformationToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.viewInformationToolStripMenuItem.Text = "View Information";
            this.viewInformationToolStripMenuItem.Click += new System.EventHandler(this.viewInformationToolStripMenuItem_Click);
            // 
            // bOOKSToolStripMenuItem
            // 
            this.bOOKSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.bOOKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.updateDeleteToolStripMenuItem3,
            this.allBookInformationToolStripMenuItem});
            this.bOOKSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            this.bOOKSToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.bOOKSToolStripMenuItem.Text = "BOOKS";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem3
            // 
            this.updateDeleteToolStripMenuItem3.Name = "updateDeleteToolStripMenuItem3";
            this.updateDeleteToolStripMenuItem3.Size = new System.Drawing.Size(244, 26);
            this.updateDeleteToolStripMenuItem3.Text = "Update / Delete";
            this.updateDeleteToolStripMenuItem3.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem3_Click);
            // 
            // allBookInformationToolStripMenuItem
            // 
            this.allBookInformationToolStripMenuItem.Name = "allBookInformationToolStripMenuItem";
            this.allBookInformationToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.allBookInformationToolStripMenuItem.Text = "All Book Information ";
            this.allBookInformationToolStripMenuItem.Click += new System.EventHandler(this.allBookInformationToolStripMenuItem_Click);
            // 
            // cUSTOMERSToolStripMenuItem
            // 
            this.cUSTOMERSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.cUSTOMERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.updateDeleteToolStripMenuItem2,
            this.customerInformationToolStripMenuItem});
            this.cUSTOMERSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cUSTOMERSToolStripMenuItem.Name = "cUSTOMERSToolStripMenuItem";
            this.cUSTOMERSToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.cUSTOMERSToolStripMenuItem.Text = "CUSTOMERS";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.addNewCustomerToolStripMenuItem.Text = "Add Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem2
            // 
            this.updateDeleteToolStripMenuItem2.Name = "updateDeleteToolStripMenuItem2";
            this.updateDeleteToolStripMenuItem2.Size = new System.Drawing.Size(249, 26);
            this.updateDeleteToolStripMenuItem2.Text = "Update / Delete";
            this.updateDeleteToolStripMenuItem2.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem2_Click);
            // 
            // customerInformationToolStripMenuItem
            // 
            this.customerInformationToolStripMenuItem.Name = "customerInformationToolStripMenuItem";
            this.customerInformationToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.customerInformationToolStripMenuItem.Text = "Customer Information";
            this.customerInformationToolStripMenuItem.Click += new System.EventHandler(this.customerInformationToolStripMenuItem_Click);
            // 
            // sELLSToolStripMenuItem
            // 
            this.sELLSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.sELLSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSalesToolStripMenuItem,
            this.allSellInformationToolStripMenuItem,
            this.showAllSellsToolStripMenuItem});
            this.sELLSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sELLSToolStripMenuItem.Name = "sELLSToolStripMenuItem";
            this.sELLSToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.sELLSToolStripMenuItem.Text = "SELLS";
            // 
            // createSalesToolStripMenuItem
            // 
            this.createSalesToolStripMenuItem.Name = "createSalesToolStripMenuItem";
            this.createSalesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.createSalesToolStripMenuItem.Text = "Create Sell";
            this.createSalesToolStripMenuItem.Click += new System.EventHandler(this.createSalesToolStripMenuItem_Click);
            // 
            // allSellInformationToolStripMenuItem
            // 
            this.allSellInformationToolStripMenuItem.Name = "allSellInformationToolStripMenuItem";
            this.allSellInformationToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.allSellInformationToolStripMenuItem.Text = "Update / Delete";
            this.allSellInformationToolStripMenuItem.Click += new System.EventHandler(this.allSellInformationToolStripMenuItem_Click);
            // 
            // showAllSellsToolStripMenuItem
            // 
            this.showAllSellsToolStripMenuItem.Name = "showAllSellsToolStripMenuItem";
            this.showAllSellsToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.showAllSellsToolStripMenuItem.Text = "Show All Sells";
            this.showAllSellsToolStripMenuItem.Click += new System.EventHandler(this.showAllSellsToolStripMenuItem_Click);
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.rEPORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsReportToolStripMenuItem,
            this.bookListReportToolStripMenuItem,
            this.totalSellsReportToolStripMenuItem});
            this.rEPORTSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // authorsReportToolStripMenuItem
            // 
            this.authorsReportToolStripMenuItem.Name = "authorsReportToolStripMenuItem";
            this.authorsReportToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.authorsReportToolStripMenuItem.Text = "Authors Report";
            this.authorsReportToolStripMenuItem.Click += new System.EventHandler(this.authorsReportToolStripMenuItem_Click);
            // 
            // bookListReportToolStripMenuItem
            // 
            this.bookListReportToolStripMenuItem.Name = "bookListReportToolStripMenuItem";
            this.bookListReportToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.bookListReportToolStripMenuItem.Text = "Book List Report";
            this.bookListReportToolStripMenuItem.Click += new System.EventHandler(this.bookListReportToolStripMenuItem_Click);
            // 
            // totalSellsReportToolStripMenuItem
            // 
            this.totalSellsReportToolStripMenuItem.Name = "totalSellsReportToolStripMenuItem";
            this.totalSellsReportToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.totalSellsReportToolStripMenuItem.Text = "Total Sells Report";
            this.totalSellsReportToolStripMenuItem.Click += new System.EventHandler(this.totalSellsReportToolStripMenuItem_Click);
            // 
            // globalPropertiesToolStripMenuItem
            // 
            this.globalPropertiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoToolStripMenuItem});
            this.globalPropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.globalPropertiesToolStripMenuItem.Name = "globalPropertiesToolStripMenuItem";
            this.globalPropertiesToolStripMenuItem.Size = new System.Drawing.Size(179, 25);
            this.globalPropertiesToolStripMenuItem.Text = "GLOBAL PROPERTIES";
            // 
            // addNewCategoToolStripMenuItem
            // 
            this.addNewCategoToolStripMenuItem.Name = "addNewCategoToolStripMenuItem";
            this.addNewCategoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewCategoToolStripMenuItem.Text = "Add New Category";
            this.addNewCategoToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 622);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Book Shop | Dashbord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aUTHORSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pUBLISHERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPublisherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem allBookInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSellInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllSellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookListReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSellsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoToolStripMenuItem;
    }
}

