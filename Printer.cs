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
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    Console.WriteLine(table[i][j]);
                }
            }
        }
    }
}
