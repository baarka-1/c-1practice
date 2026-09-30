namespace assigment4
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
            this.lbtitle = new System.Windows.Forms.Label();
            this.lbcustomer = new System.Windows.Forms.Label();
            this.lblprevious = new System.Windows.Forms.Label();
            this.lblcurrent = new System.Windows.Forms.Label();
            this.lblunitprice = new System.Windows.Forms.Label();
            this.lblusage = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.txtcurrent = new System.Windows.Forms.TextBox();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.txtusage = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Location = new System.Drawing.Point(72, 38);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(155, 20);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "electriciybillcalculator";
            // 
            // lbcustomer
            // 
            this.lbcustomer.AutoSize = true;
            this.lbcustomer.Location = new System.Drawing.Point(75, 88);
            this.lbcustomer.Name = "lbcustomer";
            this.lbcustomer.Size = new System.Drawing.Size(152, 20);
            this.lbcustomer.TabIndex = 1;
            this.lbcustomer.Text = "entercustomername";
            // 
            // lblprevious
            // 
            this.lblprevious.AutoSize = true;
            this.lblprevious.Location = new System.Drawing.Point(84, 134);
            this.lblprevious.Name = "lblprevious";
            this.lblprevious.Size = new System.Drawing.Size(158, 20);
            this.lblprevious.TabIndex = 2;
            this.lblprevious.Text = "enterpreviousreading";
            // 
            // lblcurrent
            // 
            this.lblcurrent.AutoSize = true;
            this.lblcurrent.Location = new System.Drawing.Point(103, 177);
            this.lblcurrent.Name = "lblcurrent";
            this.lblcurrent.Size = new System.Drawing.Size(153, 20);
            this.lblcurrent.TabIndex = 3;
            this.lblcurrent.Text = "entercurrent reading";
            // 
            // lblunitprice
            // 
            this.lblunitprice.AutoSize = true;
            this.lblunitprice.Location = new System.Drawing.Point(84, 228);
            this.lblunitprice.Name = "lblunitprice";
            this.lblunitprice.Size = new System.Drawing.Size(129, 20);
            this.lblunitprice.TabIndex = 4;
            this.lblunitprice.Text = "enterpriceperunit";
            // 
            // lblusage
            // 
            this.lblusage.AutoSize = true;
            this.lblusage.Location = new System.Drawing.Point(103, 264);
            this.lblusage.Name = "lblusage";
            this.lblusage.Size = new System.Drawing.Size(156, 20);
            this.lblusage.TabIndex = 5;
            this.lblusage.Text = "electricity usageunits";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Location = new System.Drawing.Point(143, 307);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(84, 20);
            this.lbltax.TabIndex = 6;
            this.lbltax.Text = "taxamount";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(594, 32);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(100, 26);
            this.txtcustomer.TabIndex = 7;
            this.txtcustomer.TextChanged += new System.EventHandler(this.txtcustomer_TextChanged);
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(594, 81);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(100, 26);
            this.txtprevious.TabIndex = 8;
            // 
            // txtcurrent
            // 
            this.txtcurrent.Location = new System.Drawing.Point(594, 113);
            this.txtcurrent.Name = "txtcurrent";
            this.txtcurrent.Size = new System.Drawing.Size(100, 26);
            this.txtcurrent.TabIndex = 9;
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(594, 154);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(100, 26);
            this.txtunitprice.TabIndex = 10;
            this.txtunitprice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtusage
            // 
            this.txtusage.Location = new System.Drawing.Point(594, 197);
            this.txtusage.Name = "txtusage";
            this.txtusage.Size = new System.Drawing.Size(100, 26);
            this.txtusage.TabIndex = 11;
            this.txtusage.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(594, 229);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(100, 26);
            this.txttax.TabIndex = 12;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(594, 277);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 26);
            this.txttotal.TabIndex = 13;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(169, 344);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(58, 20);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "totalbill";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(382, 196);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(114, 85);
            this.btncalculate.TabIndex = 15;
            this.btncalculate.Text = "calculatebill";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.txtusage);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.txtcurrent);
            this.Controls.Add(this.txtprevious);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblusage);
            this.Controls.Add(this.lblunitprice);
            this.Controls.Add(this.lblcurrent);
            this.Controls.Add(this.lblprevious);
            this.Controls.Add(this.lbcustomer);
            this.Controls.Add(this.lbtitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label lbcustomer;
        private System.Windows.Forms.Label lblprevious;
        private System.Windows.Forms.Label lblcurrent;
        private System.Windows.Forms.Label lblunitprice;
        private System.Windows.Forms.Label lblusage;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.TextBox txtcurrent;
        private System.Windows.Forms.TextBox txtunitprice;
        private System.Windows.Forms.TextBox txtusage;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btncalculate;
    }
}

