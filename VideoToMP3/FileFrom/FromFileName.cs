using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoToMP3.FileFrom
{
    public class FromFileName : IFileFrom
    {
        private string _inputText;

        public string InputText
        {
            get { return _inputText; }
            set { _inputText = value; }
        }

        public FromFileName()
        {
        }

        public FromFileName(string text)
        {
            _inputText = text;
        }


        public List<string> GetFiles()
        {
            return new List<string>() {_inputText};
        }
    }
}
