using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DynamicCompile
{
    public partial class Form1 : Form
    {
        private BTree<string, int> bTree;
        public Form1()
        {
            InitializeComponent();
        }

        //
        public Form1(BTree<string, int> bTree)
        {
            this.bTree = bTree;
            InitializeComponent();
        }

        private void btn_HeightOfTree_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Height = >"+bTree.Height.ToString());
        }

        private void btn_AddNewNode_Click(object sender, EventArgs e)
        {
            AddElementForm addElementForm = new AddElementForm(bTree);
            addElementForm.Show();
        }

        private void btn_DeleteNode_Click(object sender, EventArgs e)
        {
            DeleteNodeForm deleteNodeForm = new DeleteNodeForm(bTree);
            deleteNodeForm.Show();
        }

        private void btn_SearchNode_Click(object sender, EventArgs e)
        {
            SearchNodeForm searchNodeForm = new SearchNodeForm(bTree);
            searchNodeForm.Show();
        }
    }
}