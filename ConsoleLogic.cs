using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiathlonProject
{
    class ConsoleLogic
    {
        private ConsoleInterface consoleInterface = new ConsoleInterface();
        private ConsoleBiathlonData data = new ConsoleBiathlonData();

        public void InitiateProgramm()
        {
            string answer = consoleInterface.AskUserWhatToDo(data.GetTable());

            if (answer.Equals("1"))
            {
                CreateNewEntry();
            }
            if (answer.Equals("2"))
            {
                UpdateEntry();
            }
        }

        public void CreateNewEntry()
        {
            string[] row = consoleInterface.AskUserForNewEntry();

            data.AddRow(row);

            InitiateProgramm();
        }

        public void UpdateEntry()
        {
            string[] row = consoleInterface.AskUserToUpdateEntry(data.GetTable());

            if (row == null)
            {
                consoleInterface.AskUserToUpdateEntry(data.GetTable());
            }

            data.UpdateRow(row);

            InitiateProgramm();
        }
    }

}
