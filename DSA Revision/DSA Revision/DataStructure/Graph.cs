using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Revision.DataStructure
{
    class Graph
    {
        private int numVertices;
        private List<List<int>> adjacencyList;

        public int NumVertices => numVertices;

        public Graph(int vertices)
        {
            numVertices = vertices;
            adjacencyList = new List<List<int>>(numVertices);

            for (int i = 0; i < numVertices; i++)
            {
                adjacencyList.Add(new List<int>());
            }
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
            adjacencyList[destination].Add(source);
        }
        public List<int> GetAdjacentVertices(int vertex)
        {
            return adjacencyList[vertex];
        }
        public void PrintGraph()
        {
            for (int i = 0; i < numVertices; i++)
            {
                Console.Write("Vertex " + i + " is connected to: ");
                foreach (int vertex in adjacencyList[i])
                {
                    Console.Write(vertex + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
