using System;

public class Solution
{
    public T[] MergeSortedArrays<T>(T[] a, T[] b) where T : IComparable<T>
    {
        T[] merged = new T[a.Length + b.Length];

        int i = 0, j = 0, k = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                merged[k++] = a[i++];
            }
            else
            {
                merged[k++] = b[j++];
            }
        }

        while (i < a.Length)
        {
            merged[k++] = a[i++];
        }

        while (j < b.Length)
        {
            merged[k++] = b[j++];
        }

        return merged;
    }

    public static void Main()
    {
        Solution obj = new Solution();

        int[] a = { 1, 3, 5, 7 };
        int[] b = { 2, 4, 6, 8 };

        int[] result = obj.MergeSortedArrays(a, b);

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}