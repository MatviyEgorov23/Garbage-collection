using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд2_3_
{
    enum ShopType
    {
        Продовольчий,
        Господарський,
        Одяг,
        Взуття
    }

    class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }

        private bool disposed = false;

        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
            Console.WriteLine("Створено об’єкт Shop.");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Магазин: {Name}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Тип: {Type}");
        }

        // --- IDisposable ---
        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("Метод Dispose() викликано для Shop.");
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        // --- ДЕСТРУКТОР
        ~Shop()
        {
            Console.WriteLine("Деструктор Shop викликано!");
        }
    }
}
