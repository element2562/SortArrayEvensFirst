using System;

namespace SortArrayEvenFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 3, 7, 9, 21, 4, 5, 2, 8, 16 };
            int[] sorted = SortArrayByParity(nums);
            for(int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
        static int[] SortArrayByParity(int[] A)
        {
            int[] sortedArr = new int[A.Length];
            int Counter = 0;
            for (int j = 0; j < A.Length; j++)
            {
                if (A[j] % 2 == 0)
                {
                    sortedArr[Counter] = A[j];
                    Counter++;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    sortedArr[Counter] = A[i];
                    Counter++;
                }
            }
            return sortedArr;
        }
    }
}
