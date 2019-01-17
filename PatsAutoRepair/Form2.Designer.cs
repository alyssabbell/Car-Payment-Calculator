namespace PatsAutoRepair
{
    partial class Form2
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
            this.jobDateTxtLbl = new System.Windows.Forms.Label();
            this.partsTxtLbl = new System.Windows.Forms.Label();
            this.laborTxtLbl = new System.Windows.Forms.Label();
            this.subtotalTxtLbl = new System.Windows.Forms.Label();
            this.salesTaxTxtLbl = new System.Windows.Forms.Label();
            this.totalTxtLbl = new System.Windows.Forms.Label();
            this.okayBtn = new System.Windows.Forms.Button();
            this.receiptGrpBx = new System.Windows.Forms.GroupBox();
            this.totalSummary = new System.Windows.Forms.Label();
            this.salesTaxSummary = new System.Windows.Forms.Label();
            this.subtotalSummary = new System.Windows.Forms.Label();
            this.laborCostSummary = new System.Windows.Forms.Label();
            this.partsCostSummary = new System.Windows.Forms.Label();
            this.jobDateSummary = new System.Windows.Forms.Label();
            this.receiptGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobDateTxtLbl
            // 
            this.jobDateTxtLbl.AutoSize = true;
            this.jobDateTxtLbl.Location = new System.Drawing.Point(9, 29);
            this.jobDateTxtLbl.Name = "jobDateTxtLbl";
            this.jobDateTxtLbl.Size = new System.Drawing.Size(53, 13);
            this.jobDateTxtLbl.TabIndex = 0;
            this.jobDateTxtLbl.Text = "Job Date:";
            // 
            // partsTxtLbl
            // 
            this.partsTxtLbl.AutoSize = true;
            this.partsTxtLbl.Location = new System.Drawing.Point(9, 62);
            this.partsTxtLbl.Name = "partsTxtLbl";
            this.partsTxtLbl.Size = new System.Drawing.Size(34, 13);
            this.partsTxtLbl.TabIndex = 1;
            this.partsTxtLbl.Text = "Parts:";
            // 
            // laborTxtLbl
            // 
            this.laborTxtLbl.AutoSize = true;
            this.laborTxtLbl.Location = new System.Drawing.Point(9, 100);
            this.laborTxtLbl.Name = "laborTxtLbl";
            this.laborTxtLbl.Size = new System.Drawing.Size(37, 13);
            this.laborTxtLbl.TabIndex = 2;
            this.laborTxtLbl.Text = "Labor:";
            // 
            // subtotalTxtLbl
            // 
            this.subtotalTxtLbl.AutoSize = true;
            this.subtotalTxtLbl.Location = new System.Drawing.Point(9, 135);
            this.subtotalTxtLbl.Name = "subtotalTxtLbl";
            this.subtotalTxtLbl.Size = new System.Drawing.Size(49, 13);
            this.subtotalTxtLbl.TabIndex = 3;
            this.subtotalTxtLbl.Text = "Subtotal:";
            // 
            // salesTaxTxtLbl
            // 
            this.salesTaxTxtLbl.AutoSize = true;
            this.salesTaxTxtLbl.Location = new System.Drawing.Point(9, 169);
            this.salesTaxTxtLbl.Name = "salesTaxTxtLbl";
            this.salesTaxTxtLbl.Size = new System.Drawing.Size(57, 13);
            this.salesTaxTxtLbl.TabIndex = 4;
            this.salesTaxTxtLbl.Text = "Sales Tax:";
            // 
            // totalTxtLbl
            // 
            this.totalTxtLbl.AutoSize = true;
            this.totalTxtLbl.Location = new System.Drawing.Point(9, 210);
            this.totalTxtLbl.Name = "totalTxtLbl";
            this.totalTxtLbl.Size = new System.Drawing.Size(34, 13);
            this.totalTxtLbl.TabIndex = 5;
            this.totalTxtLbl.Text = "Total:";
            // 
            // okayBtn
            // 
            this.okayBtn.Location = new System.Drawing.Point(71, 268);
            this.okayBtn.Name = "okayBtn";
            this.okayBtn.Size = new System.Drawing.Size(144, 32);
            this.okayBtn.TabIndex = 12;
            this.okayBtn.Text = "Okay";
            this.okayBtn.UseVisualStyleBackColor = true;
            this.okayBtn.Click += new System.EventHandler(this.okayBtn_Click);
            // 
            // receiptGrpBx
            // 
            this.receiptGrpBx.Controls.Add(this.totalSummary);
            this.receiptGrpBx.Controls.Add(this.salesTaxSummary);
            this.receiptGrpBx.Controls.Add(this.subtotalSummary);
            this.receiptGrpBx.Controls.Add(this.laborCostSummary);
            this.receiptGrpBx.Controls.Add(this.partsCostSummary);
            this.receiptGrpBx.Controls.Add(this.jobDateSummary);
            this.receiptGrpBx.Controls.Add(this.totalTxtLbl);
            this.receiptGrpBx.Controls.Add(this.salesTaxTxtLbl);
            this.receiptGrpBx.Controls.Add(this.subtotalTxtLbl);
            this.receiptGrpBx.Controls.Add(this.laborTxtLbl);
            this.receiptGrpBx.Controls.Add(this.partsTxtLbl);
            this.receiptGrpBx.Controls.Add(this.jobDateTxtLbl);
            this.receiptGrpBx.Location = new System.Drawing.Point(12, 12);
            this.receiptGrpBx.Name = "receiptGrpBx";
            this.receiptGrpBx.Size = new System.Drawing.Size(263, 237);
            this.receiptGrpBx.TabIndex = 13;
            this.receiptGrpBx.TabStop = false;
            // 
            // totalSummary
            // 
            this.totalSummary.AutoSize = true;
            this.totalSummary.Location = new System.Drawing.Point(192, 210);
            this.totalSummary.Name = "totalSummary";
            this.totalSummary.Size = new System.Drawing.Size(13, 13);
            this.totalSummary.TabIndex = 11;
            this.totalSummary.Text = "0";
            this.totalSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxSummary
            // 
            this.salesTaxSummary.AutoSize = true;
            this.salesTaxSummary.Location = new System.Drawing.Point(192, 169);
            this.salesTaxSummary.Name = "salesTaxSummary";
            this.salesTaxSummary.Size = new System.Drawing.Size(13, 13);
            this.salesTaxSummary.TabIndex = 10;
            this.salesTaxSummary.Text = "0";
            this.salesTaxSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalSummary
            // 
            this.subtotalSummary.AutoSize = true;
            this.subtotalSummary.Location = new System.Drawing.Point(192, 135);
            this.subtotalSummary.Name = "subtotalSummary";
            this.subtotalSummary.Size = new System.Drawing.Size(13, 13);
            this.subtotalSummary.TabIndex = 9;
            this.subtotalSummary.Text = "0";
            // 
            // laborCostSummary
            // 
            this.laborCostSummary.AutoSize = true;
            this.laborCostSummary.Location = new System.Drawing.Point(192, 100);
            this.laborCostSummary.Name = "laborCostSummary";
            this.laborCostSummary.Size = new System.Drawing.Size(13, 13);
            this.laborCostSummary.TabIndex = 8;
            this.laborCostSummary.Text = "0";
            this.laborCostSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsCostSummary
            // 
            this.partsCostSummary.AutoSize = true;
            this.partsCostSummary.Location = new System.Drawing.Point(192, 62);
            this.partsCostSummary.Name = "partsCostSummary";
            this.partsCostSummary.Size = new System.Drawing.Size(13, 13);
            this.partsCostSummary.TabIndex = 7;
            this.partsCostSummary.Text = "0";
            this.partsCostSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jobDateSummary
            // 
            this.jobDateSummary.AutoSize = true;
            this.jobDateSummary.Location = new System.Drawing.Point(177, 27);
            this.jobDateSummary.Name = "jobDateSummary";
            this.jobDateSummary.Size = new System.Drawing.Size(28, 13);
            this.jobDateSummary.TabIndex = 6;
            this.jobDateSummary.Text = "date";
            this.jobDateSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 329);
            this.Controls.Add(this.receiptGrpBx);
            this.Controls.Add(this.okayBtn);
            this.Name = "Form2";
            this.Text = "Summary";
            this.receiptGrpBx.ResumeLayout(false);
            this.receiptGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label jobDateTxtLbl;
        private System.Windows.Forms.Label partsTxtLbl;
        private System.Windows.Forms.Label laborTxtLbl;
        private System.Windows.Forms.Label subtotalTxtLbl;
        private System.Windows.Forms.Label salesTaxTxtLbl;
        private System.Windows.Forms.Label totalTxtLbl;
        private System.Windows.Forms.Button okayBtn;
        private System.Windows.Forms.GroupBox receiptGrpBx;
        private System.Windows.Forms.Label subtotalSummary;
        private System.Windows.Forms.Label laborCostSummary;
        private System.Windows.Forms.Label partsCostSummary;
        private System.Windows.Forms.Label jobDateSummary;
        private System.Windows.Forms.Label totalSummary;
        private System.Windows.Forms.Label salesTaxSummary;
    }
}