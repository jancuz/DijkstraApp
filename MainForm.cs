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
    public partial class MainForm : Form
    {
        int selectedRow;                                                // выбранная пользователем строка для изменения/удаления;
        public static string selectedStartVertex, selectedEndVertex;    // выбранные пользователем начальная и конечная вершины для поиска КП;

        public MainForm()
        {
            InitializeComponent();
        }

        // блокировка всех кнопок при загрузке формы;
        private void Form1_Load(object sender, EventArgs e)             
        {
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCorrect.Enabled = false;
            buttonOK.Enabled = false;
            buttonFind.Enabled = false;
        }

        // ввод начальной вершины
        private void textBoxStartVertex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13)) textBoxEndVertex.Focus();   //Enter
        }

        // ввод конечной вершины
        private void textBoxEndVertex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13)) textBoxDistance.Focus();    //Enter
        }

        // проверка ввода расстояния между вершинами
        private void textBoxDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&                             // Если введено не число и
                !(e.KeyChar.ToString() == ","))                         // не запятатая,
                e.Handled = true;                                       // сообщение о нажатии клавиши не должно передаваться элементу управления.
            if (e.KeyChar.Equals((char)13)) buttonAdd.Focus();          // Enter
        }

        // очищение текстовой области при нажатии клавиши "Backspace"
        private void textBoxDistance_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8)
            {
                textBoxDistance.Text = "";
            }
        }

        //проверка заполнения текстовых полей
        private void textBoxStartVertex_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBoxStartVertex.Text.Length > 0) && (textBoxEndVertex.Text.Length > 0)  // Если начальная и конечная вершины введены 
                && (textBoxStartVertex.Text != textBoxEndVertex.Text)                       // и не являются одинаковыми 
                && (textBoxDistance.Text.Length > 0))                                       // и расстояние между ними введено, 
                buttonAdd.Enabled = true;                                                   // добавление становиться возможным,
            else
                buttonAdd.Enabled = false;                                                  // иначе добавление невозможно.
        }

        private void textBoxEndVertex_KeyUp(object sender, KeyEventArgs e)
        {
            if ((textBoxStartVertex.Text.Length > 0) && (textBoxEndVertex.Text.Length > 0)  // Если начальная и конечная вершины введены 
                && (textBoxStartVertex.Text != textBoxEndVertex.Text)                       // и не являются одинаковыми 
                && (textBoxDistance.Text.Length > 0))                                       // и расстояние между ними введено, 
                buttonAdd.Enabled = true;                                                   // добавление становиться возможным,
            else
                buttonAdd.Enabled = false;
        }

        private void textBoxDistance_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxDistance.Text == "0" && textBoxDistance.Text.IndexOf('0') == 0 ||    // Если введен "0" 
               textBoxDistance.Text == "," && textBoxDistance.Text.IndexOf(',') == 0)       // или запятатая на первой позиции,
            {
                textBoxDistance.Clear();                                                    // текстовая область очищается.
            }
            if ((textBoxStartVertex.Text.Length > 0) && (textBoxEndVertex.Text.Length > 0)  // Если начальная и конечная вершины введены 
               && (textBoxStartVertex.Text != textBoxEndVertex.Text)                        // и не являются одинаковыми 
               && (textBoxDistance.Text.Length > 0))                                        // и расстояние между ними введено, 
                buttonAdd.Enabled = true;                                                   // добавление становиться возможным,
            else
                buttonAdd.Enabled = false;                                                  // иначе добавление невозможно.
        }

        // добавление ребра в список ребер
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Vertex addInf = new Vertex(textBoxStartVertex.Text, textBoxEndVertex.Text, Convert.ToDouble(textBoxDistance.Text)); // добавляемое ребро
            if (Controller.CheckAdd(addInf) == true)                                        // Если добавляемого ребра не существует в списке ребер,
            {
                Controller.list.Add(addInf);                                                // ребро добавляется в список,
                edgeList.DataSource = null;
                edgeList.DataSource = Controller.list;                                      // выводиться на форму в datagriedview,
                buttonOK.Enabled = true;
                buttonOK.DialogResult = DialogResult.None;                                  // функция иллюстрация работы алгоритма Дейкстры блокируется,
                buttonFind.Enabled = false;                                                 // кнопка поиска блокируется,
                buttonDelete.Enabled = true;                                                // кнопка удаления активируется,
                buttonCorrect.Enabled = true;                                               // кнопка изменения активируется,
                startVertex.Items.Clear();                                                  // списки начальной и конечной вершин очищаются,
                endVertex.Items.Clear();
                labelWay.Text = "";                                                         // путь и длина пути очищаются
                labelLengthWay.Text = "";
            }
            else
                MessageBox.Show("Добавляемое ребро уже существует.");                       // иначе выводиться сообщение об ошибке.
        }

        // выбор ребра из списка
        private void edgeGriedView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = edgeList.Rows[selectedRow];
            // вывод данных из выбранной строки таблицы в textboxes
            textBoxStartVertex.Text = row.Cells[0].Value.ToString();
            textBoxEndVertex.Text = row.Cells[1].Value.ToString();
            textBoxDistance.Text = row.Cells[2].Value.ToString();
        }

        // удаление ребра из списка ребер
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            selectedRow = edgeList.CurrentCell.RowIndex;                                    // выбранная строка
            Controller.list.RemoveAt(selectedRow);                                          // удаление выбранной строки из списка
            edgeList.DataSource = null;
            edgeList.DataSource = Controller.list;
            MessageBox.Show("Ребро удалено.");
            if (Controller.list.Count == 0)                                                 // Если список пуст,
            {
                buttonDelete.Enabled = false;                                               // кнопка удаления блокируется,
                buttonCorrect.Enabled = false;                                              // кнопка изменения блокируется,
                buttonOK.Enabled = false;                                                   // кнопка "ОК" блокируется,
                buttonFind.Enabled = false;                                                 // кнопка поиска КП блокируется,
                buttonOK.DialogResult = DialogResult.None;                                  // функция иллюстрации работы алгоритма Дейкстры и 
                                                                                            // создания матрицы смежности блокируется,
            }
            else
            {
                buttonOK.Enabled = true;                                                    // иначе кнопка "ОК" активируется,
                buttonFind.Enabled = false;                                                 // кнопка поиска КП активируется,
                buttonOK.DialogResult = DialogResult.None;                                  // функция иллюстрации работы алгоритма Дейкстры и 
                                                                                            // создания матрицы смежности блокируется.
            }
            startVertex.Items.Clear();                                                      // Списки начальной и конечной вершин очищаются
            endVertex.Items.Clear();
            labelWay.Text = "";
            labelLengthWay.Text = "";
        }

        // изменение ребра
        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            selectedRow = edgeList.CurrentCell.RowIndex;                                            // выбранное ребро для изменения
            Vertex correctInf;                                                                      // измененные данные
            if (Controller.list.ElementAt(selectedRow).StartVertex == textBoxStartVertex.Text &&    // Если данные для изменения не были изменены,
                Controller.list.ElementAt(selectedRow).EndVertex == textBoxEndVertex.Text &&
                Controller.list.ElementAt(selectedRow).Distance == Convert.ToDouble(textBoxDistance.Text))
                MessageBox.Show("Введите новые данные в текстовые поля.");                          // выводится сообщение об ошибке,
            else                                                                                    // иначе
            {
                if ((textBoxStartVertex.Text.Length == 0) || (textBoxEndVertex.Text.Length == 0) || // Если начальная или конечная вершины не введены
                    (textBoxStartVertex.Text == textBoxEndVertex.Text) ||                           // или являются одинаковыми
                    (textBoxDistance.Text.Length == 0))                                             // или расстояние между ними не введено,
                    MessageBox.Show("Некорректный ввод данных!");                                   // выводиться сообщение об ошибке
                else                                                                                // иначе
                {
                    buttonCorrect.Enabled = true;                                                   // кнопка изменения активируется,
                    correctInf = new Vertex(textBoxStartVertex.Text, textBoxEndVertex.Text, Convert.ToInt32(textBoxDistance.Text));
                    if (Controller.CheckCorrect(correctInf) == true)                                // если измененное ребро не существует в списке ребер,
                    {
                        Controller.list.ElementAt(selectedRow).StartVertex = textBoxStartVertex.Text;// изменение данных о ребре,
                        Controller.list.ElementAt(selectedRow).EndVertex = textBoxEndVertex.Text;
                        Controller.list.ElementAt(selectedRow).Distance = Convert.ToDouble(textBoxDistance.Text);
                        edgeList.DataSource = null;
                        edgeList.DataSource = Controller.list;
                        MessageBox.Show("Ребро изменено.");
                        buttonOK.Enabled = true;                                                    // кнопка "ОК" активируется,
                        buttonFind.Enabled = false;                                                 // кнопка найти КП блокируется,
                        buttonOK.DialogResult = DialogResult.None;                                  // функция иллюстрации работы алгоритма Дейкстры и 
                                                                                                    // создания матрицы смежности блокируется
                        startVertex.Items.Clear();                                                  // списки начальной и конечной вершин очищаются,
                        endVertex.Items.Clear();
                        labelWay.Text = "";
                        labelLengthWay.Text = "";
                    }
                    else                                                                            // иначе вывод сообщения об ошибке.
                        MessageBox.Show("Измененное ребро уже существует.");
                }
            }
        }

        // выбор начальной вершины
        private void startVertex_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStartVertex = startVertex.SelectedItem.ToString();
        }

        // выбор конечной вершины
        private void endVertex_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEndVertex = endVertex.SelectedItem.ToString();
        }

        // иллюстрация работы алгоритма Дейкстры
        private void проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (buttonOK.DialogResult != DialogResult.OK)                                           // Если кнопка "ОК" не была нажата,
                MessageBox.Show("Для того чтобы проиллюстрировать работу алгоритма Дейкстры, пожалуйста, заполните список ребер " +
                    "и нажмите кнопку ОК.");                                                        // вывод сообщения об ошибке,
            else                                                                                    // иначе
            {
                if (selectedStartVertex == null || selectedEndVertex == null)                       // если начальная или конечная вершины не выбраны,
                    MessageBox.Show("Для того чтобы проиллюстрировать работу алгоритма Дейкстры, пожалуйста, выберите начальную" +
                        " и конечную вершины графа.");                                              // вывод сообщения об ошибке,
                else                                                                                // иначе
                {
                    Dijkstra_sAlgorithm dijkstra = new Dijkstra_sAlgorithm();                       
                    dijkstra.ShowDialog();                                                          //вывод диалогового окна Dijkstra_sAlgorithm
                }
            }
        }

        // окончание формирования списка ребер, нажатие кнопки "ОК"
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Controller.MakeListAllVertex();                                                         // формирование списка всех вершин графа
            startVertex.Items.Clear();                                                              // списки начальной и конечной вершин очищаются
            endVertex.Items.Clear();
            for (int i = 0; i < Controller.listAllVertex.Count; i++)                                
            {
                startVertex.Items.Add(Controller.listAllVertex.ElementAt(i));                       // формирование списка начальных вершин
                endVertex.Items.Add(Controller.listAllVertex.ElementAt(i));                         // формирование списка конечных вершин
            }
            buttonOK.DialogResult = DialogResult.OK;                                                // функция иллюстрации работы алгоритма Дейкстры и 
                                                                                                    // создания матрицы смежности блокируется
            buttonFind.Enabled = true;                                                              // кнопка поиска КП активируется
        }

        // поиск КП
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (selectedStartVertex == null || selectedEndVertex == null)                           // Если начальная или конечная вершины не выбраны,
                MessageBox.Show("Для поиска кратчайшего пути, пожалуйста, выберите начальную и " +  // вывод сообщения об ошибке,
                    "конечную вершины графа.");
            else                                                                                    // иначе
            {
                double length;                                                                      // длина пути
                List<string> res = new List<string>();                                              // сам путь
                res = Controller.Dj(selectedStartVertex, selectedEndVertex, out length);            // выполнение алгоритма Дейкстры
                labelWay.Text = null; labelLengthWay.Text = null;
                if (res == null)                                                                    // Если результат выполнения алгоритма Дейкстры
                                                                                                    // равен null,
                {
                    labelWay.Text = "Путь из точки " + selectedStartVertex + " в точку " +           // вывод сообщения,
                        selectedEndVertex + " не существует!"; 
                    labelLengthWay.Text = length.ToString();                                               // вывод длины пути = бесконечности,
                }
                else                                                                                // иначе
                {
                    for (int i = 0; i < res.Count; i++)                                             // вывод пути,
                    {
                        if (i == res.Count - 1)
                            labelWay.Text += res[i].ToString();
                        else
                            labelWay.Text += res[i].ToString() + " -> ";
                    }
                    labelLengthWay.Text = Convert.ToString(length);                                        // вывод длины пути.
                }
            }
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutApp aboutApp = new AboutApp();                                                // вывод диалогового окна о приложении 
            aboutApp.ShowDialog();                                                             
        }

        // создание матрицы смежности (расстояний)
        private void создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(buttonOK.DialogResult != DialogResult.OK)                                            // Если кнопка "ОК" не была нажата,
                MessageBox.Show("Для того чтобы создать матрицу смежности, пожалуйста, заполните" + // вывод сообщения,
                    " список ребер и нажмите кнопку ОК.");
            else                                                                                    // иначе
            {
                MakeAdjacencyMatrix adjMatrix = new MakeAdjacencyMatrix();                          // вывод диалогового окна для создания 
                adjMatrix.ShowDialog();                                                             //матрицы смежности.
            }
        }
    }
}
