using System;

namespace part2
{
    class Revolutions
    {
        public int Calculate(int[] t)
        {
            int revolutions = 0; //The amount of revolutions.
            int currentLargest = 1; //The current number to be checked for. This changes + 1 if it's found.

            for (int i = 1; i <= t.Length; i++) //Loop for capturing how many times looping is needed. i will be revolutions.
            {
                for (int j = 0; j < t.Length; j++) //Loop for iterating through the array
                {
                    if (t[j] == currentLargest) //If the currentLargest number (starts from 1) is found in the array...
                    {                              //(this won't ever go through after all the numbers have been gone through, because current-
                                                   //largest will then always be +1 more than the biggest number in the array)
                        currentLargest = currentLargest + 1; //...it was found. Next current number to find is +1 that..
                        
                        if (currentLargest == t.Length + 1) //...and if the current largest has become +1 more than t.Length
                        {                                   //save the iteration times (i) as the revolutions.
                            revolutions = i;
                        } 
                    }
                }
            }
            return revolutions;
        }
    }
}