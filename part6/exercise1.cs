using System;
using System.Collections.Generic;

namespace part6
{
    class BellmanFord
    {
        private int cities;
        private List<Edges> edges;
        public BellmanFord(int n)
        {
            this.cities = n;
            this.edges = new List<Edges>();
        }
        public void AddRoad(int a, int b, int d)
        {
            this.edges.Add(new Edges(a, b, d));
            this.edges.Add(new Edges(b, a, d));
        }
        public int Calculate(int x, int y)
        {
            int[] distance = new int[this.cities + 1];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = int.MaxValue;
            }
            distance[x] = 0;

            while (true)
            {
                bool change = false;

                foreach (Edges edge in this.edges)
                {
                    if (distance[edge.beginning] != int.MaxValue && (distance[edge.beginning] + edge.distance) < distance[edge.end])
                    {
                        distance[edge.end] = (distance[edge.beginning] + edge.distance);
                        change = true;
                    }
                }
                if (change == false)
                {
                    break;
                }
            }
            return distance[y];
        }
    }
    class Edges
    {
        public int beginning;
        public int end;
        public int distance;

        public Edges(int beginning, int end, int distance)
        {
            this.beginning = beginning;
            this.end = end;
            this.distance = distance;
        }
    }
}