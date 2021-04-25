using System;
using System.Collections.Generic;

namespace HackerRankSolutions
{
    public static class JaneaSystemsCodingChallenge
    {

        public static long countMax(List<string> upRight)
        {
            var minCol = long.MaxValue;
            var minRow = long.MaxValue;
            foreach (var item in upRight)
            {
                var indexes = item.Split(' ');
                minRow = Math.Min(minRow, long.Parse(indexes[0]));
                minCol = Math.Min(minCol, long.Parse(indexes[1]));
            }

            return minCol * minRow;
        }

        public static int balancedSum(List<int> arr)
        {
            var firstHalf = arr[0];
            var pivot = 1;
            var secondHalf = sum(arr, pivot + 1, arr.Count);
            if (firstHalf == secondHalf)
            {
                return pivot;
            }

            for (pivot = 2; pivot < arr.Count - 1; pivot++)
            {
                firstHalf += arr[pivot - 1];
                secondHalf -= arr[pivot];
                if (firstHalf == secondHalf)
                {
                    return pivot;
                }
            }
            return 0;
        }

        private static int sum(List<int> arr, int start, int finish)
        {
            var sum = 0;
            for (int i = start; i < finish; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
