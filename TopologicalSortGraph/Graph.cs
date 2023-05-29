using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopologicalSortGraph
{
    public class Graph
    {
        private int verticesCount;
        private List<int>[] adjacencyList;

        public Graph(int v)
        {
            verticesCount = v;
            adjacencyList = new List<int>[verticesCount];
            for (int i = 0; i < verticesCount; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
        }

        public List<int> TopologicalSort()
        {
            List<int> result = new List<int>();
            bool[] visited = new bool[verticesCount];

            for (int i = 0; i < verticesCount; i++)
            {
                if (!visited[i])
                {
                    DFS(i, visited, result);
                }
            }

            result.Reverse();
            return result;
        }

        private void DFS(int vertex, bool[] visited, List<int> result)
        {
            visited[vertex] = true;

            foreach (int neighbor in adjacencyList[vertex])
            {
                if (!visited[neighbor])
                {
                    DFS(neighbor, visited, result);
                }
            }

            result.Add(vertex);
        }
    }
}
