using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiathlonProject
{
    class BiathlonScheduleData
    {
        private string[][] table;

        public BiathlonScheduleData()
        {
            table =  new string[][] 
            {
                new string[] { "1", "Feb", "08", "19", "Biathlon World Championships", "Germany" },
                new string[] { "2", "Mar", "02", "05", "Biathlon World Cup", "Czech Republic" },
                new string[] { "3", "Mar", "09", "12", "Biathlon World Cup", "Sweden" },
                new string[] { "4", "Mar", "16", "19", "Biathlon World Cup Final", "Norway" }
            };
        }

        public BiathlonScheduleData(string[][] table)
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
    }
}
