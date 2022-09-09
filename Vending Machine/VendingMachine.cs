using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class VendingMachine
    {
        Wares wares = new Wares();  // so we can manipulate the dictionary containing all products in VENDINGMACHINE wow


        internal bool ChooseProduct(int key)  // checks if product is in vending machine (dictionary)
        {
            return wares.Products.ContainsKey(key);
        }
        internal string GetName(int key)  // gets the name for the chosen product
        {
            return wares.Products[key];
        }
        internal double ProductPrice(int key) // calculates a linearly higher price, depending solely on the product chosen (the first items, ie 1-2-3 are the lowest in price, correspondant to their keyvalue.
        {
            return (Math.Floor((double)wares.Products.Count() / 5)) * key;
        }
        internal bool Payment()  // makes sure customer can cancel out of payment, so we can reset machine
        {
            if (Console.ReadLine() != "cancel")
            {
                return true;
            }
            else
            {
                Console.WriteLine("you have cancelled. we wish you a good day");
                return false;
            }
        }
        internal void RemoveProduct(int key) // removes product from system, to display accurate information and take the correct decisions
        {
            wares.Products.Remove(key);
        }
        internal void PrintProducts()  // prints the whole dictionary out to the console so we can read it
        {
            if (wares.Products.Count != 0)  // as long as there are products in the machine, we can print them out
            {

                foreach (KeyValuePair<int, string> wares in wares.Products)
                {
                    Console.WriteLine(wares.Key + "." + wares.Value);
                }
            }
            else
            {
                Console.WriteLine("there are currently no products in the vending machine., contacting an employee\n\n\n                                code -1225\n                                restock the machine"); // should contact employees to refill
            }
        }
        internal void Restock(int key, string name)
        {
            try
            {
                wares.Products.Add(key, name);

            }
            catch  (ArgumentNullException)
            {
                Console.WriteLine("invalid spot. please pick a positive whole number. ie. 1, 25, 135");
            }
            catch (ArgumentException)
            {

                Console.WriteLine("product spot is already taken, choose somewhere else");
            }
        }
    }
}
