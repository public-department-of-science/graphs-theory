namespace Lab_3
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_SearchAllPaths = new System.Windows.Forms.Button();
            this.txtb_AllVertexes = new System.Windows.Forms.TextBox();
            this.txtb_StartVertex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_UpdateElements = new System.Windows.Forms.Button();
            this.txb_WriteOnScreenAllPaths = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = ".txt|*.txt";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(16, 12);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(135, 74);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Открыть Файл на чтение";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.open_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 685);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txb_WriteOnScreenAllPaths);
            this.tabPage2.Controls.Add(this.txtb_StartVertex);
            this.tabPage2.Controls.Add(this.txtb_AllVertexes);
            this.tabPage2.Controls.Add(this.btn_UpdateElements);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_SearchAllPaths);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск кротчайших путей";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_SearchAllPaths
            // 
            this.btn_SearchAllPaths.Location = new System.Drawing.Point(298, 55);
            this.btn_SearchAllPaths.Name = "btn_SearchAllPaths";
            this.btn_SearchAllPaths.Size = new System.Drawing.Size(106, 46);
            this.btn_SearchAllPaths.TabIndex = 4;
            this.btn_SearchAllPaths.Text = "Найти кротчайшие пути";
            this.btn_SearchAllPaths.UseVisualStyleBackColor = true;
            this.btn_SearchAllPaths.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtb_AllVertexes
            // 
            this.txtb_AllVertexes.Location = new System.Drawing.Point(154, 20);
            this.txtb_AllVertexes.Name = "txtb_AllVertexes";
            this.txtb_AllVertexes.ReadOnly = true;
            this.txtb_AllVertexes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtb_AllVertexes.Size = new System.Drawing.Size(527, 20);
            this.txtb_AllVertexes.TabIndex = 5;
            // 
            // txtb_StartVertex
            // 
            this.txtb_StartVertex.Location = new System.Drawing.Point(154, 68);
            this.txtb_StartVertex.Name = "txtb_StartVertex";
            this.txtb_StartVertex.Size = new System.Drawing.Size(113, 20);
            this.txtb_StartVertex.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Загруженные вершины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Старотовая вершина";
            // 
            // btn_UpdateElements
            // 
            this.btn_UpdateElements.Location = new System.Drawing.Point(16, 108);
            this.btn_UpdateElements.Name = "btn_UpdateElements";
            this.btn_UpdateElements.Size = new System.Drawing.Size(119, 57);
            this.btn_UpdateElements.TabIndex = 10;
            this.btn_UpdateElements.Text = "Update";
            this.btn_UpdateElements.UseVisualStyleBackColor = true;
            this.btn_UpdateElements.Click += new System.EventHandler(this.btn_UpdateElements_Click);
            // 
            // txb_WriteOnScreenAllPaths
            // 
            this.txb_WriteOnScreenAllPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_WriteOnScreenAllPaths.Location = new System.Drawing.Point(154, 108);
            this.txb_WriteOnScreenAllPaths.Multiline = true;
            this.txb_WriteOnScreenAllPaths.Name = "txb_WriteOnScreenAllPaths";
            this.txb_WriteOnScreenAllPaths.ReadOnly = true;
            this.txb_WriteOnScreenAllPaths.Size = new System.Drawing.Size(527, 302);
            this.txb_WriteOnScreenAllPaths.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 480);
            this.tabControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txb_WriteOnScreenAllPaths;
        private System.Windows.Forms.TextBox txtb_StartVertex;
        private System.Windows.Forms.TextBox txtb_AllVertexes;
        private System.Windows.Forms.Button btn_UpdateElements;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SearchAllPaths;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

