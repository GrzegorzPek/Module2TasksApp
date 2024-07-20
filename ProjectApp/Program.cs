
using ProjectApp;
using ProjectApp.ConditionsTasks.Conditions;
using ProjectApp.DataTypesTasks.DataTypes;
using ProjectApp.LoopsTasks.Loops;
using System;
using System.Threading.Tasks;

namespace AppExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);

            var mainMenu = actionService.GetMenuActionsByMenuName("Menu");
            var mainMenuC = actionService.GetMenuActionsByMenuName("Conditions");
            var mainMenuDT = actionService.GetMenuActionsByMenuName("DataTypes");
            var mainMenuL = actionService.GetMenuActionsByMenuName("Loops");

            Console.WriteLine("Welcome to Programs and Tasks!");
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine("Please let me now what you want to do enter the issue number from 1 to 3 or q-quit:\n");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id} {mainMenu[i].Name}");
                }
                var operation = Console.ReadKey();

                switch (operation.KeyChar)
                {
                    case '1':
                        {
                            Console.WriteLine("\nConditions");
                            actionService = Initialize(actionService);
                            for (int i = 0; i < mainMenuC.Count; i++)
                            {
                                Console.WriteLine($"{mainMenuC[i].Id} {mainMenuC[i].Name}");
                            }
                            Conditions.CTasks();
                        }
                        break;

                    case '2':
                        Console.WriteLine("\nDataTypes");
                        actionService = Initialize(actionService);
                        for (int i = 0; i < mainMenuDT.Count; i++)
                        {
                            Console.WriteLine($"{mainMenuDT[i].Id} {mainMenuDT[i].Name}");
                        }
                        DataTypes.DTTask();
                        break;
                    case '3':
                        Console.WriteLine("\nLoops");
                        actionService = Initialize(actionService);
                        for (int i = 0; i < mainMenuL.Count; i++)
                        {
                            Console.WriteLine($"{mainMenuL[i].Id} {mainMenuL[i].Name}");
                        }
                        Loops.LTasks();
                        break;
                    default:
                        Console.WriteLine("Action you entered does not exist");
                        menu = false;
                        break;
                }
            }
        }
        public static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Conditions Tasks", "Menu");
            actionService.AddNewAction(2, "Data Types Tasks", "Menu");
            actionService.AddNewAction(3, "Loops Tasks", "Menu");

            actionService.AddNewAction(1, "   ---program, w którymn sa zmienne dotyczące danych pracownika firmy ", "DataTypes");
            actionService.AddNewAction(2, "   ---program, w którym sa 3 zmienne z jedną literą", "DataTypes");
            actionService.AddNewAction(3, "   ---program, który na podstawie podanej szerokości i długości prostokąta wylicza długość przekątnej ", "DataTypes");
            actionService.AddNewAction(4, "   ---program, który tworzy 2 zmienne liczbowe, oraz jedną tekstową:", "DataTypes");
            actionService.AddNewAction(5, "   ---program, do którego wpisuje dane personalne użytkownika tj. Imię, nazwisko, numer telefonu itd.", "DataTypes");

            actionService.AddNewAction(1, "   ---program, sprawdza ile jest liczby pierwszych w zakresie 0 – 100.", "Loops");
            actionService.AddNewAction(2, "   ---program, który sprawdza czy podana przez użytkownika liczba jest parzysta czy nieparzysta", "Loops");
            actionService.AddNewAction(3, "   ---program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.", "Loops");
            actionService.AddNewAction(4, "   ---program, który po podaniu liczby całkowitej wyświetla piramidę liczb od 1 do podanej liczby n ", "Loops");
            actionService.AddNewAction(5, "   ---program, który dla liczb od 1 do 20 wyświeta na ekranie ich 3 potęgę", "Loops");
            actionService.AddNewAction(6, "   ---program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ + 1/3 + ¼ itd.", "Loops");
            actionService.AddNewAction(7, "   ---program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej ", "Loops");
            actionService.AddNewAction(8, "   ---program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.Testowe dane: Abcdefg Rezultat Gfedcba", "Loops");
            actionService.AddNewAction(9, "   ---program, który zamieni liczbę dziesiętną na liczbę binarną", "Loops");
            actionService.AddNewAction(10, "  ---program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb", "Loops");

            actionService.AddNewAction(1, "   ---program, który tworzy dwie zmienne int i sprawdzi czy są one równe czy nie.", "Conditions");
            actionService.AddNewAction(2, "   ---program, który sprawdza czy podana przez użytkownika liczba jest parzysta czy nieparzysta.", "Conditions");
            actionService.AddNewAction(3, "   ---program, który sprawdza czy podana przez użytkownika liczba jest dodatnia czy ujemna", "Conditions");
            actionService.AddNewAction(4, "   ---program, który sprawdza czy podany przez użytkownika rok jest rokiem przestępnym", "Conditions");
            actionService.AddNewAction(5, "   ---program, sprawdza czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła,", "Conditions");
            actionService.AddNewAction(6, "   ---program, który pobiera wzrost użytkownika i przypisuje mu wymyśloną kategorię wzrostu ", "Conditions");
            actionService.AddNewAction(7, "   ---program, który pobiera 3 liczby od użytkownika i sprawdza, która jest największa", "Conditions");
            actionService.AddNewAction(8, "   ---program, który sprawdza, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:", "Conditions");
            actionService.AddNewAction(9, "   ---program, który odczytuje temperaturę I zwraca nazwę jak w poniższych kryteriach", "Conditions");
            actionService.AddNewAction(10, "  ---program, który sprawdza, czy z 3 podanych długości można stworzyć trójkąt", "Conditions");
            actionService.AddNewAction(11, "  ---program, który zmienia ocenę ucznia na jej opis wg podanej tabeli", "Conditions");
            actionService.AddNewAction(12, "  ---program, który pobiera numer dnia tygodnia i wyświetla jego nazwę", "Conditions");
            actionService.AddNewAction(13, "  ---program, kalkulator: dodaje, odejmuje, mnoży, dzieli dwie liczby", "Conditions");

            return actionService;
        }
    }
}


