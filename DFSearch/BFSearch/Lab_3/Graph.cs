using System;
using System.Collections.Generic;

namespace Lab_3
{
    public class Graph<T>
    {
        public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>(); // словарь из смежных вершин 

        public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex); // добавляем вершину

            foreach (var edge in edges)
                AddEdge(edge);  // добавляем ребро  пример (1,3)
        }

        public void AddVertex(T vertex)
        {
            AdjacencyList[vertex] = new HashSet<T>(); // добавляем в HASHset вершины без повторений
        }

        public void AddEdge(Tuple<T, T> edge) 
        {
            if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
            {
                AdjacencyList[edge.Item1].Add(edge.Item2);
                AdjacencyList[edge.Item2].Add(edge.Item1);
            }
        }
    }
}