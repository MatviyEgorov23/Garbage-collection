using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд1_3_
{
    class Play : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        private bool disposed = false;

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Console.WriteLine("Створено об’єкт Play.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"П'єса: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Рік: {Year}");
        }

        // --- ДЕСТРУКТОР ---
        ~Play()
        {
            Console.WriteLine("Деструктор Play викликано!");
        }

        // --- IDisposable ---
        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Метод Dispose() викликано для Play.");
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }
    }
}
