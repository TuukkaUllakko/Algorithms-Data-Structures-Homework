using System;
using System.Collections.Generic;

namespace part5
{
    class Communication
    {
        private int computers;
        private List<int>[] graph;
        public Communication(int n)
        {
            this.computers = n;
            this.graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                this.graph[i] = new List<int>();
            }
        }
        public void AddConnection(int a, int b)
        {
            this.graph[a].Add(b);
            this.graph[b].Add(a);
        }
        public bool Examine(int x, int y)
        {
            bool[] visited = new bool[this.computers];
            SearchRecursively(x, visited);

            return visited[y - 1];
        }
        public void SearchRecursively(int v, bool[] visited)
        {
            if (visited[v - 1] == true)
            {
                return;
            }
            visited[v - 1] = true;

            foreach(int i in this.graph[v])
            {
                SearchRecursively(i, visited);
            }
        }
    }
}