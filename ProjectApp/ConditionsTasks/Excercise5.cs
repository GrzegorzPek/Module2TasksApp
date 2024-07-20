using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp.ConditionsTasks
{
    public static class Excercise5
    {
        private enum StatePosition
        {
            Poseł = 21,
            Senator = 30,
            Prezydent = 35,
            Premier = 21
        }
        public static void Task5()
        {
            Console.WriteLine("Podaj swój wiek. Sprawdzę jakie stanowiska możesz pełnić w Polsce.");
            Console.WriteLine("Twój wiek:");

            var a = Console.ReadLine();
            int userAge;
            Int32.TryParse(a.ToString(), out userAge);

            string[] possibilitiesInfo = new string[]
            {
                "\nNie masz ukończonych 21 lat.\nNie możesz ubiegać się o żadne stanowisko państwowe.",
                "\nMożesz ubiegać się o następujące stanowiska: "
            };

            if (userAge < 21)
            {
                Console.WriteLine(possibilitiesInfo[0]);
            }
            else
            {
                bool firstLoop = true;
                string commaSign;
                string listOfPositions = "";
                int statePositionIndex;
                foreach (string statePosition in Enum.GetNames(typeof(StatePosition)))
                {
                    commaSign = firstLoop ? "" : ", ";
                    statePositionIndex = (int)Enum.Parse(typeof(StatePosition), statePosition);
                    listOfPositions = userAge >= statePositionIndex ? listOfPositions + commaSign + statePosition : listOfPositions;
                    firstLoop = false;
                }
                Console.WriteLine(possibilitiesInfo[1] + listOfPositions);
            }
            Console.WriteLine("\nAby zakończyć naciśnij dowolny klawisz.");
            Console.ReadKey();
        }
    }
}

