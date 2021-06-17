using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextLib
{
    public class Text
    {
        List<TextRow> text;

        public Text()
        {
            text = new List<TextRow>();
        }
        public Text(string str)
        {
            text = new List<TextRow>() { new TextRow(str) };
        }
        public void add(string row)
        {
            text.Add(new TextRow(row));
        }
        public void clear()
        {
            text.Clear();
        }
        public void remove(int index)
        {
            text.RemoveAt(index);
        }
        public void remove(string row)
        {
            text.Remove(find(row));
        }
        private TextRow find(string row)
        {
            return text.Find(e => e.contains(row));
        }
        public override string ToString()
        {
            return String.Concat(text.Select(o => o.ToString()+"\n"));
        }
        public void insert(int index, string row)
        {
            text[index].set(row);
        }
        public int length() {
            return text.Count;
        }
        public bool contains(string row) {
            return null != find(row);
        }
    }
}
