using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiathlonProject
{
    class ConsoleInterface
    {
        Printer printer = new Printer();

        public string AskUserWhatToDo(string[][] table)
        {
            printer.PrintTable(table);

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add new event");
            Console.WriteLine("2. Change event data");
            Console.WriteLine("3. Delete event");

            string answer = Console.ReadLine();

            if (!answer.Contains("1") || !answer.Contains("2") || !answer.Contains("3"))
            {
                Console.WriteLine("You should pick one of the options and enter it number");
                AskUserWhatToDo(table);
            }

            return answer;
        }

    }
}
