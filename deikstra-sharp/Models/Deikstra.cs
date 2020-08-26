using System;
using System.Collections.Generic;
using System.Text;

namespace deikstra_sharp.Models
{
    public class Deikstra
    {
        /// <summary>
        /// Quantity of vertices in the graph
        /// </summary>
        public int QuantityVertex
        {
            get { return quantityVertex; }
            set
            {
                quantityVertex = value;
                matrix = new decimal[quantityVertex, quantityVertex];
            }
        }
        private int quantityVertex;

        /// <summary>
        /// Adjacency matrix (dimension [QuantityVertex, QuantityVertex])
        /// </summary>
        public decimal[,] Matrix
        {
            get
            {
                return matrix;
            }
            set
            {
                if (value.GetLength(0) == value.GetLength(1))
                {
                    for (int i = 0; i < value.GetLength(0); i++)
                    {
                        value[i, i] = decimal.MaxValue;
                    }
                    quantityVertex = value.GetLength(0);
                    matrix = value;
                }
            }
        }
        private decimal[,] matrix;

        /// <summary>
        /// Start algorithm Deikstra
        /// </summary>
        /// <param name="fromVertex">The vertex from which the shortest path to all the others (0..N)</param>
        public decimal[] Start(int fromVertex)
        {
            decimal min = decimal.MaxValue;
            uint u = 0;
            decimal[] roads = new decimal[quantityVertex];

            var T = new SortedSet<long>();
            for (long i = 0; i < quantityVertex; i++)
                T.Add(i);

            for (int i = 0; i < quantityVertex; i++)
                roads[i] = matrix[fromVertex, i];

            roads[fromVertex] = 0;

            while (T.Count != 0)
            {
                min = long.MaxValue;

                for (uint i = 0; i < quantityVertex; i++)
                {
                    if (T.Contains(i) && roads[i] <= min)
                    {
                        min = roads[i];
                        u = i;
                    }
                }

                T.Remove(u);
                
                for (uint i = 0; i < QuantityVertex; i++)
                {
                    if (T.Contains(i) && !(roads[i] < roads[u] + matrix[u, i]))
                        roads[i] = roads[u] + matrix[u, i];
                }
            }
            return roads;
        }
    }
}
