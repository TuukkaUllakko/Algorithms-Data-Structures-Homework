using System;

namespace part3
{
    class Sorting
    {
        public void MergeSort(int[] t)
        {
            DateTime start = DateTime.Now;

            t = SubArrays(t);

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));
            
        }
        public void QuickSort(int[] t)
        {
            DateTime start = DateTime.Now;

            t = SortArray(t);

            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));

        }

        public int[] SortArray(int[] t) //For QuickSort
        {
            return QSort(t, 0, t.Length - 1);
        }

        public int[] QSort(int[] numbers, int left, int right) //For QuickSort
        {
            int i = left;
            int j = right;

            var pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i] < pivot)
                    i++;

                while (numbers[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QSort(numbers, left, j);
            }

            if (i < right)
            {
                QSort(numbers, i, right);
            }
            return numbers;
        }
        public int[] SubArrays(int[] t) //For merge sort
        {
            int a = 0;
            int b = t.Length;
            int k = (a + b) / 2;
            int[] subArr1 = new int[k];
            int[] subArr2 = new int[b - k];

            if (t.Length <= 1)
            {
                return t;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (i < k)
                {
                    subArr1[i] = t[i];
                }
                else
                {
                    subArr2[i - k] = t[i];
                }
            }

            subArr1 = SubArrays(subArr1);
            subArr2 = SubArrays(subArr2);

            return Merge(subArr1, subArr2);
        }

        public int[] Merge(int[] a, int[] b) //For merge sort
        {
            int[] merged = new int[a.Length + b.Length];
            int[] temp = new int[a.Length + b.Length];
            int a1 = 0;
            int b1 = a.Length - 1;
            int a2 = 0;
            int b2 = b.Length - 1;

            for (int i = 0; i < a.Length + b.Length; i++)
            {
                if (a2 > b2 || (a1 <= b1 && a[a1] <= b[a2]))
                {
                    temp[i] = a[a1];
                    a1++;
                }
                else
                {
                    temp[i] = b[a2];
                    a2++;
                }
            }

            for (int i = 0; i < merged.Length; i++)
            {
                merged[i] = temp[i];
            }

            return merged;
        }

    }
}
