namespace srevels1c1
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
            this.lblHotDogs = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHamburgers = new System.Windows.Forms.Label();
            this.txtHotDogs = new System.Windows.Forms.TextBox();
            this.txtHamburger = new System.Windows.Forms.TextBox();
            this.txtHDPrice = new System.Windows.Forms.TextBox();
            this.txtHBPrice = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.lblPretaxTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHDPrice = new System.Windows.Forms.Label();
            this.lblHBPrice = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHotDogs
            // 
            this.lblHotDogs.AutoSize = true;
            this.lblHotDogs.Location = new System.Drawing.Point(46, 26);
            this.lblHotDogs.Name = "lblHotDogs";
            this.lblHotDogs.Size = new System.Drawing.Size(55, 13);
            this.lblHotDogs.TabIndex = 0;
            this.lblHotDogs.Text = "Hot Dogs:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(34, 169);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(140, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblHamburgers
            // 
            this.lblHamburgers.AutoSize = true;
            this.lblHamburgers.Location = new System.Drawing.Point(46, 52);
            this.lblHamburgers.Name = "lblHamburgers";
            this.lblHamburgers.Size = new System.Drawing.Size(64, 13);
            this.lblHamburgers.TabIndex = 5;
            this.lblHamburgers.Text = "Hambugers:";
            // 
            // txtHotDogs
            // 
            this.txtHotDogs.Location = new System.Drawing.Point(107, 23);
            this.txtHotDogs.Name = "txtHotDogs";
            this.txtHotDogs.Size = new System.Drawing.Size(67, 20);
            this.txtHotDogs.TabIndex = 6;
            this.txtHotDogs.Text = "0";
            this.txtHotDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHotDogs.TextChanged += new System.EventHandler(this.TxtHotDogs_TextChanged);
            // 
            // txtHamburger
            // 
            this.txtHamburger.Location = new System.Drawing.Point(107, 49);
            this.txtHamburger.Name = "txtHamburger";
            this.txtHamburger.Size = new System.Drawing.Size(67, 20);
            this.txtHamburger.TabIndex = 7;
            this.txtHamburger.Text = "0";
            this.txtHamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHamburger.TextChanged += new System.EventHandler(this.TxtHamburger_TextChanged);
            // 
            // txtHDPrice
            // 
            this.txtHDPrice.Location = new System.Drawing.Point(244, 23);
            this.txtHDPrice.Name = "txtHDPrice";
            this.txtHDPrice.ReadOnly = true;
            this.txtHDPrice.Size = new System.Drawing.Size(75, 20);
            this.txtHDPrice.TabIndex = 8;
            this.txtHDPrice.TabStop = false;
            // 
            // txtHBPrice
            // 
            this.txtHBPrice.Location = new System.Drawing.Point(244, 49);
            this.txtHBPrice.Name = "txtHBPrice";
            this.txtHBPrice.ReadOnly = true;
            this.txtHBPrice.Size = new System.Drawing.Size(75, 20);
            this.txtHBPrice.TabIndex = 9;
            this.txtHBPrice.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(244, 101);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(75, 20);
            this.txtTax.TabIndex = 10;
            this.txtTax.TabStop = false;
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(244, 75);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.ReadOnly = true;
            this.txtPretaxTotal.Size = new System.Drawing.Size(75, 20);
            this.txtPretaxTotal.TabIndex = 11;
            this.txtPretaxTotal.TabStop = false;
            // 
            // lblPretaxTotal
            // 
            this.lblPretaxTotal.AutoSize = true;
            this.lblPretaxTotal.Location = new System.Drawing.Point(171, 78);
            this.lblPretaxTotal.Name = "lblPretaxTotal";
            this.lblPretaxTotal.Size = new System.Drawing.Size(67, 13);
            this.lblPretaxTotal.TabIndex = 13;
            this.lblPretaxTotal.Text = "Pretax Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(210, 104);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 14;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(203, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            // 
            // lblHDPrice
            // 
            this.lblHDPrice.AutoSize = true;
            this.lblHDPrice.Location = new System.Drawing.Point(180, 26);
            this.lblHDPrice.Name = "lblHDPrice";
            this.lblHDPrice.Size = new System.Drawing.Size(51, 13);
            this.lblHDPrice.TabIndex = 16;
            this.lblHDPrice.Text = "x $4.00 =";
            // 
            // lblHBPrice
            // 
            this.lblHBPrice.AutoSize = true;
            this.lblHBPrice.Location = new System.Drawing.Point(180, 52);
            this.lblHBPrice.Name = "lblHBPrice";
            this.lblHBPrice.Size = new System.Drawing.Size(51, 13);
            this.lblHBPrice.TabIndex = 17;
            this.lblHBPrice.Text = "x $5.00 =";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(244, 127);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(75, 20);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 255);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblHBPrice);
            this.Controls.Add(this.lblHDPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblPretaxTotal);
            this.Controls.Add(this.txtPretaxTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtHBPrice);
            this.Controls.Add(this.txtHDPrice);
            this.Controls.Add(this.txtHamburger);
            this.Controls.Add(this.txtHotDogs);
            this.Controls.Add(this.lblHamburgers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblHotDogs);
            this.Name = "Form1";
            this.Text = "srevels1c2: Food Truck v1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHotDogs;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHamburgers;
        private System.Windows.Forms.TextBox txtHotDogs;
        private System.Windows.Forms.TextBox txtHamburger;
        private System.Windows.Forms.TextBox txtHDPrice;
        private System.Windows.Forms.TextBox txtHBPrice;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.Label lblPretaxTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHDPrice;
        private System.Windows.Forms.Label lblHBPrice;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

