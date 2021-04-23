using System;

namespace ConsoleApp1
{
    public static class MinimumAbsoluteDifference
    {

        //Solucion lenta
        public static int minimumAbsoluteDifference(int[] arr)
        {
            var min = int.MaxValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    var dif = Math.Abs(arr[i] - arr[j]);
                    min = dif < min ? dif : min;

                    if (min == 0)
                    {
                        return 0;
                    }
                }
            }
            return min;
        }

        //Solucion Optima
        public static int minDifference(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
            var min = int.MaxValue;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var dif = Math.Abs(arr[i] - arr[i + 1]);
                min = dif < min ? dif : min;
                if (min == 0)
                {
                    return 0;
                }
            }
            return min;
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }
}
