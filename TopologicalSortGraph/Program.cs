using System;

namespace TopologicalSortGraph
{
    public class Program // Графы, топологическая сортировка
    {
        public static void Main()
        {
            int verticesCount = 9;
            Graph graph = new Graph(verticesCount);

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 5);
            graph.AddEdge(4, 8);
            graph.AddEdge(5, 8);
            graph.AddEdge(3, 6);
            graph.AddEdge(6, 7);
            graph.AddEdge(7, 8);

            List<int> sortedVertices = graph.TopologicalSort();

            Console.WriteLine("Результат топологической сортировки:");
            foreach (int vertex in sortedVertices)
            {
                Console.Write(vertex + " ");
            }
        }
    }
}
