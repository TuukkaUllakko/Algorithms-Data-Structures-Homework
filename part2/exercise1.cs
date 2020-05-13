using System;
using System.Text;

namespace part2
{
    class Counters
    {
        public void InefficientCounter(string n) //O(n^2)
        {
            int counter = 0;

            for (int i = 0; i <= n.Length - 1; i++)
            {
                for (int j = i + 1; j <= n.Length - 1; j++)
                {
                    if (n[i].ToString() == "0" && n[j].ToString() == "1")
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        public void EfficientCounter(string n) //O(n)
        {
            int counter = 0;
            int zeros = 0;
            for (int i = 0; i <= n.Length - 1; i++)
            {
                if (n[i].ToString() == "0")
                {
                    zeros = zeros + 1;
                }
                else
                {
                    counter = counter + zeros;
                }
            }
            Console.WriteLine(counter);
        }

        public string CreateInput(int n) //Input generator
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                sb.Append(random.Next(0, 2).ToString());
            }
            return sb.ToString();
        }
    }
}