using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Vidareutveckla
{
    public class HotChocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Hot chocolate is served."); // Utskrift vid konsumtion av varm choklad
        }
    }
}
