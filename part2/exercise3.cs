using System;

namespace part2
{
    public class Changes
    {
        public int Calculate(int[] t)
        {
            int steps = 0;

            for (int j = 1; j < t.Length; j++)
            {
                if (t[j] == t[j - 1] && j < t.Length - 1) //Everything but the last integer in the array
                {
                    t[j] = t[j - 1] + t[j + 1]; //Add both t[j - 1] AND t[j + 1] together, this way it's IMPOSSIBLE for one of the sides to be the same.
                    steps++;
                }
                else if (t[j] == t[j - 1] && j == t.Length - 1) //For the last integer in the array
                {
                    t[j] = t[j - 1] + t[j]; //With the last integer, there is no next number, so we have to only add the previous one.
                    steps++;
                }
            }
            return steps;
        }
    }
}