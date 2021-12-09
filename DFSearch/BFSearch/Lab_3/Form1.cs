using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        private Tuple<int, int>[] edges; // грани, которые создаются путем задаия пары значений
        Algorithms algorithms = new Algorithms(); // класс с обходом в ширину и поиском путей
        private int[] vertices; // вершины
        List<int> list;// вспомогательный список для вершин

        private bool dataReaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                StreamReader sr;//создание потока
                try
                {
                    using (sr = new StreamReader(openFileDialog1.FileName))
                    {
                        int count = File.ReadAllLines(openFileDialog1.FileName).Length; // кол путей
                        edges = new Tuple<int, int>[count];
                        list = new List<int>();

                        for (int i = 0; i < edges.Length; i++)
                        {
                            string[] s = sr.ReadLine().Split(' ');
                            int firstValue = Convert.ToInt32(s[0]);
                            int secondValue = Convert.ToInt32(s[1]);
                            if (!list.Contains(firstValue))// проверка  на единственность связанных вершин
                                list.Add(firstValue);
                            if (!list.Contains(secondValue))
                                list.Add(secondValue);
                            edges[i] = Tuple.Create(firstValue, secondValue);
                        }
                        vertices = new int[list.Count];
                        for (int i = 0; i < list.Count; i++)// записали неповторяющиеся вершины в массив
                        {
                            vertices[i] = list[i];
                        }
                        sr.Close();
                    }
                    dataReaded = true;
                }
                catch
                {
                    dataReaded = false;
                    MessageBox.Show("Read Error!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataReaded && txtb_StartVertex.Text != "")
            {
                txb_WriteOnScreenAllPaths.Text = "";
                var graph = new Graph<int>(vertices, edges);
                try
                {
                    var shortestPath = algorithms.ShortestPathFunction(graph, Convert.ToInt32(txtb_StartVertex.Text)); // ссылка на метод
                    txb_WriteOnScreenAllPaths.Text = "DFSearch {" + string.Join(", ", algorithms.DFS(graph, 1)) + "}\r\n";
                    foreach (var vertex in vertices)
                    {
                        txb_WriteOnScreenAllPaths.Text += $"shortest path to {vertex}: {string.Join(", ", shortestPath(vertex))}";
                        txb_WriteOnScreenAllPaths.Text += "\r\n";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_UpdateElements_Click(object sender, EventArgs e)
        {
            if (dataReaded)
            {
                txtb_AllVertexes.Text = "";
                for (int i = 0; i < list.Count; i++)
                {
                    txtb_AllVertexes.Text += $"{{ {list[i]} }};" + " \n";
                }
            }
            return;
        }
    }
}