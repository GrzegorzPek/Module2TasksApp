using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise9
    {
        public static void Task9()
        {
            int temp;

            string input = Console.ReadLine();
            int.TryParse(input, out temp);

            if (temp < 0)
            {
                Console.WriteLine("Temp < 0 – cholernie piździ");
            }
            else if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Temp 0 – 10 – zimno");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Temp 10 – 20 – chłodno");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Temp 20 – 30 – w sam raz");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Temp 30 – 40 – zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("Temp >= 40 – a weź wyprowadzam się na Alaskę.");
            }
        }
    }
}