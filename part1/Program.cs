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
            Substrings subs = new Substrings();
            Console.WriteLine(subs.Calculate("aybabtu", "bab")); // 1
            Console.WriteLine(subs.Calculate("aaaaa", "aa")); // 4
            Console.WriteLine(subs.Calculate("monkey", "banana")); // 0


        }
    }
}
