using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_3
{
    abstract class FileProcessor
    {
        public abstract void Upload(string filePath);
    }

    interface IConvertibleFile
    {
        void Convert(string filePath);
    }

    class PdfConverter : FileProcessor, IConvertibleFile
    {
        public override void Upload(string filePath)
        {
            Console.WriteLine($"Загружаем PDF-файл: {filePath}");
        }

        public void Convert(string filePath)
        {
            Console.WriteLine($"Конвертируем {filePath} в PDF...");
        }
    }

    class EncryptedFile : FileProcessor
    {
        public override void Upload(string filePath)
        {
            Console.WriteLine($"Загружаем зашифрованный файл: {filePath}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<FileProcessor> files = new List<FileProcessor>
        {
            new PdfConverter(),
            new EncryptedFile()
        };

            foreach (var file in files)
            {
                file.Upload("document.txt");
                if (file is IConvertibleFile convertible)
                {
                    convertible.Convert("document.txt");
                }
            }
        }
    }
}
