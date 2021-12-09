namespace DynamicCompile
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
            this.btn_HeightOfTree = new System.Windows.Forms.Button();
            this.btn_AddNewNode = new System.Windows.Forms.Button();
            this.btn_DeleteNode = new System.Windows.Forms.Button();
            this.btn_SearchNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HeightOfTree
            // 
            this.btn_HeightOfTree.Location = new System.Drawing.Point(224, 210);
            this.btn_HeightOfTree.Name = "btn_HeightOfTree";
            this.btn_HeightOfTree.Size = new System.Drawing.Size(109, 49);
            this.btn_HeightOfTree.TabIndex = 0;
            this.btn_HeightOfTree.Text = "Height";
            this.btn_HeightOfTree.UseVisualStyleBackColor = true;
            this.btn_HeightOfTree.Click += new System.EventHandler(this.btn_HeightOfTree_Click);
            // 
            // btn_AddNewNode
            // 
            this.btn_AddNewNode.Location = new System.Drawing.Point(46, 79);
            this.btn_AddNewNode.Name = "btn_AddNewNode";
            this.btn_AddNewNode.Size = new System.Drawing.Size(109, 49);
            this.btn_AddNewNode.TabIndex = 1;
            this.btn_AddNewNode.Text = "AddNode";
            this.btn_AddNewNode.UseVisualStyleBackColor = true;
            this.btn_AddNewNode.Click += new System.EventHandler(this.btn_AddNewNode_Click);
            // 
            // btn_DeleteNode
            // 
            this.btn_DeleteNode.Location = new System.Drawing.Point(224, 79);
            this.btn_DeleteNode.Name = "btn_DeleteNode";
            this.btn_DeleteNode.Size = new System.Drawing.Size(109, 49);
            this.btn_DeleteNode.TabIndex = 2;
            this.btn_DeleteNode.Text = "Delete";
            this.btn_DeleteNode.UseVisualStyleBackColor = true;
            this.btn_DeleteNode.Click += new System.EventHandler(this.btn_DeleteNode_Click);
            // 
            // btn_SearchNode
            // 
            this.btn_SearchNode.Location = new System.Drawing.Point(397, 79);
            this.btn_SearchNode.Name = "btn_SearchNode";
            this.btn_SearchNode.Size = new System.Drawing.Size(109, 49);
            this.btn_SearchNode.TabIndex = 3;
            this.btn_SearchNode.Text = "Search";
            this.btn_SearchNode.UseVisualStyleBackColor = true;
            this.btn_SearchNode.Click += new System.EventHandler(this.btn_SearchNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 331);
            this.Controls.Add(this.btn_SearchNode);
            this.Controls.Add(this.btn_DeleteNode);
            this.Controls.Add(this.btn_AddNewNode);
            this.Controls.Add(this.btn_HeightOfTree);
            this.Name = "Form1";
            this.Text = "MainForn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HeightOfTree;
        private System.Windows.Forms.Button btn_AddNewNode;
        private System.Windows.Forms.Button btn_DeleteNode;
        private System.Windows.Forms.Button btn_SearchNode;
    }
}

