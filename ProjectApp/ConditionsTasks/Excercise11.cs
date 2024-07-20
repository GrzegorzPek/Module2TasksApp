using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise11
    {
        public static void Task11()
        {
            
            Console.WriteLine("Please enter the grade 1 - 6 : ");
            var a = Console.ReadLine();
            int aToInt;
            string grade;
            Int32.TryParse(a.ToString(), out aToInt);
            switch(aToInt)
            {
                case 6:                  
                    grade = "Celujący";                   
                    break;
                case 5:
                    grade = "Bardzo Dobry";
                    break;
                case 4:
                    grade = "Dobry";
                    break;
                case 3:
                    grade = "Dostateczny";
                    break;
                case 2:
                    grade = "Dopuszczający";
                    break;
                case 1:
                    grade = "Niedostateczny";
                    break;
                default:
                    grade = "You have put wrong grade";
                    break;
            }
            Console.WriteLine($"your grade is: {grade}");
        }
    }
}