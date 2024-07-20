using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise9
    {
        public static void Task9()
        {
            int b = int.MaxValue;
            Console.WriteLine($"Zamiana liczby dziesiętnej na binarną podaj liczbę naturalną od {1} do {b}: ");
            int liczba = int.Parse(Console.ReadLine());

            string n = string.Empty;
            int l2 = liczba;

            while (l2 > 0)
            {
                n = (l2 % 2) + n;
                l2 = l2 / 2;
                Console.Write($"{n} ");
            }
            Console.WriteLine($"Reprezentacja binarna liczby: {liczba} to: {n}");
        }
    }
}
