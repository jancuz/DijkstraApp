using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DijkstraApp
{
    class DijkstraData
    {
        public string Previous { get; set; }                                         // предыдущая вершина
        public double Price { get; set; }                                            // расстояние между вершинами
    }

    class Controller
    {
        public static List <Vertex> list = new List <Vertex>();                     // список ребер, введенных пользователем
        public static List<Vertex> dj = new List<Vertex>();                         // список полученных значений улучшенного расстояния 
                                                                                    // на каждой итерации для посещенных вершин до всех остальных
        public static List <String> listAllVertex = new List<String>();             // список всех вершин графа
        public static double[,] adjacencyMatrix;                                    // матрица смежности

        // проверка существования добавляемого ребра
        public static bool CheckAdd(Vertex addInf)
        {
            for (int i = 0; i < list.Count; i++)                                    // для каждого ребра в списке ребер
                if ((((list.ElementAt(i).StartVertex == addInf.StartVertex &&       // если начальная вершина текущего ребра равна начальной вершине 
                                                                                    // добавляемого ребра и
                    list.ElementAt(i).EndVertex == addInf.EndVertex) ||             // конечная вершина текущего ребра равна конечной вершине 
                                                                                    // добавляемого ребра или
                    (list.ElementAt(i).StartVertex == addInf.EndVertex &&           // наоборот, то
                    list.ElementAt(i).EndVertex == addInf.StartVertex))))
                    return false;                                                   // добавление невозможно
            return true;
        }

        // проверка изменения ребра
        public static bool CheckCorrect(Vertex correctInf)
        {
            for (int i = 0; i < list.Count; i++)                                    // для каждого ребра в списке ребер
                if ((((list.ElementAt(i).StartVertex == correctInf.StartVertex &&   // если начальная вершина текущего ребра равна начальной вершине 
                                                                                    // измененного ребра и 
                    list.ElementAt(i).EndVertex == correctInf.EndVertex) ||         // конечная вершина текущего ребра равна конечной вершине 
                                                                                    // измененного ребра или
                    (list.ElementAt(i).StartVertex == correctInf.EndVertex &&       // наоборот и
                    list.ElementAt(i).EndVertex == correctInf.StartVertex))) &&
                    list.ElementAt(i).Distance == correctInf.Distance)              // расстояние текущего ребра равно измененному расстоянию,
                    return false;                                                   // изменение ребра невозможно.
            return true;
        }

        // формирование списка всех вершин
        public static void MakeListAllVertex()
        {
            listAllVertex.Clear();
            listAllVertex.Add(list.ElementAt(0).StartVertex);                       // в список всех вершин добавляются начальная и конечная вершины
            listAllVertex.Add(list.ElementAt(0).EndVertex);                         // первого ребра в списке ребер

            for (int i = 1; i < list.Count; i++)                                    // для каждого ребра в списке ребер
            {
                string add1 = list.ElementAt(i).StartVertex;                        // начальная вершина текущего ребра
                string add2 = list.ElementAt(i).EndVertex;                          // конечная вершина текущего ребра
                bool ok1 = true, ok2 = true;
                int n = listAllVertex.Count;                                        // количество всех вершин в списке всех вершин
                int j = 0;
                while (j != n)                                                      // для каждой вершины в списке всех вершин
                {
                    if (listAllVertex.ElementAt(j) == add1)                         // если текущая вершина в списке всех вершин равна начальной вершине,
                    {
                        ok1 = false;                                                // начальная вершина не может быть добавлена
                    }
                    if (listAllVertex.ElementAt(j) == add2)                         // если текущая вершина в списке всех вершин равна конечной вершине,
                    {
                        ok2 = false;                                                // конечная вершина не может быть добавлена
                    }
                    j++;
                }
                if (ok1 == true)
                    listAllVertex.Add(add1);                                        // добавление начальной вершины текущего ребра в список всех ребер
                if (ok2 == true)
                    listAllVertex.Add(add2);                                        // добавление конечной вершины текущего ребра в список всех ребер
            }
        }

        // создание матрицы смежности
        public static void CreateAdjacencyMatrix()
        {
            MakeListAllVertex();                                                    // создание списка всех вершин графа
            adjacencyMatrix = new double[listAllVertex.Count, listAllVertex.Count];
            for (int i = 0; i < listAllVertex.Count; i++)
                for (int j = 0; j < listAllVertex.Count; j++)
                {
                    if (i == j)
                        adjacencyMatrix[i, j] = 0;
                    else
                    {
                        bool ok = false;
                        foreach (Vertex str in list)                                // для каждого ребра в списке ребер
                        {
                            if (str.StartVertex == listAllVertex.ElementAt(i) &&    // если начальная вершина текущего ребра равна вершине 
                                                                                    // из списка всех ребер и
                                str.EndVertex == listAllVertex.ElementAt(j) ||      // конечная вершина текущего ребра равна вершине из спика всех ребер или
                                str.StartVertex == listAllVertex.ElementAt(j) &&    // наоборот
                                str.EndVertex == listAllVertex.ElementAt(i))
                            {
                                adjacencyMatrix[i, j] = str.Distance;               // симметричные ячейки матрицы смежности заполняются длиной текущего
                                adjacencyMatrix[j, i] = str.Distance;               // ребра
                                ok = true;
                            }
                        }
                        if (ok == false)                                            // если ячейка не была заполнена,
                        {
                            adjacencyMatrix[i, j] = double.PositiveInfinity;        // симметричные ячейки матрицы смежности заполняются 
                            adjacencyMatrix[j, i] = double.PositiveInfinity;        // значением бесконечности
                        }
                    }
                }
        }

        // алгоритм Дейкстры
        public static List<string> Dj(string start, string end, out double length)
        {
            dj.Clear();
            List<string> notVisited = new List<String>();                           // создание списка непосещенных вершин
            for (int i = 0; i < listAllVertex.Count; i++)
                notVisited.Add(listAllVertex.ElementAt(i));
            Dictionary<string, DijkstraData> track =                                // создание словаря для хранения данных о пути
                new Dictionary<string, DijkstraData>();
            track[start] = new DijkstraData { Price = 0, Previous = null };         // стартовой вершине присваивается 0
            // поиск кратчайшего пути
            for (int i = 0; i < listAllVertex.Count; i++)                           // для каждой из вершин в списке всех вершин
            {
                length = double.PositiveInfinity;                                   // длина пути равна бесконечности
                string toOpen = null;                                               // посещенная вершина
                var bestPrice = double.PositiveInfinity;                            // кратчайшее расстояние
                // поиск вершины с минимальным весом
                foreach (var e in notVisited)                                       // для каждой вершины из непосещенных
                {                                                                   // ищется вершина с минимальным весом, уже существующая в словаре
                    if (track.ContainsKey(e) && track[e].Price < bestPrice)         // если такая вершина найдена, то
                    {
                        bestPrice = track[e].Price;                                 // кратчайшее расстояние становиться равным длине пути до выбранной вершины 
                        toOpen = e;                                                 // посещенной вершиной становиться выбранная вершина
                    }
                }

                if (toOpen == null) return null;                                    // если посещенная вершина не найдена, 
                                                                                    // пути между заданными вершинами не сущствует
                if (toOpen == end) break;                                           // если посещенная вершина равна конечной, работа алгоритма завершается

                foreach (var e in list)                                             // для каждого ребра в списке ребер
                {
                    if (toOpen == e.StartVertex)                                    // если посещенная вершина равна начальной вершине текущего ребра
                    {
                        var currentPrice = track[toOpen].Price + e.Distance;        // расстояние от стартовой вершины до конечной вершины текущего ребра с учетом 
                                                                                    // посещенной вершины
                        var nextVertex = e.EndVertex;                               // следующая вершина пути
                        if (!track.ContainsKey(nextVertex) || track[nextVertex].Price > currentPrice)// если следующая вершина не существует в словаре или
                        { // расстояние до следующей вершины с учетом посещенной вершины меньше, чем длина пути до следующей вершины без учета посещенной вершины 
                            track[nextVertex] = new DijkstraData { Previous = toOpen, Price = currentPrice }; // следующая вершина добавляется в путь
                            Vertex add = new Vertex(toOpen, nextVertex, currentPrice);
                            dj.Add(add); // добавление улучшенного расстояния в список полученных значений улучшенного расстояния
                        }
                    }

                    if (toOpen == e.EndVertex)                                      // если посещенная вершина равна конечной вершине текущего ребра
                    {
                        var currentPrice = track[toOpen].Price + e.Distance;        // расстояние от стартовой вершины до конечной вершины текущего ребра с учетом
                                                                                    // посещенной вершины 
                        var nextVertex = e.StartVertex;                             // следующая вершина пути
                        if (!track.ContainsKey(nextVertex) || track[nextVertex].Price > currentPrice)// если следующая вершина не существует в словаре или
                        { // расстояние до следующей вершины с учетом посещенной вершины меньше, чем длина пути до следующей вершины без учета посещенной вершины 
                            track[nextVertex] = new DijkstraData { Previous = toOpen, Price = currentPrice }; // следующая вершина добавляется в путь
                            Vertex add = new Vertex(toOpen, nextVertex, currentPrice);
                            dj.Add(add); // добавление улучшенного расстояния в список полученных значений улучшенного расстояния
                        }
                    }
                }
                notVisited.Remove(toOpen);
            }

            var result = new List<string>();                                        // кратчайший путь
            length = track[end].Price;                                              // длина кратчайшего пути
            // составление кратчайшего пути от конечной до стартовой вершины, заданных пользователем
            while (end != null)
            {
                result.Add(end);
                end = track[end].Previous;
            }
            result.Reverse();                                                       // переворот составленного пути
            return result;
        }
    }
}
