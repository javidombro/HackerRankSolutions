using System.Collections.Generic;

namespace HackerRankSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = JimAndTheOrders.jimOrders(new List<List<int>>
            {
                new List<int>{1,13},new List<int>{2,3}, new List<int>{2,2}, new List<int>{3,3}
            });

            //var smallest = ReverseShuffleMerge.reverseShuffleMerge("aeiouuoiea");
            //System.Console.WriteLine(smallest);
        }
    }
}
