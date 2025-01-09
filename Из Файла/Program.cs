using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Граф представлен в виде словаря смежности
        var graph = new Dictionary<string, List<string>>
        {
            { "A", new List<string> { "B", "C" } },
            { "B", new List<string> { "A", "D", "E" } },
            { "C", new List<string> { "A", "F" } },
            { "D", new List<string> { "B" } },
            { "E", new List<string> { "B", "F" } },
            { "F", new List<string> { "C", "E" } }
        };

        // Стартовая и конечная вершины
        string start = "A";
        string end = "F";

        // Найти кратчайший путь
        var path = FindShortestPathBFS(graph, start, end);

        // Вывод результата
        if (path != null)
        {
            Console.WriteLine($"Кратчайший путь из {start} в {end}: {string.Join(" -> ", path)}");
        }
        else
        {
            Console.WriteLine($"Путь из {start} в {end} не найден.");
        }
    }

    static List<string> FindShortestPathBFS(Dictionary<string, List<string>> graph, string start, string end)
    {
        // Очередь для хранения текущих вершин и пути к ним
        var queue = new Queue<List<string>>();
        queue.Enqueue(new List<string> { start });

        // Множество посещенных вершин
        var visited = new HashSet<string> { start };

        while (queue.Count > 0)
        {
            // Получаем текущий путь из очереди
            var path = queue.Dequeue();
            string current = path[^1]; // Последний элемент в пути

            // Если достигли конечной вершины, возвращаем путь
            if (current == end)
            {
                return path;
            }

            // Обходим соседей текущей вершины
            foreach (var neighbor in graph[current])
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);

                    // Создаем новый путь, добавляя соседа, и помещаем в очередь
                    var newPath = new List<string>(path) { neighbor };
                    queue.Enqueue(newPath);
                }
            }
        }

        // Путь не найден
        return null;
    }
}
