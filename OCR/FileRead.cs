using System;
using System.Collections.Generic;
using System.IO;
namespace OCR
{
    public class FileRead:IFile
    {
        string path;
        FileStream file;

        public FileRead(string path)
        {
            this.path = path;
            file = null;
        }

        public void OpenFile()
        {
            file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
        }

        public void OpenFile(string path)
        {

        }

        public void CloseFile()
        {
            file.Close();
        }

        private string _GetLine()
        {

        }

        public List<string> GetLine()
        {

        }

        public string Path
        {
            get { return this.path; }
        }
    }
}
