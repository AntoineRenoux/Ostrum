using ConsoleApp3.Source;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var provider = new Provider();
            var agg = new Aggretor(provider);

            var ret = agg.GetLastPricesAverage(3);
        }
    }
}
