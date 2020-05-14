using System;

namespace part2
{
    class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int repetition = 1;
            int biggestRep = 1; //This should only grow if it's bigger than the current repetition

            for (int i = 1; i < t.Length; i++)
            {

                if (t[i] == t[i - 1])
                {
                    repetition++;
                }
                else if (t[i] != t[i - 1])
                {
                    repetition = 1;
                }
                if (biggestRep < repetition)
                {
                    biggestRep = repetition;
                }
            }

            return biggestRep;
        }
    }
}