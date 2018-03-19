namespace DijkstraApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.edgeList = new System.Windows.Forms.DataGridView();
            this.textBoxStartVertex = new System.Windows.Forms.TextBox();
            this.textBoxEndVertex = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startVertex = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.endVertex = new System.Windows.Forms.ListBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWay = new System.Windows.Forms.Label();
            this.labelLengthWay = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edgeList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edgeList
            // 
            this.edgeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.edgeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edgeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.edgeList.Location = new System.Drawing.Point(295, 57);
            this.edgeList.Name = "edgeList";
            this.edgeList.Size = new System.Drawing.Size(431, 150);
            this.edgeList.TabIndex = 0;
            this.edgeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.edgeGriedView_CellClick);
            // 
            // textBoxStartVertex
            // 
            this.textBoxStartVertex.Location = new System.Drawing.Point(152, 57);
            this.textBoxStartVertex.Name = "textBoxStartVertex";
            this.textBoxStartVertex.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartVertex.TabIndex = 1;
            this.textBoxStartVertex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartVertex_KeyPress);
            this.textBoxStartVertex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStartVertex_KeyUp);
            // 
            // textBoxEndVertex
            // 
            this.textBoxEndVertex.Location = new System.Drawing.Point(152, 99);
            this.textBoxEndVertex.Name = "textBoxEndVertex";
            this.textBoxEndVertex.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndVertex.TabIndex = 2;
            this.textBoxEndVertex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEndVertex_KeyPress);
            this.textBoxEndVertex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEndVertex_KeyUp);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(152, 140);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 3;
            this.textBoxDistance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDistance_PreviewKeyDown);
            this.textBoxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDistance_KeyPress);
            this.textBoxDistance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDistance_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начальная вершина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конечная вершина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расстояние между \r\nвершинами \r\n(длина ребра)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(14, 187);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 38);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить ребро";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(299, 213);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 36);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить выделенное ребро";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Location = new System.Drawing.Point(152, 187);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(122, 38);
            this.buttonCorrect.TabIndex = 10;
            this.buttonCorrect.Text = "Изменить выделенное ребро";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Кратчайшее \r\nрасстояние";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "от:";
            // 
            // startVertex
            // 
            this.startVertex.FormattingEnabled = true;
            this.startVertex.Location = new System.Drawing.Point(122, 260);
            this.startVertex.Name = "startVertex";
            this.startVertex.Size = new System.Drawing.Size(77, 82);
            this.startVertex.TabIndex = 13;
            this.startVertex.SelectedIndexChanged += new System.EventHandler(this.startVertex_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "до:";
            // 
            // endVertex
            // 
            this.endVertex.FormattingEnabled = true;
            this.endVertex.Location = new System.Drawing.Point(239, 259);
            this.endVertex.Name = "endVertex";
            this.endVertex.Size = new System.Drawing.Size(77, 82);
            this.endVertex.TabIndex = 15;
            this.endVertex.SelectedIndexChanged += new System.EventHandler(this.endVertex_SelectedIndexChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(346, 287);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 16;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Путь:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Длина:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Список ребер неориентированного графа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Данные для добавления/корректировки ребра";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem,
            this.проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem,
            this.оПриложенииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem
            // 
            this.создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem.Name = "создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem";
            this.создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem.Size = new System.Drawing.Size(333, 20);
            this.создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem.Text = "Создать матрицу смежности по заданному списку ребер";
            this.создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem.Click += new System.EventHandler(this.создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem_Click);
            // 
            // проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem
            // 
            this.проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem.Name = "проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem";
            this.проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem.Size = new System.Drawing.Size(295, 20);
            this.проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem.Text = "Проиллюстрировать работу алгоритма Дейкстры";
            this.проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem.Click += new System.EventHandler(this.проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem_Click);
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // labelWay
            // 
            this.labelWay.Location = new System.Drawing.Point(512, 284);
            this.labelWay.Name = "labelWay";
            this.labelWay.Size = new System.Drawing.Size(220, 13);
            this.labelWay.TabIndex = 28;
            // 
            // labelLengthWay
            // 
            this.labelLengthWay.Location = new System.Drawing.Point(512, 306);
            this.labelLengthWay.Name = "labelLengthWay";
            this.labelLengthWay.Size = new System.Drawing.Size(220, 13);
            this.labelLengthWay.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(427, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 26);
            this.label13.TabIndex = 30;
            this.label13.Text = "При завершении составления списка ребер \r\nнажмите кнопку OK";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(668, 217);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(58, 23);
            this.buttonOK.TabIndex = 31;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 356);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelLengthWay);
            this.Controls.Add(this.labelWay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.endVertex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.startVertex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCorrect);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxEndVertex);
            this.Controls.Add(this.textBoxStartVertex);
            this.Controls.Add(this.edgeList);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск кратчайшего пути";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edgeList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView edgeList;
        private System.Windows.Forms.TextBox textBoxStartVertex;
        private System.Windows.Forms.TextBox textBoxEndVertex;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox startVertex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox endVertex;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьМатрицуСмежностиПоЗаданномуСпискуРеберToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проиллюстрироватьРаботуАлгоритмаДейкстрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.Label labelWay;
        private System.Windows.Forms.Label labelLengthWay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonOK;
    }
}

