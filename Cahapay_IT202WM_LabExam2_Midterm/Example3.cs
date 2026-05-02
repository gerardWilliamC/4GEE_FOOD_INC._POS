using Cahapay_IT202WM_LabExam2_Midterm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cahapay_IT202WM_LabExam2_Midterm
{
    public partial class Example3 : Form
    {
        public Example3()
        {
            InitializeComponent();
        }

        public double qty, price, discounted_amt, discount_amt;

        Price_Item_Value price_Item_Value = new Price_Item_Value();
        Variables1 variables1 = new Variables1();

        private void quantityTxtbox()
        {
            txtQty.Text = "0";
            txtQty.Focus();
        }



        private void foodradiobtn()
        {
            rbtnFBundleA.Checked = false;
            rbtnFBundleB.Checked = false;
        }

        private void GetPriceDiscountAmount()
        {
            txtPrice.Text = (price_Item_Value.GetPriceItem());
            txtDiscAmt.Text = (price_Item_Value.GetDiscountAmount());
            variables1.price= Convert.ToDouble(price_Item_Value.GetPriceItem());
        }

        private void quantity_price_convert()
        {
            if (txtQty.Text == "" || txtPrice.Text == "")
                throw new Exception("Empty input");

            variables1.qty = Convert.ToInt32(txtQty.Text);
            variables1.price = Convert.ToDouble(txtPrice.Text);
        }


        public void price_itemprice_item_textvalue(string discount_amt, string price)
        {
            txtDiscAmt.Text = discount_amt;
            txtPrice.Text = price;

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Example1_Load(object sender, EventArgs e)
        {

        }

        private void AddToListBox( string line)
        { 
            listBox1.Items.Add(line);
        }


        private void btnCalcBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    MessageBox.Show("Please clear the current transaction before calculating a new bill.");
                    return;
                }

                quantity_price_convert();

                // Compute and Validate quantity and price
                variables1.discount_amt = Convert.ToDouble(txtDiscAmt.Text);
                variables1.discounted_amt = (variables1.qty * variables1.price) - variables1.discount_amt;

                txtDiscountedAmt.Text = variables1.discounted_amt.ToString("n");
                txtTotalBill.Text = variables1.discounted_amt.ToString("n");


                variables1.cash_given = Convert.ToDouble(txtCashGiven.Text);

                if (variables1.cash_given < variables1.discounted_amt)
                {
                    MessageBox.Show("Cash given must be greater than or equal to the total bill.");
                    txtCashGiven.Focus();
                    return;
                }

                variables1.change = variables1.cash_given - variables1.discounted_amt;
                txtChange.Text = variables1.change.ToString("n");

                // Display summary and payment details in the ListBox
                AddToListBox("===== SUMMARY =====:");
                AddToListBox("");
                AddToListBox("Price: " + variables1.price.ToString("n"));
                AddToListBox("Quantity: " + variables1.qty);
                AddToListBox("Discount Amount: " + variables1.discount_amt.ToString("n"));
                AddToListBox("Total Bill: " + variables1.discounted_amt.ToString("n"));
                AddToListBox("");
                AddToListBox("===== PAYMENT =====:");
                AddToListBox("Cash Given: " + variables1.cash_given.ToString("n"));
                AddToListBox("Change: " + variables1.change.ToString("n"));

                // Total calculations
                variables1.qty_total += variables1.qty;
                variables1.discount_totalgiven += variables1.discount_amt;
                variables1.discounted_total += variables1.discounted_amt;

                txtTotalQty.Text = variables1.qty_total.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input.");
                quantityTxtbox();
            }
        }

        private void btnPrintTransac_Click(object sender, EventArgs e)
        {
            Example3_PrintReceipt receipt = new Example3_PrintReceipt(listBox1.Items);
            receipt.Show();
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            txtPrice.Clear();
            txtQty.Clear();
            txtDiscAmt.Clear();
            txtDiscountedAmt.Clear();
            txtTotalBill.Clear();
            txtCashGiven.Clear();
            txtChange.Clear();

            quantityTxtbox();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "500.99");   
            quantityTxtbox();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "550.00");
            quantityTxtbox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "600.99");
            quantityTxtbox();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "700.50");
            quantityTxtbox();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "500.00");
            quantityTxtbox();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "750.00");
            quantityTxtbox();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "650.50");
            quantityTxtbox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "700.00");
            quantityTxtbox();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "850.50");
            quantityTxtbox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "650.00");
            quantityTxtbox();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            price_itemprice_item_textvalue("0.00", "575.50");
            quantityTxtbox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            txtPrice.Clear();
            txtQty.Clear();
            txtDiscAmt.Clear();
            txtDiscountedAmt.Clear();
            txtTotalBill.Clear();
            txtCashGiven.Clear();
            txtChange.Clear();

            txtTotalQty.Clear();
            
            variables1.qty_total = 0;
            variables1.discount_totalgiven = 0;
            variables1.discounted_total = 0;

            quantityTxtbox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
