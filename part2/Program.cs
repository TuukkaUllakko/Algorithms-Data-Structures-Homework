using System;
using System.Text;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            /*Counters counters = new Counters();

            string input10 = counters.CreateInput(10);
            string input100 = counters.CreateInput(100);
            string input1000 = counters.CreateInput(1000);
            string input10000 = counters.CreateInput(10000);
            string input1000000 = counters.CreateInput(1000000);
            
            DateTime start = DateTime.Now;
            counters.InefficientCounter(input10000); //O(n^2)
            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));

            DateTime start2 = DateTime.Now;
            counters.EfficientCounter(input10000); //O(n)
    	    DateTime end2 = DateTime.Now;
            Console.WriteLine("Time this took: " + end2.Subtract(start2));*/

            //Exercise 2
            /*LongestRepetition p = new LongestRepetition();

            Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
            Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5*/

            /*Changes m = new Changes();
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 2, 2 })); // 2
            Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
            Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 2*/

            Revolutions r = new Revolutions();
            Console.WriteLine(r.Calculate(new int[] { 4, 1, 3, 2, 5 })); // 3
            Console.WriteLine(r.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
            Console.WriteLine(r.Calculate(new int[] { 5, 4, 3, 2, 1 })); // 5
            
        }
    }
}
