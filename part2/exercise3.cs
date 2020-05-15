using System;

namespace part2
{
    class Changes
    {
        public int Calculate(int[] i)
        {
            int steps = 0;
            int counter = 1;

            for (int j = 0; j < i.Length - 1; j++)
            {
                if (i[j] == i[j + 1])
                {
                    counter++;
                }
                else
                {
                    steps = steps + counter / 2;
                    counter = 1;
                }
                if (j + 1 == i.Length - 1 && counter > 1)
                {
                    steps = steps + counter / 2;
                }
            }

            return steps;
        }
    }
}