using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise4
    {
       public static void Task4()
        {

            Console.WriteLine("Enter number a: of rows and columns\n : ");
            var a = Console.ReadLine();
            Console.WriteLine("");
            int aToInt;
            Int32.TryParse(a.ToString(), out aToInt);
            int column = 0;
            int i = 1;
            int c;
            int[] l = new int[10];

            while (column <= aToInt)
            {
                column++;
                for (int row = 1; row <= column; row++) //nie trxeba pisac zero sla row =0; dla kazdego wiersza
                {
                    if (i <= aToInt)
                    {
                        Console.Write($"{i}   ");
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
