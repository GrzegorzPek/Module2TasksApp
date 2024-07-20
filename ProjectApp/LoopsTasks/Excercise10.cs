using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public static class Excercise10
    {     
            // Funkcja obliczająca NWD (Największy Wspólny Dzielnik) używając algorytmu Euklidesa
            static int NWD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }         
            static int NWW(int a, int b)
            {
                return (a * b) / NWD(a, b);
            }

            public static void Task10()
            {         
                Console.WriteLine("Podaj pierwszą liczbę:");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę:");
                int number2 = int.Parse(Console.ReadLine());             
                int result = NWW(number1, number2);
                Console.WriteLine("Najmniejsza Wspólna Wielokrotność (NWW) liczb " + number1 + " i " + number2 + " to: " + result);
            }        
    }
}
