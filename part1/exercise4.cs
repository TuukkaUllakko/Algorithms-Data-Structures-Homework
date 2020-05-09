using System;
using System.Collections.Generic;
using System.Linq;

namespace part1
{
    public class LuckyNumbers
    {
        public int Calculate(int a, int b)
        {
            int answer = 0; //The final amount of full 3, 7, and 3 + 7 numbers.
            int loopStartZeros = 0; //The loop start will vary based on a.
            int loopStart = 0; //The variable for setting up the loop starting point.
            int aFirstDigit = a; //The variable for getting the first digit of a.
            int[] array = new int[b * 2]; //Array for storing individual digits from numbers, so they can be checked if they are 3 or 7.
            int successPoints = 0; //Success points for the digit checking loop.

            if (a < 10 && b >= 10)
            {
                for (int i = a; i < 10; i++)
                {
                    if (i == 3)
                    {
                        answer++;
                    }
                    if (i == 7)
                    {
                        answer++;
                    }
                }
            }
            else if (a <= 3 && b < 7 && b >= 3)
            {
                answer = 1;
            }
            //Console.WriteLine(answer);

            while (aFirstDigit / 10 > 0) //Until aCopy = the first number of a.
            {
                aFirstDigit = aFirstDigit / 10;
            }

            loopStartZeros = Convert.ToInt32(Math.Pow(10, a.ToString().Length - 1));
            loopStart = loopStartZeros * aFirstDigit; //Loop should now start at f.ex. 300, if a = 353.
            //Console.WriteLine(loopStart);
            //Then starts the main loop, at the minimum of 10.

            if (a < 100) //If a is below 100, the loop will start at 10, so loopStart will be reset to 0.
            {
                loopStart = 0;
            }
            //Console.WriteLine(loopStart);

            for (int i = loopStart + 10; i < b; i = i + 20) //Adding 20 to the i will skip unnecessary checks, making the iteration 20x faster.
            {
                int number1 = i + 3; //Add 3 to the number to check if all are 3 or 7.
                int number2 = i + 7; //Add 7 to the number to check if all are 7 or 3.
                int number1Stored = i + 3;
                int number2Stored = i + 7;
                int numberLength = number1.ToString().Length; //Saving for length.
                //Console.WriteLine(numberLength);
                //Console.WriteLine(number1);
                //Console.WriteLine(number2);

                int index1 = 0;
                while (number1 > 0) //Loop for adding the individual digits to the array.
                {
                    array[index1] = number1 % 10; //Add the last digit of the number to array.
                    number1 = number1 / 10; //Cut the last digit off the number.
                    //Console.WriteLine(array[index1]);
                    index1++;
                }
                int index2 = index1;
                while (number2 > 0) //Looping for the second number too.
                {

                    array[index2] = number2 % 10; //Add the last digit of the number to array. +2 to j so they don't go on top of number1.
                    number2 = number2 / 10; //Cut the last digit off the number.
                    //Console.WriteLine(array[index2 + numberLength / 2]);
                    index2++;
                }
                //Console.WriteLine(array[0]);
                //Console.WriteLine(array[1]);
                //Console.WriteLine(array[2]);
                //Console.WriteLine(array[3]);
                for (int u = 0; u < numberLength * 2; u++) //Check each digit for 3s and 7s for number1. Add success points if 3 or 7.
                {
                    //Console.WriteLine(array[u]);
                    if (array[u] == 3)
                    {
                        successPoints++;
                    }
                    else if (array[u] == 7)
                    {
                        successPoints++;
                    }
                }
                //If successPoints = numberLength * 2, then all were 3s and 7s, so answer + max 2. Check that the numbers are within the range to add.
                //Console.WriteLine(successPoints + ": " + i);
                if (successPoints == numberLength * 2 && number1Stored >= a && number1Stored <= b)
                {
                    answer = answer + 1;

                }
                if (successPoints == numberLength * 2 && number2Stored >= a && number2Stored <= b)
                {
                    answer = answer + 1;
                }

                successPoints = 0;

            }

            return answer;

        }
    }
}
