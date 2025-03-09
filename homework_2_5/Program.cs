using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_5
{
    interface IConverter
    {
        void Convert(string filePath);
    }

    class PdfConverter : IConverter
    {
        public void Convert(string filePath)
        {
            Console.WriteLine($"Конвертация {filePath} в PDF...");
        }
    }

    class DocxConverter : IConverter
    {
        public void Convert(string filePath)
        {
            Console.WriteLine($"Конвертация {filePath} в DOCX...");
        }
    }

    class FileConverter
    {
        private readonly Dictionary<string, IConverter> converters = new Dictionary<string, IConverter>();

        public void RegisterConverter(string format, IConverter converter)
        {
            converters[format] = converter;
        }

        public void ConvertFile(string format, string filePath)
        {
            if (converters.ContainsKey(format))
            {
                converters[format].Convert(filePath);
            }
            else
            {
                Console.WriteLine($"Ошибка: конвертер для {format} не найден!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FileConverter fileConverter = new FileConverter();
            fileConverter.RegisterConverter("pdf", new PdfConverter());
            fileConverter.RegisterConverter("docx", new DocxConverter());

            fileConverter.ConvertFile("pdf", "document.txt");
            fileConverter.ConvertFile("docx", "document.txt");
        }
    }
}
