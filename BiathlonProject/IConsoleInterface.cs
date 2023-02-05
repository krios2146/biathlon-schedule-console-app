using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiathlonProject
{
    public interface IConsoleInterface
    {
        string AskUserWhatToDo(string[][] table);
        string[] AskUserForNewEntry();
        string[] AskUserToUpdateEntry(string[][] table);
        int AskUserWhatEntryToDelete(string[][] table);
    }
}
