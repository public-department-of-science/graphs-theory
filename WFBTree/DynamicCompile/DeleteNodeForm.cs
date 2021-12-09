using System;
using System.Windows.Forms;

namespace DynamicCompile
{
    public partial class DeleteNodeForm : Form
    {
        BTree<string, int> bTree;

        public DeleteNodeForm(BTree<string, int> bTree)
        {
            this.bTree = bTree;
            InitializeComponent();
        }

        private void btn_DeleteNode_Click(object sender, EventArgs e)
        {
            Entry<string, int> entry = bTree.Search(txtBoxStringValue.Text);
            if (entry is null)
                MessageBox.Show($"{txtBoxStringValue.Text} don't exists!!!");
            else
            {
                bTree.Delete(txtBoxStringValue.Text);
                MessageBox.Show($"Couple of values <{txtBoxStringValue.Text}> \n Had been deleted");
            }
        }
    }
}