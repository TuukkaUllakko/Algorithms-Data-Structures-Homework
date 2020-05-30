using System;
using System.Collections.Generic;

namespace part4
{
    class SmallestDistance
    {
        public List<int> list = new List<int>();
        public void Add(int x)
        {
            list.Add(x);
        }

        public int Calculate()
        {
            int smallestDistance = int.MaxValue;
            List<int> temp = new List<int>();
            temp = list;
            temp.Sort();

            if (temp.Count <= 1)
            {
                return 0;
            }

            for (int i = 0; i < temp.Count - 1; i++)
            {
                if (temp[i + 1] - temp[i] < smallestDistance)
                {
                    smallestDistance = temp[i + 1] - temp[i];
                }
            }

            return smallestDistance;
        }
    }
}