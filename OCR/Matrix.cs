using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCR
{
    public class Matrix
    {
        private static int ligne = 16;
        private static int colone = 8;

        private int[,] matrix = new int[ligne, colone];

        public Matrix(List<int> listbin)
        {
            int ligne = 0;

            while(ligne!=15)
            {
                int colone = 0;
                while (colone!=8)
                {
                    this.matrix[ligne, colone] = listbin[ligne * 8 + colone];
                }
                ligne++;
            }
        }

    }
}
