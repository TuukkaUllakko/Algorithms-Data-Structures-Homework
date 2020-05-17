using System;

namespace part2
{
    class Split
    {
        public int Calculate(int[] t)
        {
            int sum = 0;
            int[] splitLeft = new int[t.Length - 1]; //All the possible sums from left to right - last number
            int[] splitRight = new int[t.Length - 1]; //All the possible sums from right to left - last number
            int sumsFromLeft = 0;
            int sumsFromRight = 0;
            
            for (int i = 0; i < splitLeft.Length; i++) //Sums of all possible split combinations from left to right
            {                                          //added to 0-n indexes on the array splitLeft
                sumsFromLeft = sumsFromLeft + t[i];
                splitLeft[i] = sumsFromLeft;
            }
            for (int i = splitRight.Length; i > 0; i--) //Sums of all possible split combinations from right to left
            {                                           //added to 0-n indexes on the array splitRight
                sumsFromRight = sumsFromRight + t[i];
                splitRight[i - 1] = sumsFromRight;
            }
            for (int i = 0; i < splitRight.Length; i++) //Go through all indexes in both splitLeft & splitRight.
            {                                           //If the sums are equal at some point, that means there is at least
                if (splitRight[i] == splitLeft[i])      //One way to split the array t in two with both sides sharing the same sum
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}