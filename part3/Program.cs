﻿using System;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random number generator
            static int[] Randomizer(int n)
            {
                Random random = new Random();
                int[] arr = new int[n];
                for (int i = 0; i < arr.Length; i++)
                {
                    // integers between 1 and 1000 are enough for us
                    arr[i] = random.Next(1, 1001);
                }
                return arr;
            }

            /*//Exercise 1
            Exercise1 hello = new Exercise1();
            hello.Hello(5);*/

            /*//Exercise 2
            SmallestDifference s = new SmallestDifference();
            Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
            Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
            Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0*/

            /*//Exercise 3 NOT DONE!!!!!

            Sorting s = new Sorting();
            int[] sortMe = Randomizer(100);
            int[] sortMeLarge = Randomizer(1000000);

            DateTime start = DateTime.Now;
            s.QuickSort(sortMe);
            DateTime end = DateTime.Now;
            Console.WriteLine("Time this took: " + end.Subtract(start));

            DateTime start2 = DateTime.Now;
            s.MergeSort(sortMe);
            DateTime end2 = DateTime.Now;
            Console.WriteLine("Time this took: " + end2.Subtract(start2));

            DateTime start3 = DateTime.Now;
            s.QuickSort(sortMeLarge);
            DateTime end3 = DateTime.Now;
            Console.WriteLine("Time this took: " + end3.Subtract(start3));

            DateTime start4 = DateTime.Now;
            s.MergeSort(sortMeLarge);
            DateTime end4 = DateTime.Now;
            Console.WriteLine("Time this took: " + end4.Subtract(start4));*/

            /*//Exercise 4
            BinarySearch b = new BinarySearch();
            Console.WriteLine(b.Find((new int[] { 4, 1, 8, 5 }), 2)); // false
            Console.WriteLine(b.Find((new int[] { 0, 0 }), 0)); // true
            Console.WriteLine(b.Find((new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }), 2)); // true
            Console.WriteLine(b.Find((new int[] { 0 }), 0)); // true*/

            //Exercise 5
            Inversions inv = new Inversions();
            int[] t = inv.Create(5, 2);
            foreach (int i in t)
            {
                Console.Write(i + " ");  // 2 1 3 5 4
            }

        }
    }
}
