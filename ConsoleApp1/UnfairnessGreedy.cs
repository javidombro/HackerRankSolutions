using System.Collections.Generic;

namespace HackerRankSolutions
{
    public static class UnfairnessGreedy
    {
        public static int maxMin(int k, List<int> arr)
        {
            var unfairness = int.MaxValue;
            QuickSort(arr, 0, arr.Count - 1);


            for (int i = 0; i <= arr.Count - k; i++)
            {
                var distance = arr[i + k - 1] - arr[i];
                if (distance == 0)
                {
                    return 0;
                }
                unfairness = distance < unfairness ? distance : unfairness;
            }
            return unfairness;
        }

        private static void QuickSort(List<int> list, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(list, start, end);

                QuickSort(list, start, i - 1);
                QuickSort(list, i + 1, end);
            }
        }

        private static int Partition(List<int> list, int start, int end)
        {
            int temp;
            int pivot = list[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (list[j] <= pivot)
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

        //private static void Quick_Sort(List<int> arr, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int pivot = Partition(arr, left, right);

        //        if (pivot > 1)
        //        {
        //            Quick_Sort(arr, left, pivot - 1);
        //        }
        //        if (pivot + 1 < right)
        //        {
        //            Quick_Sort(arr, pivot + 1, right);
        //        }
        //    }
        //}

        //private static int Partition(List<int> arr, int left, int right)
        //{
        //    int pivot = arr[left];
        //    while (true)
        //    {
        //        while (arr[left] < pivot)
        //        {
        //            left++;
        //        }

        //        while (arr[right] > pivot)
        //        {
        //            right--;
        //        }

        //        if (left < right)
        //        {
        //            if (arr[left] == arr[right]) return right;

        //            int temp = arr[left];
        //            arr[left] = arr[right];
        //            arr[right] = temp;
        //        }
        //        else
        //        {
        //            return right;
        //        }
        //    }
        //}
    }
}
