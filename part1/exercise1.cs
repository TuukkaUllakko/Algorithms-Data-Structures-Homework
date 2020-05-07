using System;
using System.Collections.Generic;
namespace part1
{
    public class Numbers
    {
        public int Sum(int x)
        {
            int sum = 0; //The sum that needs to be returned
            List<int> listOfInts = new List<int>(); //List for storing the individual numbers

            while (x > 0) //Until there are no proper numbers left
            {
                listOfInts.Add(x % 10); // number % 10 = it's last number. Last number gets added to the list as an individual character.
                x = x / 10; //Basically, removes the last individual character from the number, f.ex. 48 / 10 = 4,8. It gets rounded down so -> 4.
            }
            for (int i = 0; i < listOfInts.Count; i++) //For each character's index in the list
            {
                sum = sum + listOfInts[i]; //Add the item at that index to the sum
            }
            return sum; //Return the answer
        }
    }
}