using System;
namespace rehearsal_exercises

{
    public class Numbers
    {
        public int Steps(int x)
        {
            int steps = 0;
            int adder = 1;
            int sum = 0;

            while(sum < x)
            {
                sum = sum + adder;
                steps++;
                adder++;
            }

            return steps;
        }
    }
}