using System;
using System.Collections.Generic;
using System.Linq;

namespace rehearsal_exercises

{
    public class ShortenArray
    {
        public int Calculate(int[] input)
        {
            List<int> list = new List<int>();
            list = input.ToList();

            for(int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list.RemoveAt(i + 1);
                    list.RemoveAt(i);
                    i = -1;
                }
            }

            return list.Count;
        }
    }
}