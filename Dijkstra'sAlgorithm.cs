using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DijkstraApp
{
    public partial class Dijkstra_sAlgorithm : Form
    {

        public Dijkstra_sAlgorithm()
        {
            InitializeComponent();

            string start = MainForm.selectedStartVertex.ToString();                         // название стартовой вершины                      
            string end = MainForm.selectedEndVertex.ToString();                             // название конечной вершины 
            From.Text = start;                                                              // вывод стартовой вершины
            To.Text = end;                                                                  // вывод стартовой вершины

            List<string> res = Controller.Dj(start, end, out double length);                // выпонение алгоритма Дейкстры
            // вывод длины пути и самого пути
            Way.Text = null; Length.Text = null;
            if (res == null)
            {
                Way.Text = "Путь из точки " + start + " в точку " + end + " не существует!";
                Length.Text = length.ToString();
            }
            else
            {
                for (int i = 0; i < res.Count; i++)
                {
                    if (i == res.Count - 1)
                        Way.Text += res[i].ToString();
                    else
                        Way.Text += res[i].ToString() + " -> ";
                }
                Length.Text = Convert.ToString(length);
            }
            
            List<string> visited = new List<string>(Controller.listAllVertex);              // список вершин для посещения
            visited.Remove(start);                                                          // удаления стартовой вершины из списка вершин для посещения                                            
            List<string> vertexWithShortestDistance = new List<string>();                   // список отмеченных вершин
            for (int i = 0; i < Controller.dj.Count; i++)
                if (vertexWithShortestDistance.Contains(Controller.dj.ElementAt(i).StartVertex) == false)
                    vertexWithShortestDistance.Add(Controller.dj.ElementAt(i).StartVertex); // формирование списка отмеченных вершин

            dijkstraGriedView.ColumnCount = visited.Count + 1;                              // количество столбцов в таблице
            dijkstraGriedView.RowCount = vertexWithShortestDistance.Count + 1;              // количество строк в таблице
            for (int i = 0; i < visited.Count; i++)
                dijkstraGriedView.Rows[0].Cells[i + 1].Value = visited.ElementAt(i);        // заполнение первой строки вершинами для посещения
            for (int i = 0; i < vertexWithShortestDistance.Count; i++)
                dijkstraGriedView.Rows[i + 1].Cells[0].Value = vertexWithShortestDistance.ElementAt(i); // заполнение первого столбца отмеченными вершинами
            // заполнение таблицы выполнения алгоритма Дейкстры
            for (int i = 0; i < vertexWithShortestDistance.Count; i++)
                for (int j = 0; j < visited.Count; j++)
                {
                    bool ok = false;
                    foreach (var e in Controller.dj)
                    {
                        if (e.StartVertex == vertexWithShortestDistance.ElementAt(i) && e.EndVertex == visited.ElementAt(j))
                        {
                            dijkstraGriedView.Rows[i + 1].Cells[j + 1].Value = e.Distance;
                            ok = true;
                        }
                    }
                    if (ok == false)
                        dijkstraGriedView.Rows[i + 1].Cells[j + 1].Value = double.PositiveInfinity;
                }    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // оформление ссылки на форму "создание матрицы смежности"
        {
            MakeAdjacencyMatrix adjacencyMatrix = new MakeAdjacencyMatrix();
            adjacencyMatrix.ShowDialog();
        }
    }
}
