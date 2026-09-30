using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            try
            {
                // Creating Variables
                string customerName;
                double previousReading, currentReading, pricePerUnit, electricityUsage,
                       electricityCharge, taxAmount, totalBill;

                // Constant Variables
                const double taxPercentage = 0.07;
                const double fixedCharge = 5;

                // Assigning Variables
                customerName = txtname.Text;
                previousReading = double.Parse(txtprevious.Text);
                currentReading = double.Parse(txtcurren.Text);
                pricePerUnit = double.Parse(txtprice.Text);

                // Calculating Electricity Usage
                electricityUsage = currentReading - previousReading;

                // Calculating Electricity Charge
                electricityCharge = electricityUsage * pricePerUnit;

                // Calculating Tax Amount
                taxAmount = electricityCharge * taxPercentage;

                // Calculating Total Bill
                totalBill = electricityCharge + taxAmount + fixedCharge;

                // Displaying Results
                usage.Text = electricityUsage.ToString("0");
                tax.Text = "$" + taxAmount.ToString("0.00");
                total.Text = "$" + totalBill.ToString("0.00");
            }
            catch {
                MessageBox.Show("plz try again invalid error");
            }
        }

       

        private void tax_Click(object sender, EventArgs e)
        {

        }

        private void usage_Click(object sender, EventArgs e)
        {

        }

        private void ldltotal_Click(object sender, EventArgs e)
        {

        }

        private void ldlt_Click(object sender, EventArgs e)
        {

        }

        private void ldlss_Click(object sender, EventArgs e)
        {

        }

        private void ldlc_Click(object sender, EventArgs e)
        {

        }

        private void ldl_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcurren_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprevious_TextChanged(object sender, EventArgs e)
        {

        }

        private void ldlprice_Click(object sender, EventArgs e)
        {

        }

        private void ldlcurrent_Click(object sender, EventArgs e)
        {

        }

        private void ldlreading_Click(object sender, EventArgs e)
        {

        }

        private void ldlenter_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }
    }
}
