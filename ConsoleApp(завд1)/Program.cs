using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд1_
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Piesa p1 = new Piesa("Гамлет", "Вільям Шекспір", "Трагедія", 1600);
            Piesa p2 = new Piesa("Лісова пісня", "Леся Українка", "Драма-феєрія", 1911);

            p1.PrintInfo();
            p2.PrintInfo();

            // Примусове видалення (лише для демонстрації)
            p1 = null;
            p2 = null;

            // Запускає GC, щоб деструктор викликався
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
