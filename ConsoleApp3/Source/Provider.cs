using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.Source
{
    public class Provider: IProvider
    {
        private List<Price> Prices;

        public Provider()
        {
            Random rnd = new Random();

            Prices = new List<Price>
            {
                new Price { Value = rnd.Next(), Date = new DateTime(2000, 1, 1) },
                new Price { Value = rnd.Next(), Date = new DateTime(2001, 2, 2) },
                new Price { Value = rnd.Next(), Date = new DateTime(2001, 5, 6) },
                new Price { Value = rnd.Next(), Date = new DateTime(2010, 3, 12) },
                new Price { Value = rnd.Next(), Date = new DateTime(2022, 9, 30) },
                new Price { Value = rnd.Next(), Date = new DateTime(2010, 10, 20) },
            };
        }

        public IEnumerable<Price> GetLastPrices(int numberPrices)
        {
            return Prices.OrderByDescending(x => x.Date).Take(numberPrices);
        }
    }
}
