using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 6, 9, 42, 34, 26, 47, 62, 2, 1, 54, 36, 999, 3, 5 };
            foreach (int el in arr) Console.Write(el + " ");
            Console.Write("\n");
            Sort(ref arr);
            foreach (int el in arr) Console.Write(el + " ");
            Console.Write("\n");
        }
        private static void Sort(ref int[] arr)
        {
            Sort(ref arr, 0, arr.Length - 1);
        }
        private static void Sort(ref int[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(ref arr, left, right);
                Sort(ref arr, left, p);
                Sort(ref arr, p + 1, right);
            }
        }

        static int Partition(ref int[] arr, int left, int right)
        {
            int pivot = Mediana(arr[left], arr[(right - left) / 2], arr[right]);
            while (left < right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left >= right)
                {
                    return right;
                }
                arr[left] += arr[right];
                arr[right] = arr[left] - arr[right];
                arr[left] -= arr[right];
            }
            return right;
        }

        static int Mediana(int a, int b, int c)
        {
            return a > b & b > c || a < b & b < c ? b :
                   a > c & c > b || a < c & c < b ? c : a;
        }
    }
}
