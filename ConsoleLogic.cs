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

        }
    }
}
