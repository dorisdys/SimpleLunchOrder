using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {
        //Price list

        const double HAMBURGER = 6.95;
        const double PIZZA = 5.95;
        const double SALAD = 4.95;
        const double HAM_ADDON = 0.75;
        const double PIZZA_ADDON = 0.5;
        const double SALAD_ADDON = 0.25;
        const double TAX = 0.05;

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            
            //calculate order price before tax
            double toPay = 0;
            if (radHamburger.Checked)
            {
                toPay += HAMBURGER;
                int checkedItems = CheckedBoxCounted();
                toPay += checkedItems * 0.75;
                txtSubtotal.Text = toPay.ToString("c");
            }
            else if (radPizza.Checked)
            {
                toPay += PIZZA;
                int checkedItems = CheckedBoxCounted();
                toPay += checkedItems * 0.5;
                txtSubtotal.Text = toPay.ToString("c");
            }

            else
            {
                toPay += SALAD;
                int checkedItems = CheckedBoxCounted();
                toPay += checkedItems * 0.25;
                txtSubtotal.Text = toPay.ToString("c");
            }


            //display tax and total price
            double tax = toPay*TAX;
            txtTax.Text = tax.ToString("c");

            double ordertotal = CalculateTotal(toPay, tax);
            txtOrderTotal.Text = ordertotal.ToString("c");
        }
        //calculate the total price
        private double CalculateTotal(double toPay, double tax)
        {
            double Total;
            Total = toPay + tax;
            return Total;
        }
        //count how many add-on items been selected
        private int CheckedBoxCounted()
        {
            int count = 0;
            foreach (Control c in grbHam.Controls)
            {
                CheckBox cb = c as CheckBox;
                if (cb != null && cb.Checked)
                    count++;
            }
            return count;
        }

     
        //clear button to reset the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            //reset the form
            radHamburger.Checked = true;

        }

        //method that clear the checkbox and textbox
        private void Clear()
        { 
            chkHam1.Checked = false;
            chkHam2.Checked = false;
            chkHam3.Checked = false;
            txtOrderTotal.Text = "";
            txtSubtotal.Text = "";
            txtTax.Text = "";
        }
        //exit the system
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //display the Hamburger menu
        private void radHamburger_CheckedChanged_1(object sender, EventArgs e)
        {
            Clear();
            grbHam.Text = "Add-on items($.75/each)";
            chkHam1.Text = "Lettuce, tomato, and onions";
            chkHam2.Text = "Ketchup, mustard, and mayo";
            chkHam3.Text = "French fries";
        }
        //display the Pizza menu
        private void radPizza_CheckedChanged_1(object sender, EventArgs e)
        {
            Clear();
            grbHam.Text = "Add-on items($.50/each)";
            chkHam1.Text = "Pepperoni";
            chkHam2.Text = "Sausage";
            chkHam3.Text = "Olives";

        }
        //display the Salad menu
        private void radSalad_CheckedChanged_1(object sender, EventArgs e)
        {
            Clear();
            grbHam.Text = "Add-on items($.25/each)";
            chkHam1.Text = "Croutons";
            chkHam2.Text = "Bacon bits";
            chkHam3.Text = "Bread sticks";
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
