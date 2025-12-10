using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд2_
{
    public enum StoreType
    {
        Grocery,        // продовольчий
        Household,      // господарський
        Clothes,        // одяг
        Shoes           // взуття
    }

    public class Store : IDisposable
    {
        // Поля
        private string name;
        private string address;
        private StoreType type;
        private bool disposed = false;

        // Властивості
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public StoreType Type
        {
            get => type;
            set => type = value;
        }

        // Конструктор

        public Store(string name, string address, StoreType type)
        {
            Name = name;
            Address = address;
            Type = type;

            Console.WriteLine($"Створено магазин: {Name}");
        }

        // Метод виводу

        public void PrintInfo()
        {
            Console.WriteLine("=== Інформація про магазин ===");
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine("==============================");
        }

        // Реалізація IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Тут очищаються керовані ресурси
                    Console.WriteLine($"Dispose: Звільняємо ресурси магазину: {Name}");
                }

                // Тут очищаються некеровані ресурси (якби були)
                disposed = true;
            }
        }

        // Фіналізатор (деструктор)

        ~Store()
        {
            Console.WriteLine($"Фіналізатор: Магазин {Name} видаляється GC.");
            Dispose(false);
        }
    }
}
