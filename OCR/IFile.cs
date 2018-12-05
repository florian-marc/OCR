using System;
using System.Collections.Generic;

namespace OCR
{
    public interface IFile
    {
        void OpenFile();

        void OpenFile(string path);

        void CloseFile();

        List<string> GetLine();
    }
}
