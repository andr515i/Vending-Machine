using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool testing = true;

            UI ui = new UI();
            // customer chooses a product
            while (testing)
            {
                ui.PrintProducts();

                Console.WriteLine("choose product from vending machine");
                try
                {
                    ui.ChooseProduct(Convert.ToInt32(Console.ReadLine()));  // need int input so we convert

                }
                catch (FormatException) // incase of misspellings or errors
                {
                    Console.WriteLine("illegal input. try again");
                }
                catch(OverflowException) // incase of developers or trolls
                {
                    Console.WriteLine("number was too big. try again");
                }
            }
        }


    }
}
