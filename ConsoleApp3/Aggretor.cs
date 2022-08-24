using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class Aggretor
    {
        private readonly IProvider _provider;

        public Aggretor(IProvider provider)
        {
            _provider = provider;

        }

        public decimal GetLastPricesAverage(int numberOfPrices)
        {
            var lastPrices = _provider.GetLastPrices(numberOfPrices).Select(x => x.Value);

            return lastPrices.Average();
        }
    }
}
