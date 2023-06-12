using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Revision.Alghorithms
{
    class Dijkstra
    {
        private int numNodes;
        private int[,] graph;

        public Dijkstra(int[,] adjacencyMatrix)
        {
            numNodes = adjacencyMatrix.GetLength(0);
            graph = adjacencyMatrix;
        }

        public int[] FindShortestPaths(int sourceNode)
        {
            int[] distances = new int[numNodes];
            bool[] visited = new bool[numNodes];

            // Set all distances to infinity initially
            for (int i = 0; i < numNodes; i++)
            {
                distances[i] = int.MaxValue;
            }

            distances[sourceNode] = 0;

            // Main loop that runs for (n-1) iterations
            for (int i = 0; i < numNodes - 1; i++)
            {
                // Section contributing to O(n) time complexity
                int minDistanceNode = GetMinimumDistanceNode(distances, visited);
                visited[minDistanceNode] = true;

                // Inner loop that iterates over all nodes
                for (int j = 0; j < numNodes; j++)
                {
                    // Check if the node is unvisited and has a connection to the current node
                    if (!visited[j] && graph[minDistanceNode, j] != 0 && distances[minDistanceNode] != int.MaxValue
                        && distances[minDistanceNode] + graph[minDistanceNode, j] < distances[j])
                    {
                        // Update the distance if a shorter path is found
                        distances[j] = distances[minDistanceNode] + graph[minDistanceNode, j];
                    }
                }
            }

            return distances;
        }

        private int GetMinimumDistanceNode(int[] distances, bool[] visited)
        {
            int minDistance = int.MaxValue;
            int minDistanceNode = -1;

            // Loop to find the node with the minimum distance
            for (int i = 0; i < numNodes; i++)
            {
                // Check if the node is unvisited and has a smaller distance
                if (!visited[i] && distances[i] <= minDistance)
                {
                    minDistance = distances[i];
                    minDistanceNode = i;
                }
            }

            return minDistanceNode;
        }

    }
}
