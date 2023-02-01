using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiathlonProject
{
    class ProgrammLogic
    {
        private ConsoleInterface consoleInterface = new ConsoleInterface();
        private BiathlonScheduleData data = new BiathlonScheduleData();

        public void InitiateProgramm()
        {
            string answer = consoleInterface.AskUserWhatToDo(data.GetTable());

        }
    }
}
