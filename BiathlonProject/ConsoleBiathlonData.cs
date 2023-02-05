using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiathlonProject
{
    public class ConsoleBiathlonData : IBiathlonData
    {
        private string[][] table;

        public ConsoleBiathlonData()
        {
            table =  new string[][] 
            {
                new string[] { "1", "Feb", "08", "19", "Biathlon World Championships", "Germany" },
                new string[] { "2", "Mar", "02", "05", "Biathlon World Cup", "Czech Republic" },
                new string[] { "3", "Mar", "09", "12", "Biathlon World Cup", "Sweden" },
                new string[] { "4", "Mar", "16", "19", "Biathlon World Cup Final", "Norway" }
            };
        }

        public ConsoleBiathlonData(string[][] table)
        {
            this.table = table;
        }

        public string[][] GetTable()
        {
            return table;
        }

        public string[] GetRow(int number)
        {
            return (string[])table.GetValue(number - 1);
        }

        public string[] GetColumn(int number)
        {
            string[] column = new string[table.Length];

            for (int i = 0; i < table.Length; i++)
            {
                column[i] = (string) table.GetValue(i, number - 1);
            }

            return column;
        }
        public void AddRow(string[] row)
        {
            int id = table.Length + 1;

            row[0] = id.ToString();

            for (int i = 2; i <= 3; i++)
            {
                if (row[i].Length == 1)
                {
                    row[i] = row[i].Insert(0, "0");
                }
            }

            table = table.Concat(new[] { row }).ToArray();
        }

        public void UpdateRow(string[] row)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i][0] == row[0])
                {
                    table[i] = row;
                    break;
                }
            }
        }

        public void DeleteRow(int id)
        {
            int indexToRemove = -1;

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i][0].Equals(id.ToString()))
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove != -1)
            {
                for (int i = indexToRemove; i < table.Length - 1; i++)
                {
                    table[i] = table[i + 1];
                }

                Array.Resize(ref table, table.Length - 1);
            }
        }
    }
}
