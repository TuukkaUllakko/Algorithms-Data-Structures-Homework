using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Exercise 1
            Exercise1 hello = new Exercise1();
            hello.Hello(5);*/

            //Exercise 2
            SmallestDifference s = new SmallestDifference();
            Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
            Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
        }
    }
}
