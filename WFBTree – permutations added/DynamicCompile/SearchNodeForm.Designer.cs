namespace DynamicCompile
{
    partial class SearchNodeForm
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
            this.btn_SearchNode = new System.Windows.Forms.Button();
            this.txtBoxStringValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SearchNode
            // 
            this.btn_SearchNode.Location = new System.Drawing.Point(170, 97);
            this.btn_SearchNode.Name = "btn_SearchNode";
            this.btn_SearchNode.Size = new System.Drawing.Size(125, 47);
            this.btn_SearchNode.TabIndex = 12;
            this.btn_SearchNode.Text = "Search";
            this.btn_SearchNode.UseVisualStyleBackColor = true;
            this.btn_SearchNode.Click += new System.EventHandler(this.btn_SearchNode_Click);
            // 
            // txtBoxStringValue
            // 
            this.txtBoxStringValue.Location = new System.Drawing.Point(170, 43);
            this.txtBoxStringValue.Name = "txtBoxStringValue";
            this.txtBoxStringValue.Size = new System.Drawing.Size(125, 20);
            this.txtBoxStringValue.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NodeName <String Value>";
            // 
            // SearchNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 178);
            this.Controls.Add(this.btn_SearchNode);
            this.Controls.Add(this.txtBoxStringValue);
            this.Controls.Add(this.label1);
            this.Name = "SearchNodeForm";
            this.Text = "SearchNodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchNode;
        private System.Windows.Forms.TextBox txtBoxStringValue;
        private System.Windows.Forms.Label label1;
    }
}