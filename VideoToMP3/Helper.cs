using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoToMP3
{
    class Helper
    {
        private FileFrom.IFileFrom fileFrom;

        public List<string> GetFiles(string text)
        {
            if (File.Exists(text))
            {
                fileFrom = new FileFrom.FromFileName(text);
            }
            else if (Directory.Exists(text))
            {
                fileFrom = new FileFrom.FromDirectory(text);
            }
            else
            {
                return null;
            }

            return fileFrom.GetFiles();
        }
    }
}
