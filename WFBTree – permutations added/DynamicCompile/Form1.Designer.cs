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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_HeightOfTree = new System.Windows.Forms.Button();
            this.btn_AddNewNode = new System.Windows.Forms.Button();
            this.btn_DeleteNode = new System.Windows.Forms.Button();
            this.btn_SearchNode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rTxtB = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_HeightOfTree
            // 
            this.btn_HeightOfTree.Location = new System.Drawing.Point(466, 33);
            this.btn_HeightOfTree.Name = "btn_HeightOfTree";
            this.btn_HeightOfTree.Size = new System.Drawing.Size(109, 49);
            this.btn_HeightOfTree.TabIndex = 0;
            this.btn_HeightOfTree.Text = "Height";
            this.btn_HeightOfTree.UseVisualStyleBackColor = true;
            this.btn_HeightOfTree.Click += new System.EventHandler(this.btn_HeightOfTree_Click);
            // 
            // btn_AddNewNode
            // 
            this.btn_AddNewNode.Location = new System.Drawing.Point(35, 33);
            this.btn_AddNewNode.Name = "btn_AddNewNode";
            this.btn_AddNewNode.Size = new System.Drawing.Size(109, 49);
            this.btn_AddNewNode.TabIndex = 1;
            this.btn_AddNewNode.Text = "AddNode";
            this.btn_AddNewNode.UseVisualStyleBackColor = true;
            this.btn_AddNewNode.Click += new System.EventHandler(this.btn_AddNewNode_Click);
            // 
            // btn_DeleteNode
            // 
            this.btn_DeleteNode.Location = new System.Drawing.Point(187, 33);
            this.btn_DeleteNode.Name = "btn_DeleteNode";
            this.btn_DeleteNode.Size = new System.Drawing.Size(109, 49);
            this.btn_DeleteNode.TabIndex = 2;
            this.btn_DeleteNode.Text = "Delete";
            this.btn_DeleteNode.UseVisualStyleBackColor = true;
            this.btn_DeleteNode.Click += new System.EventHandler(this.btn_DeleteNode_Click);
            // 
            // btn_SearchNode
            // 
            this.btn_SearchNode.Location = new System.Drawing.Point(328, 33);
            this.btn_SearchNode.Name = "btn_SearchNode";
            this.btn_SearchNode.Size = new System.Drawing.Size(109, 49);
            this.btn_SearchNode.TabIndex = 3;
            this.btn_SearchNode.Text = "Search";
            this.btn_SearchNode.UseVisualStyleBackColor = true;
            this.btn_SearchNode.Click += new System.EventHandler(this.btn_SearchNode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Solve the problem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rTxtB
            // 
            this.rTxtB.Location = new System.Drawing.Point(35, 145);
            this.rTxtB.Name = "rTxtB";
            this.rTxtB.ReadOnly = true;
            this.rTxtB.Size = new System.Drawing.Size(735, 359);
            this.rTxtB.TabIndex = 5;
            this.rTxtB.Text = "";
            this.rTxtB.TextChanged += new System.EventHandler(this.RTxtB_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(735, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "-1X +3X +6X 0X +7X +4X --> min/max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(873, 525);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rTxtB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SearchNode);
            this.Controls.Add(this.btn_DeleteNode);
            this.Controls.Add(this.btn_AddNewNode);
            this.Controls.Add(this.btn_HeightOfTree);
            this.Name = "Form1";
            this.Text = "MainForn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HeightOfTree;
        private System.Windows.Forms.Button btn_AddNewNode;
        private System.Windows.Forms.Button btn_DeleteNode;
        private System.Windows.Forms.Button btn_SearchNode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rTxtB;
        private System.Windows.Forms.TextBox textBox1;
    }
}

