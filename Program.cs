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

            String answer = Console.ReadLine();

            if (answer.Equals("Y"))
            {
                String[][] table = data.GetTable();
                printer.PrintTable(table);
            }

            if (answer.Equals("N"))
            {
                Console.WriteLine(data.GetRow(1));
            }
        }
    }
}
