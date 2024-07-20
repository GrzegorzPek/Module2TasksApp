using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.LoopsTasks
{
    public class Excercise8
    {
        public static void Task8()
        {       
            Console.WriteLine("Wprowadź ciąg znaków:");
            string inputString = Console.ReadLine();

            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            Console.WriteLine("Odwrócony ciąg znaków: " + reversedString);
        }
    }
}
