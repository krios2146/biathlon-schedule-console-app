using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiathlonProject
{
    class BiathlonScheduleData
    {
        private readonly String[][] table =
        {
            new String[] { "1", "Feb", "08", "19", "Biathlon World Championships", "Germany" },
            new String[] { "2", "Mar", "02", "05", "Biathlon World Cup Nove Mesto", "Czech Republic" },
            new String[] { "3", "Mar", "09", "12", "Biathlon World Cup", "Sweden" },
            new String[] { "4", "Mar", "16", "19", "Biathlon World Cup Final", "Norway" }
        };

        public String[][] GetTable()
        {
            return table;
        }

        public String[] GetRow(int number)
        {
            return (String[])table.GetValue(number - 1);
        }

        public String[] GetColumn(int number)
        {
            String[] column = new String[table.GetLength(0)];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                column[i] = (String) table.GetValue(i, number - 1);
            }

            return column;
        } 
    }
}
