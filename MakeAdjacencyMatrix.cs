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
    public partial class MakeAdjacencyMatrix : Form
    {
        public MakeAdjacencyMatrix()
        {
            InitializeComponent();

            Controller.CreateAdjacencyMatrix();
            adjacencyMatrix.ColumnCount = Controller.listAllVertex.Count + 1;                       // количество столбцов матрицы смежности
            adjacencyMatrix.RowCount = Controller.listAllVertex.Count + 1;                          // количество строк матрицы смежности
            for (int j = 0; j < Controller.listAllVertex.Count; j++)                                // вывод названия всех вершин графа
            {
                adjacencyMatrix.Rows[0].Cells[j + 1].Value = Controller.listAllVertex.ElementAt(j); // в первой строке,
                adjacencyMatrix.Rows[j + 1].Cells[0].Value = Controller.listAllVertex.ElementAt(j); // в первом столбце
            }
            for (int i = 0; i < Controller.listAllVertex.Count; i++)                                // вывод двумерного массива, содержащего расстояния
                for (int j = 0; j < Controller.listAllVertex.Count; j++)                            // между всеми вершинами, матрица смежности
                    adjacencyMatrix.Rows[i + 1].Cells[j + 1].Value = Controller.adjacencyMatrix[i, j]; 
        }
    }
}
