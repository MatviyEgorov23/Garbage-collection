using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_завд2_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("АТБ", "вул. Центральна 10", ShopType.Продовольчий);
            shop.ShowInfo();

            shop.Dispose();

            Console.WriteLine("Об'єкт Shop після виклику Dispose().\n");
        }
    }
}
