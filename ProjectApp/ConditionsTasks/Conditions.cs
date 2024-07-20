using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks.Conditions
{
    public static class Conditions
    {
       
        public static void CTasks()
        {
            Console.WriteLine("\nEnter the number of taks");
            bool subMenu;
            subMenu = true;  
            while (subMenu==true)
            {            
                Console.WriteLine("Please enter the number of task 1-13 q - qiut\n:");
                var operationConditions = Console.ReadLine();
                switch (operationConditions)
                {
                    case "1":
                        Excercise1.Task1();                                      
                        break;
                    case "2":
                        Excercise2.Task2();
                        break;
                    case "3":
                        Excercise3.Task3();
                        break;
                    case "4":
                        Excercise4.Task4();
                        break;
                    case "5":
                        Excercise5.Task5();                                      
                        break;
                    case "6":
                        Excercise6.Task6();
                        break;
                    case "7":
                        Excercise7.Task7();
                        break;
                    case "8":
                        Excercise8.Task8();
                        break;
                    case "9":
                        Excercise9.Task9();                                   
                        break;
                    case "10":
                        Excercise10.Task10();
                        break;
                    case "11":
                        Excercise11.Task11();
                        break;
                    case "12":
                        Excercise12.Task12();
                        break;
                    case "13":
                        Excercise13.Task13();                                      
                        break;
                    default:
                        Console.WriteLine("\nAction you entered does not exist");
                        subMenu = false;
                        break;
                }
            }
        }
    }
}

    

