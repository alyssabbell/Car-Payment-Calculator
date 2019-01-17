/*
 * Name: Alyssa Bell
 * Date: 4/30/2017
 * Filename: PatsAutoRepair (Form2)
 * 
 * Purpose/Description: This form inherits the the Summary info from Form1 and displays the same results as well as the 
 * current date. It acts as a receipt for the repairs completed.
 * 
 * Error Checking: None
 * 
 * Assumptions: None
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PatsAutoRepair
{
    public partial class Form2 : Form
    {
        Form mainForm;

        string todaysDate = DateTime.Now.ToString("MM/dd/yyyy");
       

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 parent)
        {
            InitializeComponent();
            mainForm = parent;
            jobDateSummary.Text = todaysDate;
            Form1 jobInfomation = new Form1();
         
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        public void getTextValue(string partsCost, string laborCost, string subtotal, string salesTax, string total)
        {
            partsCostSummary.Text = partsCost;
            laborCostSummary.Text = laborCost;
            subtotalSummary.Text = subtotal;
            salesTaxSummary.Text = salesTax;
            totalSummary.Text = total;
        }

    }
}
