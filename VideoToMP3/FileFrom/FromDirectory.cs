using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoToMP3.FileFrom
{
    public class FromDirectory : IFileFrom
    {
        private string _inputText;

        public string InputText
        {
            get { return _inputText; }
            set { _inputText = value; }
        }

        public FromDirectory()
        {
        }

        public FromDirectory(string text)
        {
            _inputText = text;
        }


        public List<string> GetFiles()
        {
            return Directory.GetFiles(_inputText, "*", SearchOption.AllDirectories).ToList();
        }
    }
}
