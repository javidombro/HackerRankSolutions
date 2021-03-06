namespace ConvertToPDF
{
    public static class FlowersCost
    {
        public static int getMinimumCost(int k, int[] c)
        {
            Quick_Sort(c, 0, c.Length - 1);
            int totalCost = 0;
            var prevPurchases = new int[k];
            var buyer = 0;

            for (int i = c.Length - 1; i >= 0; i--)
            {
                totalCost += c[i] * (prevPurchases[buyer] + 1);
                prevPurchases[buyer]++;
                buyer = (buyer + 1) % k;
            }
            return totalCost;
        }

        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
