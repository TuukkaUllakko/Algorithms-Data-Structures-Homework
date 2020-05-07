using System.Collections.Generic;

namespace part1
{
  public class Substrings
  {
    public int Calculate(string a, string b)
    {
      int amount = 0; //Each time the built bTester is equal to b in the loop, amount++;
      int aIndex = 0; //Index for where a starts iterating up to b times. After each loop this is 1 bigger.
      List<char> list = new List<char>(); //A list which will store the characters for bTester.
      string bTester = ""; //An empty string which will be assigned the characters from the list.

      if (a.Length < b.Length) //If the string a is longer than string b, string b is not included even once.
      {
        return 0; //Return that b occurs 0 times
      }
      
      for (int i = 0; i < a.Length; i++) //Cycle through the loop as many times as there are characters in string a.
      {

          for (int index = 0; index < b.Length; index++) //Add characters b times from a starting from aIndex.
          {
            int aIndex2 = aIndex + index; //aIndex2, new variable that combines the rising index with aIndex to change the starting point.
            if (aIndex2 < a.Length) //DON'T attempt to add to list if the current aIndex2 is out of reach, WILL GIVE AN ERROR!
            {
              list.Add(a[aIndex2]); //Add the character at that index to the list.
            }
          }

        foreach (char character in list) //Iterate through every character in the list.
        {
          bTester = bTester + character; //Build the string to be compared by adding the strings in the list together.
        }
        if (bTester == b) //If all the characters combined are equal to b, congratulations, b occurred at those indexes.
        {
          amount++; //Add 1 to the amount of times b has occurred.
        }
        aIndex++; //Increase the starting point of the next index by 1.
        list.Clear(); //Clear the list for the next loop.
        bTester = ""; //Empty the bTester string for the next loop.
      }
      return amount; //When all the characters have been gone through, return the amount of times b has occurred.
    }
  }
}