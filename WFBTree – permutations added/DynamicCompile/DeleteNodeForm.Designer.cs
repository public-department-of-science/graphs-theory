namespace DynamicCompile
{
    partial class DeleteNodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxStringValue = new System.Windows.Forms.TextBox();
            this.btn_DeleteNode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NodeName <String Value>";
            // 
            // txtBoxStringValue
            // 
            this.txtBoxStringValue.Location = new System.Drawing.Point(170, 34);
            this.txtBoxStringValue.Name = "txtBoxStringValue";
            this.txtBoxStringValue.Size = new System.Drawing.Size(125, 20);
            this.txtBoxStringValue.TabIndex = 7;
            // 
            // btn_DeleteNode
            // 
            this.btn_DeleteNode.Location = new System.Drawing.Point(170, 88);
            this.btn_DeleteNode.Name = "btn_DeleteNode";
            this.btn_DeleteNode.Size = new System.Drawing.Size(125, 47);
            this.btn_DeleteNode.TabIndex = 9;
            this.btn_DeleteNode.Text = "Delete";
            this.btn_DeleteNode.UseVisualStyleBackColor = true;
            this.btn_DeleteNode.Click += new System.EventHandler(this.btn_DeleteNode_Click);
            // 
            // DeleteNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 165);
            this.Controls.Add(this.btn_DeleteNode);
            this.Controls.Add(this.txtBoxStringValue);
            this.Controls.Add(this.label1);
            this.Name = "DeleteNodeForm";
            this.Text = "DeleteNodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxStringValue;
        private System.Windows.Forms.Button btn_DeleteNode;
    }
}