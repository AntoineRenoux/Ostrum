using System.Collections.Generic;

namespace ConsoleApp3
{
    public interface IProvider
    {
        IEnumerable<Price> GetLastPrices(int numberPrices);
    }
}