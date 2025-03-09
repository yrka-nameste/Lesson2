using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileConverter converter = new();
            converter.Convert("pdf", "document.txt");
            converter.Convert("docx", "report.txt");
            converter.Convert("jpg", "image.png");
        }
    }
}
