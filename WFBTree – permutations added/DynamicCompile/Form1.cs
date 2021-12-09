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
            MessageBox.Show("Height = >" + bTree.Height.ToString());
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

        private void Button1_Click(object sender, EventArgs e)
        {
            var G = Class1.PermutionsWithoutRepeats(6);
            G.Add(new int[] { 1, 2, 3, 4, 5, 6 });
            var text = "";

            foreach (var item in G)
            {
                var t = "";
                foreach (var item1 in item)
                {
                    t += item1.ToString();
                }
                text += t + "\n";
            }

            int[] c = new int[6]
            {
                -1,3,6,0,7,4
            };

            ///
            List<int> listOfFunctionValues = new List<int>();

            int[] cCopy = new int[c.Length];
            Array.Copy(c, 0, cCopy, 0, c.Length);

            int[] cSort = c.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < G.Count; i++)
            {
                int xMin = 0;
                for (int j = 0; j < c.Length; j++)
                {
                    var index = GetIndex(c, c[j]);
                    xMin += cSort[index] * G[i][index];
                }
                listOfFunctionValues.Add(xMin);
            }

            text += "Print results:";
            for (int i = 0; i < listOfFunctionValues.Count; i++)
            {
                for (int j = 0; j < G[i].Length; j++)
                {
                    text += $" {G[i][j]} ";
                }
                text += $"; Z(X_i) = {listOfFunctionValues[i]}\n";
            }

            #region Global min
            var globalMinArray = G[listOfFunctionValues.FindIndex(x => x == listOfFunctionValues.Min())];

            text += $"Min = {listOfFunctionValues.Min()} (";
            foreach (var item in globalMinArray)
            {
                text += item + " ";
            }
            text += ")";
            #endregion

            #region Global max
            var globalMaxArray = G[listOfFunctionValues.FindIndex(x => x == listOfFunctionValues.Max())];

            text += $"\nMax = {listOfFunctionValues.Max()} (";
            foreach (var item in globalMaxArray)
            {
                text += item + " ";
            }
            text += ")";
            #endregion
            ///

            foreach (var item in listOfFunctionValues)
            {
                bTree.Insert(G[listOfFunctionValues.FindIndex(x => x == item)].ToString(), item);
            }

            rTxtB.Text = text;

            AddElementForm addElementForm = new AddElementForm(bTree);
        }

        static private int GetIndex(int[] c, int v)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == v)
                {
                    return i;
                }
            }

            return 0;
        }

        private void RTxtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}