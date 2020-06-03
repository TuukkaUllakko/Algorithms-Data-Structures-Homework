using System;

namespace part4
{
    class Order
    {
        public int[] Create(int[] a, int[] b)
        {
            int n = a.Length;
            int root = Search(a, b[0], n);

            int[] arr;
            if (root != 0)
            {
                arr = new int[n - 1];
                Array.Copy(b, 1, arr, 0, n - 1);
                Create(a, arr);
            }

            if (root != n - 1)
            {
                arr = new int[n - (root + 1)];
                Array.Copy(a, root + 1, arr, 0, n - (root + 1));

                int[] arr1 = new int[n - (root + 1)];
                Array.Copy(b, root + 1, arr1, 0, n - (root + 1));
                Create(arr, arr1);
            }

            return b;
        }
        public int Search(int[] arr, int x, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}