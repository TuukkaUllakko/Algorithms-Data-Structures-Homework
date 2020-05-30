using System;

namespace part4
{
    public class CircleGame
    {
        public int Last(int n)
        { 
            int lastNumber = 0;
            int last = 1;

            for (int i = 2; i <= n; i = i * 2)
            {
                lastNumber = i;
            }
          
            for (int i = lastNumber; i < n; i++)
            {
                last = last + 2;
            }
          
            return last;
        }
    }
}