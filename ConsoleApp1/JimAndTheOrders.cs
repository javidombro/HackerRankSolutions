using System.Collections.Generic;
using System.Linq;

namespace HackerRankSolutions
{
    public static class JimAndTheOrders
    {

        public static List<int> jimOrders(List<List<int>> orders)
        {
            var deliveredTimes = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < orders.Count; i++)
            {
                var serveTime = orders[i][1] + orders[i][0];
                deliveredTimes.Add(new KeyValuePair<int, int>(serveTime, i + 1));
            }
            return deliveredTimes.OrderBy(d => d.Key).Select(o => o.Value).ToList();
        }
    }
}
