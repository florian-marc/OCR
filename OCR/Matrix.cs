using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCR
{
    public class Matrix
    {
        private static int ligne = 16;
        private static int colonne = 8;

        private int[,] matrix;

        public Matrix(List<int> listBin)
        {
            matrix = new int[ligne, colonne];

            int l = 0;
            while(l<16)
            {
                int c = 0;
                while (c<8)
                {
                    this.matrix[l, c] = listBin[l * 8 + c];
                    c++;
                }
                l++;
            }
        }

        public int Ligne
        {
            get { return ligne; }
        }

        public int Colonne
        {
            get { return colonne; }
        }

        public int[,] getmatrix
        {
            get { return matrix; }
        }
    }
}
