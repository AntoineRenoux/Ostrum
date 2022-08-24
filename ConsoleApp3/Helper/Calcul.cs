using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public static class Calcul
    {
        public static decimal Average(IEnumerable<decimal> numbers)
        {
            return numbers.Average();
        }
    }
}
