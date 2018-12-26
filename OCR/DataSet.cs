using System;

namespace OCR
{
    public class DataSet
    {
        private char[] letters;
        private Matrix[] tabMatrix;

        public DataSet(FileRead fr)
        {
            int size = fr.GetNumberOfLines;
            fr.Rewind();
            letters = new char[size];
            tabMatrix = new Matrix[size];
            for (int i = 0; i < size; i++)
            {
                string[] input = fr.GetLine();
                letters[i] = input[1][0];
                tabMatrix[i] = new Matrix(input);
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
