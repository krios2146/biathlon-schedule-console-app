using System;

namespace BiathlonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BiathlonScheduleData data = new BiathlonScheduleData();
            Printer printer = new Printer();

            Console.WriteLine("Print a table? (Y/N)");

            string answer = Console.ReadLine();

            if (answer.ToLower().Equals("y"))
            {
                string[][] table = data.GetTable();
                printer.PrintTable(table);
            }

            if (answer.ToLower().Equals("n"))
            {
                Console.WriteLine(data.GetRow(1));
            }
        }
    }
}
