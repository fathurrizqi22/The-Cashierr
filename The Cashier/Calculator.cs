using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cashier
{
    class Calculator
    {
        private List<item> listItem;
        private double total = 0;

        public Calculator()
        {
            this.listItem = new List<item>();
        }
        public void addItem(item item)
        {
            this.listItem.Add(item);
            this.total += item.getSubTotal();
        }
        public double getTotal()
        {
            return total;
        }
        public List<item> getlistItem()
        {
            return listItem;
        }
    }
}
