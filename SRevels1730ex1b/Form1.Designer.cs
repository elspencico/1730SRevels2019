namespace SRevels1730ex1b
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
            this.Subtoatal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Subtoatal
            // 
            this.Subtoatal.AutoSize = true;
            this.Subtoatal.Location = new System.Drawing.Point(42, 41);
            this.Subtoatal.Name = "Subtoatal";
            this.Subtoatal.Size = new System.Drawing.Size(49, 13);
            this.Subtoatal.TabIndex = 5;
            this.Subtoatal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(140, 34);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(150, 20);
            this.txtSubtotal.TabIndex = 0;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.TxtSubtotal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Discount Percent:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(140, 72);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(150, 20);
            this.txtDiscountPercent.TabIndex = 1;
            this.txtDiscountPercent.Text = "5";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(140, 107);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(150, 20);
            this.txtDiscountAmount.TabIndex = 9;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.TxtDiscountAmount_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(140, 140);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(117, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(74, 27);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(216, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 259);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.Subtoatal);
            this.Name = "Form1";
            this.Text = "srevels1b1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Subtoatal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

