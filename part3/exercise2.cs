using System;

namespace part3
{
    class SmallestDifference
    {
        public int Calculate(int[] t)
        {
            int smallestDifference = int.MaxValue;

            Array.Sort(t);

            if (t.Length <= 1)
            {
                return 0;
            }

            for (int i = 0; i < t.Length - 1; i++)
            {
                if (t[i + 1] - t[i] < smallestDifference)
                {
                    smallestDifference = t[i + 1] - t[i];
                }
            }

            return smallestDifference;
        }
    }
}