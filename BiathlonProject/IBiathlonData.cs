using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiathlonProject
{
    public interface IBiathlonData
    {
        string[][] GetTable();
        string[] GetRow(int number);
        string[] GetColumn(int number);
        void AddRow(string[] row);
        void UpdateRow(string[] row);
        void DeleteRow(int id);
    }
}
