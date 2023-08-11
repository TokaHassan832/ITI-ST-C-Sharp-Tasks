using static Bubble_Sort.Program;

namespace Bubble_Sort
{
    internal class Program
    {
        public delegate bool ComparisonDelegate(int a, int b);

        static void Main(string[] args)
        {
            int[] array = { 5, 2, 8, 1, 3 };

            BubbleSort(array, CompareAsc);
            Console.WriteLine("Sorted in ascending order:");
            PrintArray(array);

            BubbleSort(array, CompareDesc);
            Console.WriteLine("Sorted in descending order:");
            PrintArray(array);

            Console.ReadLine();
        }


        static void BubbleSort(int[] arr, ComparisonDelegate comparison)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparison(arr[j], arr[j + 1]))
                    {
                        // Swap elements
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Comparison delegates
        static bool CompareAsc(int a, int b)
        {
            return a > b;
        }

        static bool CompareDesc(int a, int b)
        {
            return a < b;
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}