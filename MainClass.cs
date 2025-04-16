using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARgv24_C;

namespace TARgv24_C
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            /// 2 Tund

            // Создание объектов класса Isik
            Isik isik1 = new Isik("Juku", 18, "12345678901", "Tallinn", Sugu.Meess);
            isik1.PrindiInfo();

            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Vanus = 35;
            isik2.Sugu = Sugu.Naine;
            isik2.Aadress = "Tartu";
            isik2.Isikukood = "212116446";
            isik2.PrindiInfo();

            // Пример с массивами
            Console.WriteLine("-----for + Massiv--------");

            // Массив объектов Isik
            Isik[] isikud = new Isik[10];
            string[] nimid = new string[10] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

            // Заполнение массива isikud
            for (int i = 0; i < 10; i++)
            {
                isikud[i] = new Isik
                {
                    Nimi = "Isik" + i,
                    Vanus = i + 10,
                    Isikukood = "1234678901" + i,
                    Aadress = "Tallinn" + i
                };
            }

            // Вывод информации о каждом объекте из массива isikud
            for (int i = 0; i < 10; i++)
            {
                isikud[i].PrindiInfo();
            }

            // Обратный цикл от 10 до 1
            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine(j);
            }

            // Цикл while (пример)
            int k = 5;
            while (k > 0)
            {
                Console.WriteLine($"k = {k}");
                k--;
            }

            // Цикл с ConsoleKeyInfo
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Vajuta Backspace, et lõpetada...");
                key = Console.ReadKey(true);
            }
            while (key.Key != ConsoleKey.Backspace);

            // Изменение фона и текста
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            // Завершение программы
            Console.WriteLine("Programm lõpetatud. Vajuta suvalist klahvi...");
            Console.ReadKey();

            //// Task 3: soodus
            //Console.Write("Sisesta toote hind enne soodustust: ");
            //float s = float.Parse(Console.ReadLine());
            //float soodust = FunktsioonideClass_1.soodus(s);
            //Console.WriteLine($"Soodushind: {soodust}");

            //// Task 4: temperatuur
            //Console.Write("Kui palju temperatuur on õues: ");
            //int t = int.Parse(Console.ReadLine());
            //FunktsioonideClass_1.temp(t);

            //// Task 5: pikkus
            //Console.Write("Mis pikkus teil on? ");
            //int p = int.Parse(Console.ReadLine());
            //FunktsioonideClass_1.pikk(p);
        }
    }
}
