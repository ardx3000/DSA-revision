using DSA_Revision.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Revision.Alghorithms.Search
{
    class DepthFirstSearch
    {
        private bool[] visited;
        private Graph graph;

        public DFS(Graph graph)
        {
            this.graph = graph;
            visited = new bool[graph.NumVertices];
        }

        public void Traverse(int startVertex)
        {
            DFSRecursive(startVertex);
        }

        private void DFSRecursive(int currentVertex)
        {
            visited[currentVertex] = true;
            Console.Write(currentVertex + " ");

            foreach (int adjacentVertex in graph.GetAdjacentVertices(currentVertex))
            {
                if (!visited[adjacentVertex])
                {
                    DFSRecursive(adjacentVertex);
                }
            }
        }
    }
}
