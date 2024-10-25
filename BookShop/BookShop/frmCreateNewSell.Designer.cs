
namespace BookShop
{
    partial class frmCreateNewSell
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
            this.txtSellBookPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSellCustomer = new System.Windows.Forms.ComboBox();
            this.btnSaveSell = new System.Windows.Forms.Button();
            this.cmbSellBook = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtSelldateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtSellBookPrice
            // 
            this.txtSellBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellBookPrice.Location = new System.Drawing.Point(239, 248);
            this.txtSellBookPrice.Name = "txtSellBookPrice";
            this.txtSellBookPrice.Size = new System.Drawing.Size(251, 29);
            this.txtSellBookPrice.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(78, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "SELL PRICE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(86, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "SELL DATE:";
            // 
            // cmbSellCustomer
            // 
            this.cmbSellCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSellCustomer.FormattingEnabled = true;
            this.cmbSellCustomer.Location = new System.Drawing.Point(240, 116);
            this.cmbSellCustomer.Name = "cmbSellCustomer";
            this.cmbSellCustomer.Size = new System.Drawing.Size(251, 32);
            this.cmbSellCustomer.TabIndex = 48;
            // 
            // btnSaveSell
            // 
            this.btnSaveSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.btnSaveSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSell.ForeColor = System.Drawing.Color.White;
            this.btnSaveSell.Location = new System.Drawing.Point(239, 297);
            this.btnSaveSell.Name = "btnSaveSell";
            this.btnSaveSell.Size = new System.Drawing.Size(135, 37);
            this.btnSaveSell.TabIndex = 45;
            this.btnSaveSell.Text = "SAVE";
            this.btnSaveSell.UseVisualStyleBackColor = false;
            this.btnSaveSell.Click += new System.EventHandler(this.btnSaveSell_Click);
            // 
            // cmbSellBook
            // 
            this.cmbSellBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSellBook.FormattingEnabled = true;
            this.cmbSellBook.Location = new System.Drawing.Point(240, 162);
            this.cmbSellBook.Name = "cmbSellBook";
            this.cmbSellBook.Size = new System.Drawing.Size(251, 32);
            this.cmbSellBook.TabIndex = 42;
            this.cmbSellBook.SelectedIndexChanged += new System.EventHandler(this.cmbSellBook_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(82, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "BOOK NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "CUSTOMER:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(175, 29);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(308, 42);
            this.lblMsg.TabIndex = 41;
            this.lblMsg.Text = "ADD NEW SELL";
            // 
            // txtSelldateTimePicker
            // 
            this.txtSelldateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelldateTimePicker.Location = new System.Drawing.Point(239, 209);
            this.txtSelldateTimePicker.Name = "txtSelldateTimePicker";
            this.txtSelldateTimePicker.Size = new System.Drawing.Size(252, 20);
            this.txtSelldateTimePicker.TabIndex = 55;
            // 
            // frmCreateNewSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(628, 467);
            this.Controls.Add(this.txtSelldateTimePicker);
            this.Controls.Add(this.txtSellBookPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSellCustomer);
            this.Controls.Add(this.btnSaveSell);
            this.Controls.Add(this.cmbSellBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMsg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateNewSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Sell";
            this.Load += new System.EventHandler(this.frmCreateNewSell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSellBookPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSellCustomer;
        private System.Windows.Forms.Button btnSaveSell;
        private System.Windows.Forms.ComboBox cmbSellBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DateTimePicker txtSelldateTimePicker;
    }
}