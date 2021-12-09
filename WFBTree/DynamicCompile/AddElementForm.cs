using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicCompile
{
    public partial class AddElementForm : Form
    {
        BTree<string, int> bTree;
        public AddElementForm(BTree<string, int> bTree)
        {
            this.bTree = bTree;
            InitializeComponent();
        }

        private void btn_AddNode_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                for (int i = 0; i < Convert.ToInt32(txb_AmountOfElementsForRandom.Text); i++)
                {
                    bTree.Insert(random.ToString(), random.Next(Convert.ToInt32(txtb_LowestBound.Text), Convert.ToInt32(txtb_UpperBound.Text)));
                }
                bTree.Insert(txtBoxStringValue.Text, Convert.ToInt32(txtBoxIntegerValue.Text));

                MessageBox.Show($"Couple of values <{txtBoxStringValue.Text}> ==> {txtBoxIntegerValue.Text}\n Had been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have some trouble...");
            }
        }

        private void btn_ReadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                String line;
                String[] arrayLine;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);

                    //Read the first line of text
                    line = sr.ReadLine();

                    arrayLine = sr.ReadLine().Split(' ');
                    bTree.Insert(arrayLine[0], Int32.Parse(arrayLine[1]));

                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //Read the next line
                        arrayLine = sr.ReadLine().Split(' ');
                        bTree.Insert(arrayLine[0], Int32.Parse(arrayLine[1]));
                    }

                    //close the file
                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }


            }
        }
    }
}
