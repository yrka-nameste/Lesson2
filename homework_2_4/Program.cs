using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_4
{
    interface IFileHandler
    {
        void Open(string filePath);
    }

    interface ITextReadable
    {
        void ReadText();
    }

    interface IAudioPlayable
    {
        void PlayAudio();
    }

    class TextFileHandler : IFileHandler, ITextReadable
    {
        public void Open(string filePath)
        {
            Console.WriteLine($"Открываем текстовый файл: {filePath}");
        }

        public void ReadText()
        {
            Console.WriteLine("Читаем текст из файла...");
        }
    }

    class AudioFileHandler : IFileHandler, IAudioPlayable
    {
        public void Open(string filePath)
        {
            Console.WriteLine($"Открываем аудиофайл: {filePath}");
        }

        public void PlayAudio()
        {
            Console.WriteLine("Воспроизводим аудио...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileHandler textFile = new TextFileHandler();
            IFileHandler audioFile = new AudioFileHandler();

            textFile.Open("file.txt");
            if (textFile is ITextReadable readable)
            {
                readable.ReadText();
            }

            audioFile.Open("song.mp3");
            if (audioFile is IAudioPlayable playable)
            {
                playable.PlayAudio();
            }
        }
    }
}
