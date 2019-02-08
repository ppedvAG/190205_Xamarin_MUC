using System;
using System.Collections.Generic;
using System.Text;

namespace DatenSpeichernUndLaden
{
    public interface ITextFileHelper
    {
        void SaveTextFile(string content);
        string LoadTextFile();
    }
}
