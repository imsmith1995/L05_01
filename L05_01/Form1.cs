using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Defining variables to be used
            int baseCost = 25000;
            int windowsCost = 1000;
            int airCost = 1500;
            int chromeCost = 2000;
            int outputCost = baseCost;
            string outputString = string.Empty;

            //If statements modifying the total cost based upon check boxes.
            if (chkPowerWindows.Checked )
            {
                outputCost += windowsCost;
            }

            if (chkAirConditioning.Checked )
            {
                outputCost += airCost;
            }

            if (chkChrome.Checked )
            {
                outputCost += chromeCost;
            }

            //Displaying the total cost formatted as currency.
            outputString = outputCost.ToString("C");
            lblOutput.Text = outputString;

            //If statements ensuring user either checks or unchecks boxes.
            if (chkPowerWindows.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("you must make a choice for Power Windows",
                        "Missing Entry");
                return;
            }

            if (chkAirConditioning.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("you must make a choice for Air Conditioning",
                        "Missing Entry");
                return;
            }

            if (chkChrome.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("you must make a choice for Chrome",
                        "Missing Entry");
                return;
            }
        }
    }
}
