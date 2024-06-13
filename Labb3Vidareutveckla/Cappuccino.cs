using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Vidareutveckla
{
    public class Cappuccino : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Hot cappuccino is served."); // Utskrift vid konsumtion av cappuccino
        }
    }
}
