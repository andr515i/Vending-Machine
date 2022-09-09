using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class UI
    {
        VendingMachine vm = new VendingMachine();   // a new vending machine controller, so we can actually do something
        private int wareKey;  // key for dictionary

        public int WareKey
        {
            get { return wareKey; }
            set { wareKey = value; }
        }

        public void PrintProducts()  // wow, such method. 
        {
            vm.PrintProducts();
        }

        public void ChooseProduct(int key) // from user input, we get the productkey stored in a variable, so we can retrieve at later points without worries
        {
            this.WareKey = key;

            if (key == -1225)  // restock
            {
                Restock();
            }
            else
            {
                if (vm.ChooseProduct(wareKey))  // makes sure item is in dictionary
                {
                    Payment(); // continue if true
                }
                else
                {  // if false, we try again, and make sure the user knows they fucked up
                    Console.WriteLine("product not found");
                    Console.WriteLine("choose product from vending machine");
                    try // simple exception handling
                    {
                        ChooseProduct(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("illegal input. try again");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("number was too big, try again. try again");
                    }

                }
            }
        }
        public void Payment()  // money!
        {
            Console.WriteLine("the price for 1 " + vm.GetName(wareKey) + " is " + vm.ProductPrice(wareKey));
            Console.WriteLine("please insert card.     type cancel to cancel out of payment      //(press enter to insert card)");
            if (vm.Payment())  // if payment has occured we continue
            {
                PickProductUp();  // if payment does not occur, user already knows
            }
        }
        public void PickProductUp()  // we have no delivered the product down to the item tray and is awaiting for the removal of the item
        {
            Console.WriteLine("you can now pick your " + vm.GetName(wareKey) + " up from the item tray. enjoy!"); ;
            vm.RemoveProduct(wareKey);
            Console.ReadLine();
        }

        public void Restock()  // restock the machiune, we can even put new items in, and magically make the vending machine bigger!
        {
            bool restocking = true;
            while (restocking) // while loop for ease of use
            {
                Console.WriteLine("restock the machine. enter the name of the item. when done, type \"done\" ");
                string restockName = Console.ReadLine();
                if (restockName == "done") // so we can get out of the while loop :)
                {
                    restocking = false;
                }
                else
                {
                    Console.WriteLine("where are you restocking?: ");
                    int restockKey = Convert.ToInt32(Console.ReadLine());
                    vm.Restock(restockKey, restockName);
                }
            }

        }

    }

}
