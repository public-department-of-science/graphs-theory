using System;
using System.Collections.Generic;

namespace DynamicCompile
{
    static class Class1
    {
        static unsafe bool NextSetOFPermutationWithoutRepeats(int[] a, int n)
        {
            unsafe
            {
                int j = n - 2;
                while (j != -1 && a[j] >= a[j + 1]) j--;
                if (j == -1)
                    return false; // больше перестановок нет
                int k = n - 1;
                while (a[j] >= a[k]) k--;
                swap(a, j, k);
                int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности
                while (l < r)
                    swap(a, l++, r--);
                return true;
            }
        }

        static unsafe void swap(int[] a, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;
        }

        public static List<int[]> PermutionsWithoutRepeats(int n)
        {
            List<int[]> res = new List<int[]>();

            unsafe
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                    a[i] = i + 1;
                while (NextSetOFPermutationWithoutRepeats(a, n))
                {
                    int[] b = new int[n];
                    Array.Copy(a, 0, b, 0, a.Length);
                    res.Add(b);
                }

                return res;
            }
        }
    }
}
