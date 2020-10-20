using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cashier
{
    class item
    {
        private int id;
        public string title { get; set; }

        public int quantity { get; set; }
        public double price { get; set; }
        public double Subtotal { get; set; }
        public string type;

        public item(int id, string title, int quantity, string type, double price)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.type = type;
            this.price = price;
            this.Subtotal = 0;
        }
        public string getTitle()
        {
            return title;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public string getType()
        {
            return type;
        }
        public double getPrice()
        {
            return price;
        }
        public double getSubTotal()
        {
            Subtotal = price * quantity;
            return Subtotal;
        }
    }
}
