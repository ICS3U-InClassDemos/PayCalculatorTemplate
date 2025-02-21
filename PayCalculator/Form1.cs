using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                double taxRate = 0.2;

                //get inputs
                double hours = Convert.ToDouble(hoursInput.Text);
                double rate = Convert.ToDouble(payRateInput.Text);

                //calcuations
                double pretax = rate * hours;
                double taxAmount = pretax * taxRate;
                double netPay = pretax - taxAmount;

                //output
                pretaxOutput.Text = $"{pretax.ToString("$##.00")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                earnedOutput.Text = $"{netPay.ToString("C")}";
            }
            catch 
            {
                pretaxOutput.Text = "";
                taxOutput.Text = "";
                earnedOutput.Text = "ERROR!!!!";
            }
        }
    }
}
