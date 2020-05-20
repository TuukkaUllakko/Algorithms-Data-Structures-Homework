using System;

namespace part3
{
    class Exercise1
    {
        public void Hello(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n - 1);
            }
        }
    }
}