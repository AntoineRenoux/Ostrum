using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3.tests
{
    [TestFixture]
    public class CalculTest
    {
        [Test]
        public void When_Calcul_Average_Success()
        {
            List<decimal> decimals = new List<decimal>
            {
                1, 2 , 3, 4, 5, 6, 7,
            };

            Assert.AreEqual(decimals.Average(), 4);
        }

        [Test]
        public void When_Calcul_Average_Fail()
        {
            List<decimal> decimals = new List<decimal>
            {
                1, 2 , 3, 4, 5, 6, 7,
            };

            Assert.AreNotEqual(decimals.Average(), 10);
        }
    }
}
