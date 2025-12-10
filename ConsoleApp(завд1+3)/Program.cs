using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд1_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Play play = new Play("Гамлет", "Вільям Шекспір", "Трагедія", 1601))
            {
                play.ShowInfo();
            }

            Console.WriteLine("Об'єкт Play вийшов з блоку using.\n");
        }
    }
}
