using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

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
        double change;

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

        private void changeButton_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedInput.Text);
            change = tendered - total;
            changeOutputLabel.Text = $"{change.ToString("C")}";
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.receiptSound);
            player.Play();

            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text = $"\nPizza Palace Corp.  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nOrder Number 1593";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n October 17, 2021";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nPizza Slices x{numOfSlicesDesired} @{slices}  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nBread Sticks x{numOfBreadSticksDesired} @{breadSticks}  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nDrinks       x{numOfDrinksDesired} @{drinks}  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nSubtotal        {subTotal.ToString("C")}  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nTax            {tax.ToString("C")}  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nTotal           {total.ToString("C")}  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nTendered       {tendered.ToString("C")}";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nChange        {change.ToString("C")}";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\nEnjoy your meal!  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);
            receiptOutput.Text += $"\n  ";
            this.Refresh();
            Thread.Sleep(250);

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            numOfSlicesDesired = 0;
            numOfBreadSticksDesired = 0;
            numOfDrinksDesired = 0;

            pizzaSlicesInput.Text = $"";
            breadSticksInput.Text = $"";
            drinksInput.Text = $"";
            tenderedInput.Text = $"";

            subTotalOutput.Text = $"";
            taxOutputLabel.Text = $"";
            totalOutputLabel.Text = $"";
            changeOutputLabel.Text = $"";
            receiptOutput.Text = $"";



        }
    }
}
