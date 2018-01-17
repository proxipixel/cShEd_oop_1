using System;
using System.Collections.Generic;

namespace OOP_1
{
    class ShoppingCard
    {
        //constructor of the class that creates a new Dictinary instance when one is declared
        public ShoppingCard()
        {
            listOfItems = new Dictionary<string, double>();
        }
        
        //method to display all a list of items contained in the list and calculation of total amount for the items' prices
        public void listView()
        {
            double totalAmount = 0.0;
            foreach (KeyValuePair<string, double> itemToShow in listOfItems)
            {
                totalAmount = totalAmount + itemToShow.Value;
                Console.Write("\n{0}\t{1}", itemToShow.Key, itemToShow.Value);
            }
            Console.Write("\n\nTotal amount for all items: {0}\n", totalAmount);
        }
        //class's field
        public Dictionary<string, double> listOfItems;
    }
}