using System;
using System.IO;
namespace OCR
{
    public class OpenFile
    {
        string path;
        StreamReader sr;

        public OpenFile(string path)
        {
            this.path = path;
            sr = new StreamReader(path);
        }

        public void CloseFile()
        {
            sr.Close();
        }

        public string Path
        {
            get { return this.path; }
        }
    }
}
