namespace DynamicCompile
{
    partial class AddElementForm
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
            this.txtBoxStringValue = new System.Windows.Forms.TextBox();
            this.txtBoxIntegerValue = new System.Windows.Forms.TextBox();
            this.btn_AddNode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ReadFromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtBoxStringValue
            // 
            this.txtBoxStringValue.Location = new System.Drawing.Point(167, 87);
            this.txtBoxStringValue.Name = "txtBoxStringValue";
            this.txtBoxStringValue.Size = new System.Drawing.Size(125, 20);
            this.txtBoxStringValue.TabIndex = 0;
            // 
            // txtBoxIntegerValue
            // 
            this.txtBoxIntegerValue.Location = new System.Drawing.Point(167, 129);
            this.txtBoxIntegerValue.Name = "txtBoxIntegerValue";
            this.txtBoxIntegerValue.Size = new System.Drawing.Size(125, 20);
            this.txtBoxIntegerValue.TabIndex = 1;
            // 
            // btn_AddNode
            // 
            this.btn_AddNode.Location = new System.Drawing.Point(166, 180);
            this.btn_AddNode.Name = "btn_AddNode";
            this.btn_AddNode.Size = new System.Drawing.Size(125, 47);
            this.btn_AddNode.TabIndex = 2;
            this.btn_AddNode.Text = "Add";
            this.btn_AddNode.UseVisualStyleBackColor = true;
            this.btn_AddNode.Click += new System.EventHandler(this.btn_AddNode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NodeName <String Value>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key <Integer Value>";
            // 
            // btn_ReadFromFile
            // 
            this.btn_ReadFromFile.Location = new System.Drawing.Point(33, 180);
            this.btn_ReadFromFile.Name = "btn_ReadFromFile";
            this.btn_ReadFromFile.Size = new System.Drawing.Size(103, 47);
            this.btn_ReadFromFile.TabIndex = 10;
            this.btn_ReadFromFile.Text = "ReadFromFile";
            this.btn_ReadFromFile.UseVisualStyleBackColor = true;
            this.btn_ReadFromFile.Click += new System.EventHandler(this.btn_ReadFromFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 267);
            this.Controls.Add(this.btn_ReadFromFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddNode);
            this.Controls.Add(this.txtBoxIntegerValue);
            this.Controls.Add(this.txtBoxStringValue);
            this.Name = "AddElementForm";
            this.Text = "AddElementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxStringValue;
        private System.Windows.Forms.TextBox txtBoxIntegerValue;
        private System.Windows.Forms.Button btn_AddNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ReadFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}