using System;

namespace OCR
{
    public class DataSet
    {
        private char[] letters;
        private Matrix[] tabMatrix;

        public DataSet(int size)
        {
            letters = new char[size];
            tabMatrix = new Matrix[size];
            for (int i = 0; i < size; i++)
            {
                tabMatrix[i] = null;
            }
        }

        public DataSet(char[] letters, Matrix[] tabMatrix)
        {
            this.letters = letters;
            this.tabMatrix = tabMatrix;
        }

        public char[] Letters
        {
            get { return this.letters; }
        }
    }
}
