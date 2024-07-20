using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise13
    {
        public static void Task13()
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            var a = Console.ReadLine();
            double aToDouble;
            double.TryParse(a.ToString(), out aToDouble);
            Console.WriteLine("Podaj drugą liczbę");
            var b = Console.ReadLine();
            double bToDouble;
            double.TryParse(b.ToString(), out bToDouble);
            int operacja;
            double wynik;

            Console.WriteLine("Podaj numer operacji do wyokonania");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            var op = Console.ReadLine();
            Int32.TryParse(op.ToString(), out operacja);

            switch (operacja)
            {
                case 1:
                    wynik = aToDouble + bToDouble;
                    Console.WriteLine($"Twój wynik to: {wynik:N2}");
                    break;
                case 2:
                    wynik = aToDouble - bToDouble;
                    Console.WriteLine($"Twój wynik to: {wynik:N2}");
                    break;
                case 3:
                    wynik = aToDouble * bToDouble;
                    Console.WriteLine($"Twój wynik to: {wynik:N2}");
                    break;
                case 4:
                    wynik = aToDouble / bToDouble;
                    Console.WriteLine($"Twój wynik to: {wynik:N2}");
                    break;             
                default:
                    Console.WriteLine("Podałeś niewłaściwy nr operacji");
                    break;                   
            }
          
        }
    }
}