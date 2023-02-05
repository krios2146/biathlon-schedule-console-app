using BiathlonProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace BiathlonProject.Tests
{
    [TestClass]
    public class ConsoleInterfaceTests
    {
        private ConsoleInterface console;
        private ConsolePrinter printer;
        private string[] newEntry;

        [TestInitialize]
        public void Setup()
        {
            printer = new ConsolePrinter();
            console = new ConsoleInterface();
            console.SetPrinter(printer);
            newEntry = new string[] { "0", "Jan", "1", "2", "Test", "Location" };
        }

        [TestMethod]
        public void AskUserWhatToDo_InputIsValid_ReturnsInput()
        {
            // Arrange
            string[][] table = new string[][] { };

            // Act
            string result = console.AskUserWhatToDo(table);

            // Assert
            Assert.IsTrue(Regex.IsMatch(result, "^[1-3 0]$"));
        }

        [TestMethod]
        public void AskUserWhatToDo_InputIsInvalid_AskAgain()
        {
            // Arrange
            string[][] table = new string[][] { };
            console.AskUserWhatToDo(table);

            // Act
            string result = console.AskUserWhatToDo(table);

            // Assert
            Assert.IsTrue(Regex.IsMatch(result, "^[1-3 0]$"));
        }

        [TestMethod]
        public void AskUserForNewEntry_InputIsValid_ReturnsArray()
        {
            // Act
            string[] result = console.AskUserForNewEntry();

            // Assert
            Assert.AreEqual(6, result.Length);
        }

        [TestMethod]
        public void AskUserToUpdateEntry_InputIsValid_ReturnsArray()
        {
            // Arrange
            string[][] table = new string[][] { newEntry };

            // Act
            string[] result = console.AskUserToUpdateEntry(table);

            // Assert
            Assert.AreEqual(6, result.Length);
        }

        [TestMethod]
        public void AskUserToUpdateEntry_InputIdIsInvalid_ReturnsNull()
        {
            // Arrange
            string[][] table = new string[][] { newEntry };

            // Act
            string[] result = console.AskUserToUpdateEntry(table);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void AskUserWhatEntryToDelete_InputIsValid_ReturnsInt()
        {
            // Arrange
            string[][] table = new string[][] { newEntry };

            // Act
            int result = console.AskUserWhatEntryToDelete(table);

            // Assert
            Assert.AreEqual(0, result);
        }
    }

}
