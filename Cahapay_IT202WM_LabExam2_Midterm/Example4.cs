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
    public partial class Example4 : Form
    {
        public Example4()
        {
            InitializeComponent();
        }

        Price_Item_Value price_Item_Value = new Price_Item_Value();
        Variables1 variables1 = new Variables1();

        private void displayTxtbox(string itemname, string price)
        {
            txtItemName.Text = itemname;
            txtPrice.Text = price;
        }

        private void quantityTxtbox()
        {
            txtQty.Clear();
            txtQty.Focus();
        }

        private void GetPriceItemValue()
        {
            txtItemName.Text = (price_Item_Value.GetItemName());
            txtPrice.Text = (price_Item_Value.GetPrice());
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal B", "120.50");
            price_Item_Value.SetPriceItemValue("Meal B", "120.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal C", "88.50");
            price_Item_Value.SetPriceItemValue("Meal C", "88.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal 2", "120.50");
            price_Item_Value.SetPriceItemValue("Meal 2", "120.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void Example4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // displayTxtbox("Meal A", "90.50");
            price_Item_Value.SetPriceItemValue("Meal A", "90.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal D", "100.50");
            price_Item_Value.SetPriceItemValue("Meal D", "100.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal 1", "95.00"); 
            price_Item_Value.SetPriceItemValue("Meal 1", "95.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
           // displayTxtbox("Meal 3", "120.50");
            price_Item_Value.SetPriceItemValue("Meal 3", "120.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal 4", "120.50");
            price_Item_Value.SetPriceItemValue("Meal 4", "120.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Combo A", "120.50");
            price_Item_Value.SetPriceItemValue("Meal Combo A", "120.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Budget A", "110");
            price_Item_Value.SetPriceItemValue("Meal Budget A", "110");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Combo D", "220.50");
            price_Item_Value.SetPriceItemValue("Meal Combo D", "220.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           // displayTxtbox("Meal Solo A", "190.50");
            price_Item_Value.SetPriceItemValue("Meal Solo A", "190.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Double A", "220.50");
            price_Item_Value.SetPriceItemValue("Meal Double A", "220.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
           // displayTxtbox("Meal Couple A", "100.99");
           price_Item_Value.SetPriceItemValue("Meal Couple A", "100.99");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Fiend A", "129.70");
            price_Item_Value.SetPriceItemValue("Meal Friend A", "129.70");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Combo D", "220.50");
            price_Item_Value.SetPriceItemValue("Meal Combo D", "220.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
           // displayTxtbox("Meal Solo A", "190.50");
            price_Item_Value.SetPriceItemValue("Meal Solo A", "190.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Double A", "220.50");
            price_Item_Value.SetPriceItemValue("Meal Double A", "220.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Couple A", "100.99");
            price_Item_Value.SetPriceItemValue("Meal Couple A", "100.99");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //displayTxtbox("Meal Friend A", "129.70");
            price_Item_Value.SetPriceItemValue("Meal Friend A", "129.70");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                variables1.amount_paid = Convert.ToDouble(txtAmtPaid.Text);
                variables1.cash_given = Convert.ToDouble(txtCashGiven.Text);

                if (variables1.cash_given < variables1.amount_paid)
                {
                    MessageBox.Show("Insufficient Cash Given!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCashGiven.Clear();
                    txtCashGiven.Focus();
                    return;
                }
                variables1.change = variables1.cash_given - variables1.amount_paid;
                txtChange.Text = variables1.change.ToString("c");
                txtAmtPaid.Text = variables1.amount_paid.ToString("c");
                txtCashGiven.Text = variables1.cash_given.ToString("c");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number for Cash Given.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCashGiven.Clear();
                txtCashGiven.Focus();
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            variables1.price = Convert.ToDouble(txtPrice.Text);
            variables1.qty = Convert.ToInt32(txtQty.Text);
            variables1.amount_paid = variables1.price * variables1.qty;
            txtAmtPaid.Text = variables1.amount_paid.ToString("n");
            txtCashGiven.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAmtPaid.Clear();
            txtPrice.Clear();
            txtCashGiven.Clear();
            txtChange.Clear();
            txtItemName.Clear();

            txtCashGiven.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
