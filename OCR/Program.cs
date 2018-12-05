using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCR
{
    class Program
    {
        //nombre of elements in the data we have: 52152

        static void printMat(Matrix matrix)
        {
            int l = 0;
            while(l<16)
            {
                string lignestring = "";
                int c = 0;
                while(c<8)
                {
                    if(matrix.getmatrix[l, c]==0)
                    {
                        lignestring += " ";
                    }
                    else if(matrix.getmatrix[l, c] == 1)
                    {
                        lignestring += "X";
                    }
                    else
                    {
                        lignestring += "ERROR:" + matrix.getmatrix[l, c].ToString() + "  ";
                    }
                    c++;
                }
                Console.WriteLine(lignestring);
                l++;
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}
