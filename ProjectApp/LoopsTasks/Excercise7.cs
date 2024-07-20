using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public static class Excercise7
    {
        public static void Task7()
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
            Console.Clear();
            int cursorLefta;
            int cursorTopb;
            aToInt = aToInt/2+1;
            Console.SetCursorPosition(aToInt, 1);

            // I
            while (column <= aToInt)
            {
                column++;
                for (int row = 1; row < column; row++) 
                {  
                    Console.Write("a");                
                }
             
                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt, cursorTopb+1);
            }

            // II
            int columnb = aToInt;
            while (columnb >= 1)
            {
                columnb--;
                for (int row = 1; row <= columnb; row++) 
                {
                    Console.Write($"a");
                    i++;
                }
                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt, cursorTopb + 1);
            }
            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.SetCursorPosition(cursorLefta-1, cursorTopb-1);         

            //III
            column =0;
            while (column <= aToInt-1)
            {
                column++;
                for (int row = 1; row < column; row++) 
                {
                    Console.Write("a");
                    cursorLefta = Console.CursorLeft;
                    cursorTopb = Console.CursorTop;
                    Console.SetCursorPosition(cursorLefta-2, cursorTopb);
                    i++;
                }
                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt, cursorTopb -1 );
            }

            //IV
            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.SetCursorPosition(aToInt-1, cursorTopb);
            columnb = aToInt;

            while (columnb >= 1)
            {
                columnb--;
                for (int row = 1; row <= columnb; row++)
                {
                    Console.Write("a");
                    cursorLefta = Console.CursorLeft;
                    cursorTopb = Console.CursorTop;
                    Console.SetCursorPosition(cursorLefta - 2, cursorTopb);
                    i++;  
                }
                cursorLefta = Console.CursorLeft;
                cursorTopb = Console.CursorTop;
                Console.SetCursorPosition(aToInt - 1, cursorTopb - 1);              
            }
            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.WriteLine("");
            cursorLefta = Console.CursorLeft;
            cursorTopb = Console.CursorTop;
            Console.SetCursorPosition(0, cursorTopb+aToInt+aToInt);
        }
    }
}
