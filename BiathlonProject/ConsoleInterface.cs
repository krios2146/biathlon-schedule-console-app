using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BiathlonProject
{
    public class ConsoleInterface : IConsoleInterface
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

        public string[] AskUserToUpdateEntry(string[][] table)
        {
            Console.WriteLine("Enter the id of the row you want to update: ");
            string id = Console.ReadLine();

            int rowIndex = -1;
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i][0] == id)
                {
                    rowIndex = i;
                    break;
                }
            }

            if (rowIndex == -1)
            {
                Console.WriteLine("No row was found with the given id");
                return null;
            }

            string[] row = table[rowIndex];

            Console.WriteLine("Enter the number of the field you want to update: ");
            Console.WriteLine("1. Month");
            Console.WriteLine("2. Start Day");
            Console.WriteLine("3. End Day");
            Console.WriteLine("4. Event Name");
            Console.WriteLine("5. Location");

            string fieldNumber = Console.ReadLine();

            int fieldIndex;
            if (!Int32.TryParse(fieldNumber, out fieldIndex) || fieldIndex < 1 || fieldIndex > 5)
            {
                Console.WriteLine("Invalid field number");
                return null;
            }

            Console.WriteLine("Enter the new value for the field: ");
            string newValue = Console.ReadLine();

            if (fieldIndex == 1)
            {
                while (!IsValidMonth(newValue))
                {
                    Console.WriteLine("Invalid Month. Enter Month (Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec): ");
                    newValue = Console.ReadLine();
                }
            }

            if (fieldIndex == 2 || fieldIndex == 3)
            {
                while (!IsValidDay(newValue))
                {
                    Console.WriteLine("Invalid Day. Enter End Day (1-31): ");
                    newValue = Console.ReadLine();
                }
            }

            row[fieldIndex] = newValue;
            return row;
        }

        public int AskUserWhatEntryToDelete(string[][] table)
        {
            Console.WriteLine("Enter the ID of the entry you want to delete: ");
            string input = Console.ReadLine();

            while (!IsValidId(input, table))
            {
                Console.WriteLine("Invalid input. Please enter a valid entry ID.");
                input = Console.ReadLine();
            }
            return Int32.Parse(input);
        }

        private static bool IsValidMonth(string month)
        {
            string[] validMonths = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            return Array.Exists(validMonths, element => element == month);
        }

        private static bool IsValidDay(string day)
        {
            int parsedDay;
            if (!Int32.TryParse(day, out parsedDay))
            {
                return false;
            }
            return parsedDay >= 1 && parsedDay <= 31;
        }

        private static bool IsValidId(string input, string[][] table)
        {
            if (Int32.TryParse(input, out int result) && result > 0 && result <= table.Length)
            {
                return true;
            }
            return false;
        }

    }
}
