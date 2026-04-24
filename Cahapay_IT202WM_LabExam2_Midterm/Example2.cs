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
    public partial class Example2 : Form
    {
        public Example2()
        {
            InitializeComponent();
        }


        public double qty, price, discounted_amt, discount_amt;

        Price_Item_Value price_Item_Value = new Price_Item_Value();
        Variables1 variables1 = new Variables1();


        private void KeypadInput(string value)
        {
            txtCashRend.Text += value;
        }


        private void quantityTxtbox()
        {
            txtQty.Clear();
            txtQty.Focus();
        }

        private void quantity_price_convert()
        {
            if (txtQty.Text == "" || txtPrice.Text == "")
                throw new Exception("Empty input");

            variables1.qty = Convert.ToInt32(txtQty.Text);
            variables1.price = Convert.ToDouble(txtPrice.Text);
        }


        /** public void price_itemprice_item_textvalue(string itemName, string price)
        {
            txtNameOfItem.Text = itemName;
            txtPrice.Text = price;
        }**/


        private void computation_formula_and_display()
        {
            //discounted_amt = (qty * price) - discount_amt;
            //txtDiscAmt.Text = discount_amt.ToString("n");
            //txtDiscountedAmt.Text = discounted_amt.ToString("n");

            variables1.discounted_amt = (variables1.qty * variables1.price)  - variables1.discount_amt;
            txtDiscAmt.Text = variables1.discount_amt.ToString("n");
            txtDiscountedAmt.Text = variables1.discounted_amt.ToString("n");

        }

        private void GetPriceItemValue()
        {
            txtNameOfItem.Text = price_Item_Value.GetItemName();
            txtPrice.Text = price_Item_Value.GetPrice();
        }



        private void Example2_Load(object sender, EventArgs e)
        {
           // price_itemprice_item_textvalue("0.00", "500.99");
            // quantityTxtbox();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name3lbl.Text, "100.50");
            price_Item_Value.SetPriceItemValue(name3lbl.Text, "100.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name4lbl.Text, "111.50");
            price_Item_Value.SetPriceItemValue(name4lbl.Text, "111.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name5lbl.Text, "120.50");
            price_Item_Value.SetPriceItemValue(name5lbl.Text, "120.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           // price_itemprice_item_textvalue(name6lbl.Text, "90.50");
            price_Item_Value.SetPriceItemValue(name6lbl.Text, "90.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name7lbl.Text, "101.50");
            price_Item_Value.SetPriceItemValue(name7lbl.Text, "101.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name8lbl.Text, "123.50");
            price_Item_Value.SetPriceItemValue(name8lbl.Text, "123.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name9lbl.Text, "188.00");
            price_Item_Value.SetPriceItemValue(name9lbl.Text, "188.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name10lbl.Text, "680.50");
            price_Item_Value.SetPriceItemValue(name10lbl.Text, "680.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name11lbl.Text, "199.50");
            price_Item_Value.SetPriceItemValue(name11lbl.Text, "199.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           // price_itemprice_item_textvalue(name12lbl.Text, "99.00");
           price_Item_Value.SetPriceItemValue(name12lbl.Text, "99.00");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name13lbl.Text, "190.50");
            price_Item_Value.SetPriceItemValue(name13lbl.Text, "190.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name14lbl.Text, "121.50");
            price_Item_Value.SetPriceItemValue(name14lbl.Text, "121.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name15lbl.Text, "599.50");
            price_Item_Value.SetPriceItemValue(name15lbl.Text, "599.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name16lbl.Text, "91.50");
            price_Item_Value.SetPriceItemValue(name16lbl.Text, "91.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name17lbl.Text, "81.50");
            price_Item_Value.SetPriceItemValue(name17lbl.Text, "81.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name18lbl.Text, "71.50");
            price_Item_Value.SetPriceItemValue(name18lbl.Text, "71.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name19lbl.Text, "211.50");
            price_Item_Value.SetPriceItemValue(name19lbl.Text, "211.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name20lbl.Text, "576.50");
            price_Item_Value.SetPriceItemValue(name20lbl.Text, "576.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void rbtnSenior_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
               // discount_amt = (qty * price) * 0.20;
               variables1.discount_amt = (variables1.qty * variables1.price) * 0.30;
                computation_formula_and_display();

                rbtnDiscCard.Checked = false;
                rbtnEmpDisc.Checked = false;
                rbtnNoDisc.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid.");
                quantityTxtbox();
            }
        }

        private void rbtnDiscCard_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                quantity_price_convert();
                //discount_amt = (qty * price) * 0.30;
                variables1.discount_amt = (variables1.qty * variables1.price) * 0.10;
                computation_formula_and_display();

                rbtnEmpDisc.Checked = false;
                rbtnNoDisc.Checked = false;
                rbtnSenior.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid.");
                quantityTxtbox();
            }
         }

        private void rbtnEmpDisc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
               // discount_amt = (qty * price) * 0.15;
               variables1.discount_amt = (variables1.qty * variables1.price) * 0.15;
                computation_formula_and_display();

                rbtnDiscCard.Checked = false;
                rbtnNoDisc.Checked = false;
                rbtnSenior.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid.");
                quantityTxtbox();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                variables1.qty = Convert.ToInt32(txtQty.Text);
                variables1.discount_amt = Convert.ToDouble(txtDiscAmt.Text);
                variables1.discounted_amt = Convert.ToDouble(txtDiscountedAmt.Text);
                variables1.cash_given = Convert.ToDouble(txtCashRend.Text);

                variables1.qty_total += variables1.qty;
                variables1.discount_totalgiven += variables1.discount_amt;
                variables1.discounted_total += variables1.discounted_amt;

                if (variables1.cash_given < variables1.discounted_amt)
                {
                    MessageBox.Show("Cash given is insufficient.");
                    txtCashRend.Clear();
                    txtCashRend.Focus();
                    return;
                }
                variables1.change = variables1.cash_given - variables1.discounted_amt;

                txtTotalQty.Text = variables1.qty_total.ToString();
                txtTotalDisc.Text = variables1.discount_totalgiven.ToString("n");
                txtTotalDiscountedAmt.Text = variables1.discounted_total.ToString("n");
                txtChange.Text = variables1.change.ToString("n");
                txtCashRend.Text = variables1.cash_given.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid.");
                quantityTxtbox();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNameOfItem.Clear();
            txtPrice.Clear();
            txtDiscAmt.Clear();
            txtDiscountedAmt.Clear();
            txtCashRend.Clear();
            txtChange.Clear();
            txtTotalQty.Clear();
            txtTotalDisc.Clear();
            txtTotalDiscountedAmt.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            KeypadInput("1");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KeypadInput("2");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KeypadInput("3");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KeypadInput("4");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            KeypadInput("5");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            KeypadInput("6");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            KeypadInput("7");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            KeypadInput("8");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            KeypadInput("9");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            KeypadInput ("0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnCalc_Click(sender, e);
        }

        private void rbtnNoDisc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_convert();
                //discount_amt = (qty * price) * 0.00;
                variables1.discount_amt = (variables1.qty * variables1.price) * 0.00;
                computation_formula_and_display();

                rbtnDiscCard.Checked = false;
                rbtnEmpDisc.Checked = false;
                rbtnSenior.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid.");
                quantityTxtbox();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue(name2lbl.Text, "101.50");
            price_Item_Value.SetPriceItemValue(name2lbl.Text, "101.50");
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //price_itemprice_item_textvalue("Meal A", "100.50");
            price_Item_Value.SetPriceItemValue("Meal A", "100.50");
            GetPriceItemValue();
            quantityTxtbox();
        }


    }
}
