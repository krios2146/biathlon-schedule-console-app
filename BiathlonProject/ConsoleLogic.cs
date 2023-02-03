using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiathlonProject
{
    public class ConsoleLogic
    {
        private ConsoleInterface consoleInterface = new ConsoleInterface();
        private ConsoleBiathlonData data = new ConsoleBiathlonData();

        public void InitiateProgramm()
        {
            string answer = consoleInterface.AskUserWhatToDo(data.GetTable());

            switch (answer)
            {
                case "1":
                    CreateNewEntry();
                    break;

                case "2":
                    UpdateEntry();
                    break;

                case "3":
                    DeleteEntry();
                    break;

                default:
                    break;
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

        public void DeleteEntry()
        {
            int id = consoleInterface.AskUserWhatEntryToDelete(data.GetTable());

            data.DeleteRow(id);

            InitiateProgramm();
        }
    }

}
