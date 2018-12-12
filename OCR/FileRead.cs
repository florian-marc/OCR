using System;
using System.IO;
using OCR.Exceptions;
namespace OCR
{
    public class FileRead : IFile
    {
        private string path;
        private StreamReader file;

        public FileRead(string path)
        {
            this.path = path;
            file = null;
        }

        public void OpenFile()
        {
            file = new StreamReader(this.path);
        }

        //may throw FileNotFoundException
        public void OpenFile(string path)
        {
            if (path != this.path)
            {
                CloseFile();
                file = new StreamReader(path);
                this.path = path;

            }
            else
            {
                throw new UnauthorizedAccessException();
            }
        }

        public void CloseFile()
        {
            file.Close();
        }

        private int NumberOfLines()
        {
            long position = file.BaseStream.Position;
            int n = 0;
            Rewind();
            while(file.ReadLine() != null)
            {
                n++;
            }
            Rewind(position);
            return n;
        }

        private string _GetLine()
        {
            string output = file.ReadLine();
            if (output == null)
            {
                throw new EndOfFileException();
            }
            return output;
        }

        public string[] GetLine()
        {
            return _GetLine().Split('\t');
        }

        private void Rewind(long position)
        {
            try{
                file.BaseStream.Position = position;
            }
            catch(ObjectDisposedException)
            {
                OpenFile();
                file.BaseStream.Position = position;
            }
        }

        public void Rewind()
        {
            Rewind(0);
        }

        public string Path
        {
            get { return this.path; }
        }

        public int NumberOfLines
        {
            get { return n => { n 

            }}
}
}
