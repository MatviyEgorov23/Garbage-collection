using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s1 = new Store("Shop1", "вул. Центральна, 10", StoreType.Grocery);
            Store s2 = new Store("Shop2", "вул. Київська, 22", StoreType.Shoes);

            s1.PrintInfo();
            s2.PrintInfo();

            // Викликаємо Dispose вручну
            s1.Dispose();
            s2.Dispose();

            // Для демонстрації фіналізатора
            s1 = null;
            s2 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
