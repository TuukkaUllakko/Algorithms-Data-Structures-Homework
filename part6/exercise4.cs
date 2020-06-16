using System;
using System.Collections.Generic;

namespace part6
{
    class ShortestPath
    {
        private int cities;
        private int[,] graph;
        public ShortestPath(int n)
        {
            this.cities = n;
            this.graph = new int[n + 1, n + 1];
        }
        public void AddRoad(int a, int b, int d)
        {
            graph[a, b] = d;
            graph[b, a] = d;
        }
        public List<int> Create(int x, int y)
        {
            int[] distance = new int[this.cities + 1];
            bool[] visited = new bool[this.cities + 1];
            int[] path = new int[this.cities + 1];

            for (int i = 0; i <= this.cities; i++)
            {
                distance[i] = int.MaxValue;
                visited[i] = false;
            }

            distance[x] = 0;
            path[x] = 0;

            for (int i = 0; i < this.cities - 1; i++)
            {
                int smallest = int.MaxValue;
                int smallestPos = 0;

                for (int j = 0; j <= this.cities; j++)
                {
                    if (visited[j] == false && distance[j] <= smallest)
                    {
                        smallest = distance[j];
                        smallestPos = j;
                    }
                }
                visited[smallestPos] = true;

                for (int j = 0; j <= this.cities; j++)
                {
                    if (!visited[j] && this.graph[smallestPos, j] != 0 && distance[smallestPos] != int.MaxValue && distance[smallestPos] + this.graph[smallestPos, j] < distance[j])
                    {
                        path[j] = smallestPos;
                        distance[j] = distance[smallestPos] + this.graph[smallestPos, j];
                    }
                }
            }
            //From array to list //doesn't work..
            List<int> listVisited = new List<int>(path);
            
            return listVisited;
        }
    }
}