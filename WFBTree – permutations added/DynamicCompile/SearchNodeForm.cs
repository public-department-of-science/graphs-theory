using System;
using System.Windows.Forms;

namespace DynamicCompile
{
    public partial class SearchNodeForm : Form
    {
        BTree<string, int> bTree;

        public SearchNodeForm(BTree<string, int> bTree)
        {
            this.bTree = bTree;
            InitializeComponent();
        }

        private void btn_SearchNode_Click(object sender, EventArgs e)
        {
            Entry<string, int> entry = bTree.Search(txtBoxStringValue.Text);
            if (entry is null)
                MessageBox.Show($"{txtBoxStringValue.Text} don't exists!!!");
            else
            {
                MessageBox.Show($"Node <{txtBoxStringValue.Text}> ==> Value {entry.Pointer} \n has been found");
            }
        }
    }
}
