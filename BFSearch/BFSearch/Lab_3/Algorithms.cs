using System;
using System.Collections.Generic;

namespace Lab_3
{
    /// <summary>
    ///Класс с набором всех методов для обхода в ширину и поиска кротчайших путей
    /// </summary>
    class Algorithms
    {
        /// <summary>
        /// <typeparam name="T"> тип данных</typeparam>
        /// <param name="graph"> граф, в котором будем производить поиск</param>
        /// <param name="start"> стартовая вершина для поиска</param>
        /// <param name="preVisit"> передаваемая функция, которая будет вызываться каждый раз при посещении</param>
        /// <returns>пройденные вершины</returns>
        /// </summary>
        public HashSet<T> BFS<T>(Graph<T> graph, T start, Action<T> preVisit = null)
        {
            var visited = new HashSet<T>();

            if (!graph.AdjacencyList.ContainsKey(start)) // если стартовой вершины нет в графе, то завершаем выаолнение и вернем null !! обработка исключения в MAin
                return visited;

            var queue = new Queue<T>(); // иначе создаем очередь 
            queue.Enqueue(start); // добавили стартовую вершину

            while (queue.Count > 0) // пока не прошли до конца
            {
                var vertex = queue.Dequeue(); // на каждом шаге извлекаем из очереди по элементу

                if (visited.Contains(vertex)) // если текущая уже посещена. то прпускаем итерацию и удалим ее выше
                    continue;

                preVisit?.Invoke(vertex); // если переданная функция != null то вызываем ее и передаем вершину

                visited.Add(vertex); // добавляем в посещенные

                foreach (var neighbor in graph.AdjacencyList[vertex]) // перебор непосещенных соседних вершин (в графе)
                    if (!visited.Contains(neighbor))
                        queue.Enqueue(neighbor);
            }
            return visited; // возвр результата
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="graph"> Граф. в котором будем производить поиск</param>
        /// <param name="start"> стартовая вершина</param>
        /// <returns>функцию с "перечислениеv в виде списка с пройденными врешинами" обратившись к которой можно получить нужный путь</returns>
        public Func<T, IEnumerable<T>> ShortestPathFunction<T>(Graph<T> graph, T start)
        {
            var firstSearch = new Dictionary<T, T>(); // словарь в котором будем хранить 

            var queue = new Queue<T>();
            queue.Enqueue(start);

            //первичный проход в ширину, который даст информацию как из указанной вершины попасть в любой другой узел
            while (queue.Count > 0) // пока не пусто
            {
                var vertex = queue.Dequeue(); // удаляем вершину
                foreach (var neighbor in graph.AdjacencyList[vertex])//если есть соседи то прокладываем путь
                {
                    if (firstSearch.ContainsKey(neighbor))
                        continue;

                    firstSearch[neighbor] = vertex;
                    queue.Enqueue(neighbor);
                }
            }

            // теперь можем путем обращения к словарю путей (firstSearch выше) найти список перемещений к каждой вершине
            // !!! будем искать путь от "каждой" к первой, поэтому нужно будет перевернуть список элементов 
            IEnumerable<T> shortestPath(T v)
            {
                var path = new List<T>();

                var current = v;
                while (!current.Equals(start))
                {
                    path.Add(current);
                    current = firstSearch[current];
                };

                path.Add(start); // добавляем конечный узел
                path.Reverse(); // переворот пути

                return path;
            }

            return shortestPath;
        }
    }
}