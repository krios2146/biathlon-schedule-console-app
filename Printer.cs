using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiathlonProject
{
    class Printer
    {
        public void PrintTable(string[][] table)
        {
            // Rows loop
            for (int i = 0; i < table.Length; i++)
            {
                // Columns loop
                for (int j = 0; j < table[i].Length; j++)
                {
                    string tableCell = table[i][j];

                    if (j <= 3)
                    {
                        tableCell = tableCell.PadRight(4);
                    }

                    // Wide cell for the name of the event
                    if (j == 4)
                    {
                        tableCell = tableCell.PadRight(35);
                    }

                    Console.Write(tableCell);
                }
                Console.WriteLine();
            }
        }
    }
}
