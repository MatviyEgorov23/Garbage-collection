using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд1_
{
    public class Piesa
    {
        private string title;
        private string author;
        private string genre;
        private int year;

        // Властивості
        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Genre
        {
            get => genre;
            set => genre = value;
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Рік не може бути від’ємним.");
                year = value;
            }
        }

        // Конструктор
        public Piesa(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;

            Console.WriteLine($"Створено п'єсу: {Title}");
            Console.WriteLine("===========================");
        }

        // Деструктор
        ~Piesa()
        {
            Console.WriteLine($"Об'єкт п'єси \"{Title}\" знищено.");
        }

        // Метод виведення
        public void PrintInfo()
        {
            Console.WriteLine($"П'єса: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Рік: {Year}");
            Console.WriteLine("===========================");
        }
    }
}