using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashV2
{
    public partial class Form1 : Form
    {
        double slices = 2.75;
        double numOfSlicesDesired;
       
        double breadSticks = 1.75;
        double numOfBreadSticksDesired;
       
        double drinks = 1.25;
        double numOfDrinksDesired;

        double subTotal;
        double total;
        double tax;
        double taxRate = 0.13;

        double tendered; 

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            numOfSlicesDesired = Convert.ToDouble(pizzaSlicesInput.Text);
            numOfBreadSticksDesired = Convert.ToDouble(breadSticksInput.Text);
            numOfDrinksDesired = Convert.ToDouble(drinksInput.Text);

            subTotal = numOfSlicesDesired * slices + numOfBreadSticksDesired * breadSticks + numOfDrinksDesired * drinks;
            tax = subTotal * taxRate;
            total = subTotal + tax;
            
            subTotalOutput.Text = $"{subTotal.ToString("C")}";
            taxOutputLabel.Text = $"{tax.ToString("C")}";
            totalOutputLabel.Text = $"{total.ToString("C")}";


        }
    }
}
