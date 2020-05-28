using System;

namespace part4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1
            LinkedList myLinks = new LinkedList();
            myLinks.AddLast(1);
            myLinks.AddFirst(2);
            myLinks.AddLast(3);
            Console.WriteLine(myLinks); // for example: 2, 1, 3
            myLinks.RemoveFirst();
            Console.WriteLine(myLinks); // for example: 1, 3
            Console.WriteLine(myLinks.GetNode(0)); // 1
            Console.WriteLine(myLinks.GetNode(1)); // 3
            //Exercise 2

            //Exercise 3

            //Exercise 4

            /*//Exercise 5
            Order o = new Order();
            int[] a = { 4, 2, 1, 3, 5 };
            int[] b = { 2, 4, 3, 1, 5 };
            int[] c = o.Create(a, b);
            Console.WriteLine(String.Join(" ", c)); // 2 3 5 1 4*/
        }
    }
}
