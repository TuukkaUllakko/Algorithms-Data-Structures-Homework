using System;

namespace part6
{
    class FloydWarshall
    {
        private int cities;
        private int[,] graph;
        public FloydWarshall(int n)
        {
            this.cities = n;
            this.graph = new int[n + 1, n + 1];
        }
        public void AddRoad(int a, int b, int d)
        {
            this.graph[a, b] = d;
            this.graph[b, a] = d;
        }
        public int Calculate(int x, int y)
        {
            int[,] dist = new int[this.cities + 1, this.cities + 1]; //Temporary matrix for filling the "empty" matrix
            int infinity = int.MaxValue;

            for (int i = 0; i <= this.cities; i++)
            {
                for (int j = 0; j <= this.cities; j++)
                {
                    dist[i, j] = this.graph[i, j];
                    if (this.graph[i, j] == 0)
                    {
                        dist[i, j] = infinity;
                    }
                    if (i == j)
                    {
                        dist[i, j] = 0;
                    }
                }
            }

            for (int k = 0; k <= this.cities; k++)
            {
                for (int i = 0; i <= this.cities; i++)
                {
                    for (int j = 0; j <= this.cities; j++)
                    {
                        if (dist[i, k] != infinity && dist[k, j] != infinity && dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }
            return Print(dist, x, y);
        }
        public int Print(int[,] dist, int x, int y)
        {
            int pathLength = 0;
            for (int i = 0; i <= this.cities; i++)
            {
                for (int j = 0; j <= this.cities; j++)
                {
                    if (i == x && j == y)
                    {
                        pathLength = pathLength + dist[i, j];
                    }
                }
            }
            return pathLength;
        }
    }
}