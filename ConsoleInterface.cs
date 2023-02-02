using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BiathlonProject
{
    class ConsoleInterface
    {
        ConsolePrinter printer = new ConsolePrinter();

        public string AskUserWhatToDo(string[][] table)
        {
            printer.PrintTable(table);

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Add new event (1)");
            Console.WriteLine("Change event data (2)");
            Console.WriteLine("Delete event (3)");
            Console.WriteLine("Exit (0)");

            string answer = Console.ReadLine();

            if (!Regex.IsMatch(answer, "^[1-3 0]$"))
            {
                Console.WriteLine("You should pick one of the options (1, 2, 3 or 0), please try again");

                AskUserWhatToDo(table);
            }

            return answer;
        }

        public string[] AskUserForNewEntry()
        {
            string[] entry = new string[6];

            Console.WriteLine("Enter Month (Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec): ");
            string month = Console.ReadLine();
            while (!IsValidMonth(month))
            {
                Console.WriteLine("Invalid Month. Enter Month (Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec): ");
                month = Console.ReadLine();
            }
            entry[1] = month;

            Console.WriteLine("Enter Start Day (1-31): ");
            string startDay = Console.ReadLine();
            while (!IsValidDay(startDay))
            {
                Console.WriteLine("Invalid Day. Enter Start Day (1-31): ");
                startDay = Console.ReadLine();
            }
            entry[2] = startDay;

            Console.WriteLine("Enter End Day (1-31): ");
            string endDay = Console.ReadLine();
            while (!IsValidDay(endDay))
            {
                Console.WriteLine("Invalid Day. Enter End Day (1-31): ");
                endDay = Console.ReadLine();
            }
            entry[3] = endDay;

            Console.WriteLine("Enter Name: ");
            entry[4] = Console.ReadLine();

            Console.WriteLine("Enter Location: ");
            entry[5] = Console.ReadLine();

            return entry;
        }
        static bool IsValidMonth(string month)
        {
            string[] validMonths = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            return Array.Exists(validMonths, element => element == month);
        }

        static bool IsValidDay(string day)
        {
            int parsedDay;
            if (!Int32.TryParse(day, out parsedDay))
            {
                return false;
            }
            return parsedDay >= 1 && parsedDay <= 31;
        }

    }
}
