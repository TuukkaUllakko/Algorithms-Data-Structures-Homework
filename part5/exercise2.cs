using System;
using System.Collections.Generic;

namespace part5
{
    class Connectivity
    {
        private int computers;
        private List<int>[] graph;
        public Connectivity(int n)
        {
            this.computers = n;
            this.graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                graph[i] = new List<int>();
            }
        }
        public void AddConnection(int a, int b)
        {
            this.graph[a].Add(b);
            this.graph[b].Add(a);
        }
        public int Calculate(int x)
        {
            bool[] visited = new bool[this.computers];
            SearchRecursively(x, visited);

            int amount = 0;
            foreach (bool node in visited)
            {
                if (node == true)
                {
                    amount++;
                }
            }
            return amount - 1;
            
        }
        public void SearchRecursively(int x, bool[] visited)
        {
            if (visited[x - 1] == true)
            {
                return;
            }
            visited[x - 1] = true;

            foreach (int i in this.graph[x])
            {
                SearchRecursively(i, visited);
            }
        }
    }
}