using System.Collections.Generic;

namespace DynamicCompile
{
    public class Node<TK, TP>
    {
        private int degree;

        public Node(int degree)
        {
            this.degree = degree;
            Children = new List<Node<TK, TP>>(degree);
            Entries = new List<Entry<TK, TP>>(degree);
        }

        public List<Node<TK, TP>> Children { get; set; }

        public List<Entry<TK, TP>> Entries { get; set; }

        public bool IsLeaf
        {
            get
            {
                return Children.Count == 0;
            }
        }

        public bool HasReachedMaxEntries
        {
            get
            {
                return Entries.Count == (2 * this.degree) - 1;
            }
        }

        public bool HasReachedMinEntries
        {
            get
            {
                return Entries.Count == this.degree - 1;
            }
        }
    }
}
