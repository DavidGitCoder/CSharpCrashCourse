using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    public class Cart
    {
        private string _cartID;
        private Dictionary<string, double> _Items; //item name, price

        public Cart(string cartID)
        { 
            _cartID = cartID; 
            _Items = new Dictionary<string, double>();
        }

        public Cart()
        {
            _Items = new Dictionary<string, double>();
        }

        //Add Item
        public void AddItem(string name, double price)
        {
            _Items.Add(name, price);
        }

        //RemoveItem
        public void RemoveItem(string name)
        {
            _Items.Remove(name);
        }
        //Get Total
        public double GetTotal()
        {
            double total = 0;
            foreach(KeyValuePair<string, double> kvp in _Items)
            {
                total+= kvp.Value;
            }
            return total;
        }

        public string GetCartId()
        {
            return _cartID;
        }
        public void SetCartId(string cartID)
        {
            _cartID = cartID;
        }
        public override string ToString()
        {
            string txt = string.Empty;
            int i = 1;
            foreach (KeyValuePair<string, double> kvp in _Items)
            {
                txt += $"Item #{i}:{kvp.Key} at {kvp.Value.ToString("C")}\n";
                i++;
            }
            return $"Your cart number: {_cartID} is worth {GetTotal().ToString("C")}\nYour cart items:\n{txt}";
        }
    }
}
