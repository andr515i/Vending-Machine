using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Wares
    {
        private Dictionary<int, string> products = new Dictionary<int, string>();  // holds all products

        internal Dictionary<int, string> Products
        {
            get { return products; }
            set { products = value; }
        }

        public Wares()
        {  // this is horrible... i love it
            products.Add(1, "Jujutsu Kaisen ");
            products.Add(2, "Jujutsu Kaisen");
            products.Add(3, "Jujutsu Kaisen");
            products.Add(4, "Jujutsu Kaisen");
            products.Add(5, "Jujutsu Kaisen");
            products.Add(6, "Demon Slayer");
            products.Add(7, "Demon Slayer");
            products.Add(8, "Demon Slayer");
            products.Add(9, "Demon Slayer");
            products.Add(10, "Demon Slayer");
            products.Add(11, "Tokyo Revengers");
            products.Add(12, "Tokyo Revengers");
            products.Add(13, "Tokyo Revengers");
            products.Add(14, "Tokyo Revengers");
            products.Add(15, "Tokyo Revengers");
            products.Add(16, "Attack on Titan");
            products.Add(17, "Attack on Titan");
            products.Add(18, "Attack on Titan");
            products.Add(19, "Attack on Titan");
            products.Add(20, "Attack on Titan");
            products.Add(21, "My Hero Academia");
            products.Add(22, "My Hero Academia");
            products.Add(23, "My Hero Academia");
            products.Add(24, "My Hero Academia");
            products.Add(25, "My Hero Academia");
            products.Add(26, "one piece");
            products.Add(27, "one piece");
            products.Add(28, "one piece");
            products.Add(29, "one piece");
            products.Add(30, "one piece");
            products.Add(31, "Chainsaw Man");
            products.Add(32, "Chainsaw Man");
            products.Add(33, "Chainsaw Man");
            products.Add(34, "Chainsaw Man");
            products.Add(35, "Chainsaw Man");
            products.Add(36, "Spy x Family");
            products.Add(37, "Spy x Family");
            products.Add(38, "Spy x Family");
            products.Add(39, "Spy x Family");
            products.Add(40, "Spy x Family");
            products.Add(41, "Kingdom");
            products.Add(42, "Kingdom");
            products.Add(43, "Kingdom");
            products.Add(44, "Kingdom");
            products.Add(45, "Kingdom");
            products.Add(46, "Haikyuu");
            products.Add(47, "Haikyuu");
            products.Add(48, "Haikyuu");
            products.Add(49, "Haikyuu");
            products.Add(50, "Haikyuu");
        }


    }
}
