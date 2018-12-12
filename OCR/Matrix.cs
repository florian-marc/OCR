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

        public Matrix(string[] fileInput):this(ConvertData(fileInput))
        {}

        private static int[] ConvertData(string[] listBin)
        {
            int[] tabint = new int[listBin.Length - 6];
            int n = 0;
            for(int i = 6; i<listBin.Length; i++)
            {
                tabint[n] = Convert.ToInt32(listBin[i]);
                n++;
            }
            return tabint;
        }
        
        public Matrix(int[] listBin)
        {
            matrix = new int[ligne, colonne];

            int l = 0;
            while (l < 16)
            {
                int c = 0;
                while (c < 8)
                {
                    this.matrix[l, c] = listBin[l * 8 + c];
                    c++;
                }
                l++;
            }
        }

        public void Print()
        {
            string output = "";
            for (int l = 0; l < ligne; l++)
            {
                for (int c = 0; c < colonne; c++)
                {
                    if (matrix[l, c] == 0)
                    {
                        output += " ";
                    }
                    else
                    {
                        if(matrix[l,c] == 1)
                        {
                            output += "X";
                        }
                        else
                        {
                            output += "ERROR : " + matrix[l, c] + "  ";
                        }
                    }
                    output += "\n";
                }
            }
            Console.Write(output);
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
