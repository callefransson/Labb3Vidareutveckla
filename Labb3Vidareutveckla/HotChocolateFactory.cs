using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Vidareutveckla
{
    internal class HotChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot chocolate in your cup"); // Utskrift av mängden choklad som hälls upp
            return new HotChocolate(); // Returnerar en ny instans av HotChocolate
        }
    }
}
