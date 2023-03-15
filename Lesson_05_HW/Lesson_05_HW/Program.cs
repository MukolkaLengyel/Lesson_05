using System.Globalization;

namespace Lesson_05_HW
{
    internal class Program
    {
        //Selection Sort Algoritms
        static void sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_Value = i;

                for (int j = i + 1; j < n; j++)

                    if (arr[j] < arr[min_Value])
                        min_Value = j;

                int temp = arr[min_Value];
                arr[min_Value] = arr[i];
                arr[i] = temp;

            }
        }

        static void PrintResult(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine();
        }


        //Bubble Sort Algoritm
        static void bubbleShort(int[] arr2)
        {
            int n = arr2.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr2[j] > arr2[j + 1])
                    {
                        int temp = arr2[j];
                        arr2[j] = arr2[j + 1];
                        arr2[j + 1] = temp;
                    }
        }

        static void printResult2(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)

                Console.WriteLine(arr[i] + " ");
            Console.WriteLine("");
        }


        // Insertion Sort Algoritm
        static void InsertionSort(int[] arr3)
        {
            int n = arr3.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = arr3[i];
                int j = i - 1;

                while (j >= 0 && arr3[j] > key)
                {
                    arr3[j + 1] = arr3[j];
                    j = j - 1;
                }

                arr3[j + 1] = key;
            }

            static void printResult3(int[] arr3)
            {
                int n = arr3.Length;

                for (int i = 0; i < n; ++i)
                    Console.WriteLine(arr3[i] + " ");
                Console.WriteLine("\n");
            }

            static void Main(string[] args)
            {
                int[] arr = { 20, 5, 14, 8, 2, 25 };
                sort(arr);
                Console.WriteLine("Selection Sorted arrays: ");
                PrintResult(arr);

                int[] arr2 = { 5, 1, 4, 2, 8 };
                bubbleShort(arr2);
                Console.WriteLine("Bubble Sorted arrays: ");
                printResult2(arr2);

                int[] arr3 = { 8, 1, 3, 2, 6, 12, };
                InsertionSort(arr3);
                Console.WriteLine("Insertion Sorted arrays: ");
                printResult3(arr3);



            }

        }
    }
}
