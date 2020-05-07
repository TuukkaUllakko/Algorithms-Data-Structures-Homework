using System.Collections.Generic;

namespace part1
{
    public class Tables
    {
        public int Calculate(int[] t)
        {
            int answer = 0; //The variable for the last number to return.
            int changeLength = t.Length - 1; //This is for the inner for loop, because the length of the array gets smaller by 1 each time the summing is done.

            if (t.Length == 1) //The function below won't work if only 1 number slot is in the array, because then changeLength would be 0, so the loop wouldn't happen.
            {
              return t[0]; //So, we simply return the number in the array, since there is nothing to sum it with.
            }

            else //Otherwise, so if there is 2 or more slots in the array,
            {
                for (int i = 0; i < t.Length; i++) //loop as many times as numbers are given in the array.
                {
                    for (int index = 0; index < changeLength; index++) //This loop won't happen, since both index and changeLength are 0.
                    {

                        answer = t[index] + t[index + 1]; //The answer is now the sum of the two current indexes that are added together.

                        t[index] = answer; //The slots in the array are changed index by index with the answers of the sums, starting from [0].
                    }
                    changeLength = changeLength - 1; //changeLength has to be shorter by 1 for the next loop, since because of the summing, there is one less index with a number in it in the array.
                }
            }
            return answer; //After looping is complete, answer should be the sum of the last two remaining integers in the array.
        }

    }
}
