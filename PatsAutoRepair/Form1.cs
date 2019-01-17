/*
 * Name: Alyssa Bell
 * Date: 4/30/2017
 * Filename: PatsAutoRepair (Form1)
 * 
 * Purpose/Description: This program allows the user to enter the parts cost of a car repair job, and hours worked. 
 * It calculates the cost of labor based on the rate of $50/hr. The hourly cost is not taxed, but the parts are taxed
 * at 8%. The hourly rate and tax rate can be changed initially, and the program will output the updated results.
 * 
 * Error Checking: This program forces the user to enter values into each entry field. Messages are displayed if
 * any fields are left empty.
 * 
 * Assumptions: The user will only enter numerical values in for the calculations.
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
    public partial class Form1 : Form
    {
        string jobID = "";
        string custName = "";
        float partsCost = 0.00f;
        float laborHours = 0.00f;
        float hourlyLaborRate = 50.00f;
        float salesTaxPercent = 8.00f;
        const int decConversion = 100;
        float salesTaxDec = 0.00f;
        
        public Form1()
        {
            InitializeComponent();
            
        }


        private void calcBtn_Click(object sender, EventArgs e)
        {
            bool emptyField = false;

            if(jobIDTxtBx.Text == string.Empty)
            {
                MessageBox.Show("Please enter the job ID.");
                jobIDTxtBx.Focus();
                emptyField = true;
            }

            else if(custNameTxtBx.Text == string.Empty)
            {
                MessageBox.Show("Please enter the name of the customer.");
                custNameTxtBx.Focus();
                emptyField = true;

            }

            else if(partsCostTxtBx.Text == string.Empty)
            {
                MessageBox.Show("Please enter the cost of the parts.");
                partsCostTxtBx.Focus();
                emptyField = true;
            }

            else if(laborHoursTxtBx.Text == string.Empty)
            {
                MessageBox.Show("Please enter the hours of labor performed.");
                laborHoursTxtBx.Focus();
                emptyField = true;

            }

            else
            {
                emptyField = false;

                //storing info from text fields to variables
                jobID = jobIDTxtBx.Text;
                custName = custNameTxtBx.Text;
                partsCost = (float)decimal.Parse(partsCostTxtBx.Text);
                laborHours = (float)decimal.Parse(laborHoursTxtBx.Text);

                float totalCostLabor = (float)(laborHours * hourlyLaborRate);

                // calculations for Billing Info
                partsCostBInfo.Text = "$" + String.Format("{0:0.00}", partsCost);
                laborCostBInfo.Text = "$" + String.Format("{0:0.00}", (float)totalCostLabor);
                float subTotal = partsCost + totalCostLabor;
                subTotBInfo.Text = "$" + String.Format("{0:0.00}", subTotal);
                salesTaxDec = salesTaxPercent / decConversion;
                salesTaxDec = salesTaxDec * partsCost;
                salesTaxBInfo.Text = "$" + String.Format("{0:0.00}", salesTaxDec);
                float totalCostBilling = subTotal + salesTaxDec;
                totalBInfo.Text = "$" + String.Format("{0:0.00}", totalCostBilling);

               
                // open Form2 here and display same info. 
                Form2 summaryScreen = new Form2(this);
                summaryScreen.Show();
                summaryScreen.getTextValue(partsCostBInfo.Text, laborCostBInfo.Text, subTotBInfo.Text, salesTaxBInfo.Text, totalBInfo.Text);
                

            }

        }

       
        private void clearBtn_Click(object sender, EventArgs e)
        {
            jobIDTxtBx.Clear();
            custNameTxtBx.Clear();
            partsCostTxtBx.Clear();
            laborHoursTxtBx.Clear();


            partsCostBInfo.Text = "$0.00";
            laborCostBInfo.Text = "$0.00";
            subTotBInfo.Text = "$0.00";
            salesTaxBInfo.Text = "$0.00";
            totalBInfo.Text = "$0.00";

            jobIDTxtBx.Focus();

        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 summaryScreen2 = new Form2(this);
            summaryScreen2.Close();
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
