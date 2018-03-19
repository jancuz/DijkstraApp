namespace DijkstraApp
{
    partial class MakeAdjacencyMatrix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeAdjacencyMatrix));
            this.adjacencyMatrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // adjacencyMatrix
            // 
            this.adjacencyMatrix.AllowUserToAddRows = false;
            this.adjacencyMatrix.AllowUserToDeleteRows = false;
            this.adjacencyMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adjacencyMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adjacencyMatrix.ColumnHeadersVisible = false;
            this.adjacencyMatrix.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.adjacencyMatrix.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.adjacencyMatrix.Location = new System.Drawing.Point(22, 46);
            this.adjacencyMatrix.Name = "adjacencyMatrix";
            this.adjacencyMatrix.RowHeadersVisible = false;
            this.adjacencyMatrix.Size = new System.Drawing.Size(227, 183);
            this.adjacencyMatrix.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "Определение:\r\nМатрицей смежности (англ. Adjacency matrix) A=||αi,j||\r\n взвешенног" +
    "о графа G=(V,E) называется матрица A[V×V],\r\n в которой αi,j — вес ребра, соединя" +
    "ющего вершины vi и vj.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 91);
            this.label2.TabIndex = 25;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(370, 207);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 22);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Матрица смежности, построенная по данным,\r\n заданным в списке ребер";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MakeAdjacencyMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 248);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adjacencyMatrix);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeAdjacencyMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрица смежности";
            ((System.ComponentModel.ISupportInitialize)(this.adjacencyMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adjacencyMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label3;
    }
}