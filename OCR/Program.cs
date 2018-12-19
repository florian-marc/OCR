using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OCR
{
    class Program
    {
        //nombre of elements in the data we have: 52152
        static void Main(string[] args)
        {
            string sourcePath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            string[] paths = {"data", "letter.data"};
            FileRead file = new FileRead(Path.Combine(sourcePath, Path.Combine(paths[0], paths[1])));
            DataSet Data = new DataSet(file.GetNumberOfLines);

            for(int i = 0; i<52152; i++)
            {

            }
            
        }
    }
}
