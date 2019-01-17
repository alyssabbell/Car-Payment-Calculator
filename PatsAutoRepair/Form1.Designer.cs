namespace PatsAutoRepair
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.jobIDTxtLbl = new System.Windows.Forms.Label();
            this.custNameTxtLbl = new System.Windows.Forms.Label();
            this.partsCostTxTLbl = new System.Windows.Forms.Label();
            this.hoursLaborTxtLbl = new System.Windows.Forms.Label();
            this.jobIDTxtBx = new System.Windows.Forms.TextBox();
            this.custNameTxtBx = new System.Windows.Forms.TextBox();
            this.partsCostTxtBx = new System.Windows.Forms.TextBox();
            this.laborHoursTxtBx = new System.Windows.Forms.TextBox();
            this.JobInfoGrpBx = new System.Windows.Forms.GroupBox();
            this.partsInfoTxtLbl = new System.Windows.Forms.Label();
            this.laborInfoTxtLbl = new System.Windows.Forms.Label();
            this.subtotalTxtLbl = new System.Windows.Forms.Label();
            this.salesTaxInfoTxtLbl = new System.Windows.Forms.Label();
            this.totalInfoTxtLbl = new System.Windows.Forms.Label();
            this.billingInfoGrpBox = new System.Windows.Forms.GroupBox();
            this.totalBInfo = new System.Windows.Forms.Label();
            this.salesTaxBInfo = new System.Windows.Forms.Label();
            this.subTotBInfo = new System.Windows.Forms.Label();
            this.laborCostBInfo = new System.Windows.Forms.Label();
            this.partsCostBInfo = new System.Windows.Forms.Label();
            this.JobInfoGrpBx.SuspendLayout();
            this.billingInfoGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(52, 251);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(128, 38);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(234, 251);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(141, 37);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(424, 251);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(121, 36);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // jobIDTxtLbl
            // 
            this.jobIDTxtLbl.AutoSize = true;
            this.jobIDTxtLbl.Location = new System.Drawing.Point(22, 39);
            this.jobIDTxtLbl.Name = "jobIDTxtLbl";
            this.jobIDTxtLbl.Size = new System.Drawing.Size(41, 13);
            this.jobIDTxtLbl.TabIndex = 3;
            this.jobIDTxtLbl.Text = "Job ID:";
            // 
            // custNameTxtLbl
            // 
            this.custNameTxtLbl.AutoSize = true;
            this.custNameTxtLbl.Location = new System.Drawing.Point(21, 71);
            this.custNameTxtLbl.Name = "custNameTxtLbl";
            this.custNameTxtLbl.Size = new System.Drawing.Size(85, 13);
            this.custNameTxtLbl.TabIndex = 4;
            this.custNameTxtLbl.Text = "Customer Name:";
            // 
            // partsCostTxTLbl
            // 
            this.partsCostTxTLbl.AutoSize = true;
            this.partsCostTxTLbl.Location = new System.Drawing.Point(21, 105);
            this.partsCostTxTLbl.Name = "partsCostTxTLbl";
            this.partsCostTxTLbl.Size = new System.Drawing.Size(69, 13);
            this.partsCostTxTLbl.TabIndex = 5;
            this.partsCostTxTLbl.Text = "Cost of parts:";
            // 
            // hoursLaborTxtLbl
            // 
            this.hoursLaborTxtLbl.AutoSize = true;
            this.hoursLaborTxtLbl.Location = new System.Drawing.Point(22, 140);
            this.hoursLaborTxtLbl.Name = "hoursLaborTxtLbl";
            this.hoursLaborTxtLbl.Size = new System.Drawing.Size(76, 13);
            this.hoursLaborTxtLbl.TabIndex = 6;
            this.hoursLaborTxtLbl.Text = "Hours of labor:";
            // 
            // jobIDTxtBx
            // 
            this.jobIDTxtBx.Location = new System.Drawing.Point(120, 29);
            this.jobIDTxtBx.Name = "jobIDTxtBx";
            this.jobIDTxtBx.Size = new System.Drawing.Size(126, 20);
            this.jobIDTxtBx.TabIndex = 1;
            // 
            // custNameTxtBx
            // 
            this.custNameTxtBx.Location = new System.Drawing.Point(118, 65);
            this.custNameTxtBx.Name = "custNameTxtBx";
            this.custNameTxtBx.Size = new System.Drawing.Size(127, 20);
            this.custNameTxtBx.TabIndex = 2;
            // 
            // partsCostTxtBx
            // 
            this.partsCostTxtBx.Location = new System.Drawing.Point(118, 99);
            this.partsCostTxtBx.Name = "partsCostTxtBx";
            this.partsCostTxtBx.Size = new System.Drawing.Size(126, 20);
            this.partsCostTxtBx.TabIndex = 3;
            // 
            // laborHoursTxtBx
            // 
            this.laborHoursTxtBx.Location = new System.Drawing.Point(119, 135);
            this.laborHoursTxtBx.Name = "laborHoursTxtBx";
            this.laborHoursTxtBx.Size = new System.Drawing.Size(126, 20);
            this.laborHoursTxtBx.TabIndex = 4;
            // 
            // JobInfoGrpBx
            // 
            this.JobInfoGrpBx.Controls.Add(this.laborHoursTxtBx);
            this.JobInfoGrpBx.Controls.Add(this.partsCostTxtBx);
            this.JobInfoGrpBx.Controls.Add(this.custNameTxtBx);
            this.JobInfoGrpBx.Controls.Add(this.jobIDTxtBx);
            this.JobInfoGrpBx.Controls.Add(this.hoursLaborTxtLbl);
            this.JobInfoGrpBx.Controls.Add(this.partsCostTxTLbl);
            this.JobInfoGrpBx.Controls.Add(this.custNameTxtLbl);
            this.JobInfoGrpBx.Controls.Add(this.jobIDTxtLbl);
            this.JobInfoGrpBx.Location = new System.Drawing.Point(37, 42);
            this.JobInfoGrpBx.Name = "JobInfoGrpBx";
            this.JobInfoGrpBx.Size = new System.Drawing.Size(287, 190);
            this.JobInfoGrpBx.TabIndex = 11;
            this.JobInfoGrpBx.TabStop = false;
            this.JobInfoGrpBx.Text = "Job Information";
            // 
            // partsInfoTxtLbl
            // 
            this.partsInfoTxtLbl.AutoSize = true;
            this.partsInfoTxtLbl.Location = new System.Drawing.Point(16, 33);
            this.partsInfoTxtLbl.Name = "partsInfoTxtLbl";
            this.partsInfoTxtLbl.Size = new System.Drawing.Size(34, 13);
            this.partsInfoTxtLbl.TabIndex = 12;
            this.partsInfoTxtLbl.Text = "Parts:";
            // 
            // laborInfoTxtLbl
            // 
            this.laborInfoTxtLbl.AutoSize = true;
            this.laborInfoTxtLbl.Location = new System.Drawing.Point(17, 59);
            this.laborInfoTxtLbl.Name = "laborInfoTxtLbl";
            this.laborInfoTxtLbl.Size = new System.Drawing.Size(34, 13);
            this.laborInfoTxtLbl.TabIndex = 14;
            this.laborInfoTxtLbl.Text = "Labor";
            // 
            // subtotalTxtLbl
            // 
            this.subtotalTxtLbl.AutoSize = true;
            this.subtotalTxtLbl.Location = new System.Drawing.Point(16, 86);
            this.subtotalTxtLbl.Name = "subtotalTxtLbl";
            this.subtotalTxtLbl.Size = new System.Drawing.Size(49, 13);
            this.subtotalTxtLbl.TabIndex = 15;
            this.subtotalTxtLbl.Text = "Subtotal:";
            // 
            // salesTaxInfoTxtLbl
            // 
            this.salesTaxInfoTxtLbl.AutoSize = true;
            this.salesTaxInfoTxtLbl.Location = new System.Drawing.Point(17, 112);
            this.salesTaxInfoTxtLbl.Name = "salesTaxInfoTxtLbl";
            this.salesTaxInfoTxtLbl.Size = new System.Drawing.Size(57, 13);
            this.salesTaxInfoTxtLbl.TabIndex = 16;
            this.salesTaxInfoTxtLbl.Text = "Sales Tax:";
            // 
            // totalInfoTxtLbl
            // 
            this.totalInfoTxtLbl.AutoSize = true;
            this.totalInfoTxtLbl.Location = new System.Drawing.Point(17, 137);
            this.totalInfoTxtLbl.Name = "totalInfoTxtLbl";
            this.totalInfoTxtLbl.Size = new System.Drawing.Size(34, 13);
            this.totalInfoTxtLbl.TabIndex = 17;
            this.totalInfoTxtLbl.Text = "Total:";
            // 
            // billingInfoGrpBox
            // 
            this.billingInfoGrpBox.Controls.Add(this.totalBInfo);
            this.billingInfoGrpBox.Controls.Add(this.salesTaxBInfo);
            this.billingInfoGrpBox.Controls.Add(this.subTotBInfo);
            this.billingInfoGrpBox.Controls.Add(this.laborCostBInfo);
            this.billingInfoGrpBox.Controls.Add(this.partsCostBInfo);
            this.billingInfoGrpBox.Controls.Add(this.totalInfoTxtLbl);
            this.billingInfoGrpBox.Controls.Add(this.salesTaxInfoTxtLbl);
            this.billingInfoGrpBox.Controls.Add(this.subtotalTxtLbl);
            this.billingInfoGrpBox.Controls.Add(this.laborInfoTxtLbl);
            this.billingInfoGrpBox.Controls.Add(this.partsInfoTxtLbl);
            this.billingInfoGrpBox.Location = new System.Drawing.Point(346, 48);
            this.billingInfoGrpBox.Name = "billingInfoGrpBox";
            this.billingInfoGrpBox.Size = new System.Drawing.Size(198, 183);
            this.billingInfoGrpBox.TabIndex = 18;
            this.billingInfoGrpBox.TabStop = false;
            this.billingInfoGrpBox.Text = "Billing Info:";
            // 
            // totalBInfo
            // 
            this.totalBInfo.AutoSize = true;
            this.totalBInfo.Location = new System.Drawing.Point(126, 136);
            this.totalBInfo.Name = "totalBInfo";
            this.totalBInfo.Size = new System.Drawing.Size(34, 13);
            this.totalBInfo.TabIndex = 22;
            this.totalBInfo.Text = "$0.00";
            this.totalBInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesTaxBInfo
            // 
            this.salesTaxBInfo.AutoSize = true;
            this.salesTaxBInfo.Location = new System.Drawing.Point(126, 110);
            this.salesTaxBInfo.Name = "salesTaxBInfo";
            this.salesTaxBInfo.Size = new System.Drawing.Size(34, 13);
            this.salesTaxBInfo.TabIndex = 21;
            this.salesTaxBInfo.Text = "$0.00";
            this.salesTaxBInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subTotBInfo
            // 
            this.subTotBInfo.AutoSize = true;
            this.subTotBInfo.Location = new System.Drawing.Point(126, 84);
            this.subTotBInfo.Name = "subTotBInfo";
            this.subTotBInfo.Size = new System.Drawing.Size(34, 13);
            this.subTotBInfo.TabIndex = 20;
            this.subTotBInfo.Text = "$0.00";
            this.subTotBInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laborCostBInfo
            // 
            this.laborCostBInfo.AutoSize = true;
            this.laborCostBInfo.Location = new System.Drawing.Point(126, 59);
            this.laborCostBInfo.Name = "laborCostBInfo";
            this.laborCostBInfo.Size = new System.Drawing.Size(34, 13);
            this.laborCostBInfo.TabIndex = 19;
            this.laborCostBInfo.Text = "$0.00";
            this.laborCostBInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsCostBInfo
            // 
            this.partsCostBInfo.AutoSize = true;
            this.partsCostBInfo.Location = new System.Drawing.Point(126, 33);
            this.partsCostBInfo.Name = "partsCostBInfo";
            this.partsCostBInfo.Size = new System.Drawing.Size(34, 13);
            this.partsCostBInfo.TabIndex = 18;
            this.partsCostBInfo.Text = "$0.00";
            this.partsCostBInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 330);
            this.Controls.Add(this.billingInfoGrpBox);
            this.Controls.Add(this.JobInfoGrpBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBtn);
            this.Name = "Form1";
            this.Text = "Pat\'s Auto Repair Shop - Job Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.JobInfoGrpBx.ResumeLayout(false);
            this.JobInfoGrpBx.PerformLayout();
            this.billingInfoGrpBox.ResumeLayout(false);
            this.billingInfoGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label jobIDTxtLbl;
        private System.Windows.Forms.Label custNameTxtLbl;
        private System.Windows.Forms.Label partsCostTxTLbl;
        private System.Windows.Forms.Label hoursLaborTxtLbl;
        private System.Windows.Forms.TextBox jobIDTxtBx;
        private System.Windows.Forms.TextBox custNameTxtBx;
        private System.Windows.Forms.TextBox partsCostTxtBx;
        private System.Windows.Forms.TextBox laborHoursTxtBx;
        private System.Windows.Forms.GroupBox JobInfoGrpBx;
        private System.Windows.Forms.Label partsInfoTxtLbl;
        private System.Windows.Forms.Label laborInfoTxtLbl;
        private System.Windows.Forms.Label subtotalTxtLbl;
        private System.Windows.Forms.Label salesTaxInfoTxtLbl;
        private System.Windows.Forms.Label totalInfoTxtLbl;
        private System.Windows.Forms.GroupBox billingInfoGrpBox;
        private System.Windows.Forms.Label totalBInfo;
        private System.Windows.Forms.Label salesTaxBInfo;
        private System.Windows.Forms.Label subTotBInfo;
        private System.Windows.Forms.Label laborCostBInfo;
        private System.Windows.Forms.Label partsCostBInfo;
    }
}

