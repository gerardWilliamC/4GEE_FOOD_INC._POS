using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cahapay_IT202WM_LabExam2_Midterm
{
    internal class Price_Item_Value
    {
        public String price, item_name, discount_amount;

        public void SetPriceItemValue(string item_name, string price)
        {
            this.price = price;
            this.item_name = item_name;
        }

        public String GetItemName() {
            return item_name;
        }

        public String GetPrice()
        {
            return price;
        }

        public void SetPriceDiscountAmountValue(string discount_amount, string priceItem)
        {
            this.discount_amount = discount_amount;
            this.price = priceItem;
        }

        public String GetPriceItem() 
        {
            return price;
        }

        public String GetDiscountAmount()
        {
            return discount_amount;
        }
    }
}
