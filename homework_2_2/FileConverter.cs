using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_2
{
 class FileConverter
    {
        private readonly Dictionary<string, IFileConverter> converters = new()
    {
        { "pdf", new PdfConverter() },
        { "jpg", new JpgConverter() }
    };

        public void Convert(string fileType, string filePath)
        {
            if (converters.TryGetValue(fileType.ToLower(), out var converter))
            {
                converter.Convert(filePath);
            }
            else
            {
                Console.WriteLine($"Неизвестный формат файла: {fileType}");
            }
        }
    }
}
