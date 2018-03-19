using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DijkstraApp
{
    class Vertex
    {
        public string StartVertex { get; set; }         // начальная вершина
        public string EndVertex { get; set; }           // конечная вершина
        public double Distance  { get; set; }           // расстояние между данными вершинами

        public Vertex()                                 // конструктор без параметров
        {
            StartVertex = null;
            EndVertex = null;
            Distance = double.PositiveInfinity;
        }

        public Vertex(string s, string e, double d)     // конструктор с параметрами
        {
            StartVertex = s;
            EndVertex = e;
            Distance = d;
        }

        public override string ToString()
        {
            return "Начальная вершина: " + StartVertex + " Конечная вершина: " + EndVertex + " Расстояние: " + Distance;
        }
    }
}
