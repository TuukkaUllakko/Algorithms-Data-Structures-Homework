using System;

namespace part3
{
    class Inversions
    {
        public int[] Create(int n, int k)
        {
            if (n <= 0)
            {
                int[] no = new int[0];
                return no;
            }

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            Invert(array, k);
            return array;

        }

        public int[] Invert(int[] array, int k)
        {
            int index = 0;
            int inversions = 0;
            int reducer = 2;

            while (inversions < k)
            {
                int temp = array[index];
                array[index] = array[index + 1];
                array[index + 1] = temp;

                if (index == array.Length - reducer)
                {
                    index = -1;
                    reducer++;
                }
                index++;
                inversions++;
            }
            return array;
        }
    }
}