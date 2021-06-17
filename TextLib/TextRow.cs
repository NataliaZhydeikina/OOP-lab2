using System;
using System.Collections.Generic;
using System.Text;

namespace TextLib
{
    public class TextRow
    {
        private string row;
        public TextRow(string row)
        {
            this.row = row;
        }
        public TextRow()
        {
            row = "";
        }
        public void clearRow()
        {
            row = "";
        }
        public string get()
        {
            return row;
        }
        public void set(string row)
        {
            this.row = row;
        }
        public int length()
        {
            return row.Length;
        }
        public bool contains(string substr)
        {
            return row.Contains(substr);
        }
        public override string ToString()
        {
            return row;
        }
    }
}
