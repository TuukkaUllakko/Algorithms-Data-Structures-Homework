using System;
using System.Collections.Generic;

namespace part5
{
    class Components
    {
        private int computers;
        private List<int>[] graph;
        public Components(int n)
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
        public int Calculate()
        {
            int connected = 0;
            int search = 1;
            bool[] visited = new bool[this.computers];
            foreach (bool i in visited)
            {
                if (i != true)
                {
                    DFS(search, visited);
                    connected++;
                }
                search++;
            }
            return connected;
        }

        public void DFS(int k, bool[] visited)
        {
            if (visited[k - 1] == true)
            {
                return;
            }
            visited[k - 1] = true;
            foreach (int x in this.graph[k])
            {
                DFS(x, visited);
            }
        }
    }
}