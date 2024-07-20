using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.DataTypesTasks.DataTypes
{
    public static class DataTypes
    {

        public static void DTTask()
        {
            bool exitSubMenu = false;


            Console.WriteLine("Enter the number of Tasks 1-5, q-quit");
            var operationConditions = Console.ReadKey();

            switch (operationConditions.KeyChar)
            {
                case '1':
                    Console.WriteLine("You have choosen task 1");
                    Excercise1.Task1();
                    break;
                case '2':
                    Console.WriteLine("You have choosen task 2");
                    Excercise2.Task2();
                    break;
                case '3':
                    Console.WriteLine("You have choosen task 1");
                    Excercise3.Task3();

                    break;
                case '4':
                    Console.WriteLine("You have choosen task 1");
                    Excercise4.Task4();
                    break;
                case '5':
                    Console.WriteLine("You have choosen task 1");
                    Excercise5.Task5();
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Naciśnij dowolny klawisz, aby spróbować ponownie.");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
