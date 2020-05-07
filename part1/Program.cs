using System;
using System.Collections.Generic;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            /*Numbers num = new Numbers();
            Console.WriteLine(num.Sum(4075)); // 16
            Console.WriteLine(num.Sum(3)); // 3
            Console.WriteLine(num.Sum(999999999)); // 81*/

            //Exercise 2
            /*DateTime start = DateTime.Now;
            Substrings subs = new Substrings();
            Console.WriteLine(subs.Calculate("aybabtu", "bab")); // 1
            Console.WriteLine(subs.Calculate("aaaaa", "aa")); // 4
            Console.WriteLine(subs.Calculate("monkey", "banana")); // 0
            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));*/

            //Exercise 3
            Tables t = new Tables();
            Console.WriteLine(t.Calculate(new int[] { 1, 2, 3, 2 })); // 18
            Console.WriteLine(t.Calculate(new int[] { 5, })); // 5
            Console.WriteLine(t.Calculate(new int[] { 4, 2, 9, 1, 9, 2, 5 })); // 323

        }
    }
}
