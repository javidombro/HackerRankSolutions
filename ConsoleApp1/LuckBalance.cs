using System.Collections.Generic;
using System.Linq;

namespace ConvertToPDF
{
    public class LuckBalance
    {
        public static int luckBalance(int k, List<List<int>> contests)
        {
            var balance = 0;
            var allowedDefeats = k;

            QuickSort(contests, 0, contests.Count - 1);


            for (int i = contests.Count-1 ; i >= 0 ; i--)
            {
                if (contests[i][1] == 0)
                {
                    balance += contests[i][0];
                    continue;
                }
                if (allowedDefeats > 0)
                {
                    balance += contests[i][0];
                    allowedDefeats--;
                    continue;
                }
                balance -= contests[i][0];
            }
            return balance;
        }

        private static void QuickSort(List<List<int>> list, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(list, start, end);

                QuickSort(list, start, i - 1);
                QuickSort(list, i + 1, end);
            }
        }

        private static int Partition(List<List<int>> list, int start, int end)
        {
            List<int> temp;
            int pivot = list[end][0];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (list[j][0] <= pivot)
                {
                    i++;
                    temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }

            temp = list[i + 1];
            list[i + 1] = list[end];
            list[end] = temp;
            return i + 1;
        }
    }
}
