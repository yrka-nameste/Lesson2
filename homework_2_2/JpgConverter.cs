using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_2
{
    class JpgConverter : IFileConverter 
    {
        public void Convert(string filePath)
        {
            Console.WriteLine($"Convert JPG in proces ......");
        }
    }
}
