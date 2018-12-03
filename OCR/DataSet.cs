using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCR
{
    public class DataSet
    {
        public char[] Char;
        public Matrix[] TabMatrix;

        public DataSet(char[] Char, Matrix[] TabMatrix)
        {
            Char = this.Char;
            TabMatrix = this.TabMatrix;
        }
    }
}
