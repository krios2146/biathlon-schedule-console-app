using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiathlonProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;

namespace BiathlonProject.Tests
{
    [TestClass]
    public class ConsoleLogicTests
    {

        private ConsoleLogic program;
        private Mock<IBiathlonData> dataMock;
        private Mock<IConsoleInterface> consoleInterfaceMock;

        [TestInitialize]
        public void TestInitialize()
        {
            dataMock = new Mock<IBiathlonData>();
            consoleInterfaceMock = new Mock<IConsoleInterface>();
            program = new ConsoleLogic();
        }

        [TestMethod]
        public void WhenAnswerIs1_CreateNewEntryIsCalled()
        {
            // Arrange
            string answer = "1";
            consoleInterfaceMock.Setup(c => c.AskUserWhatToDo(It.IsAny<string[][]>())).Returns(answer);

            // Act
            program.InitiateProgramm();

            // Assert
            consoleInterfaceMock.Verify(c => c.AskUserWhatToDo(It.IsAny<string[][]>()), Times.Once());
            dataMock.Verify(d => d.AddRow(It.IsAny<string[]>()), Times.Once());
        }

        [TestMethod]
        public void WhenAnswerIs2_UpdateEntryIsCalled()
        {
            // Arrange
            string answer = "2";
            consoleInterfaceMock.Setup(c => c.AskUserWhatToDo(It.IsAny<string[][]>())).Returns(answer);

            // Act
            program.InitiateProgramm();

            // Assert
            consoleInterfaceMock.Verify(c => c.AskUserWhatToDo(It.IsAny<string[][]>()), Times.Once());
            dataMock.Verify(d => d.AddRow(It.IsAny<string[]>()), Times.Once());
        }

        [TestMethod]
        public void WhenAnswerIs3_DeleteEntryIsCalled()
        {
            // Arrange
            string answer = "3";
            consoleInterfaceMock.Setup(c => c.AskUserWhatToDo(It.IsAny<string[][]>())).Returns(answer);

            // Act
            program.InitiateProgramm();

            // Assert
            consoleInterfaceMock.Verify(c => c.AskUserWhatToDo(It.IsAny<string[][]>()), Times.Once());
            dataMock.Verify(d => d.AddRow(It.IsAny<string[]>()), Times.Once());
        }

        [TestMethod]
        public void WhenAnswerIs0_Exiting()
        {
            // Arrange
            string answer = "0";
            consoleInterfaceMock.Setup(c => c.AskUserWhatToDo(It.IsAny<string[][]>())).Returns(answer);

            // Act
            program.InitiateProgramm();

            // Assert
            consoleInterfaceMock.Verify(c => c.AskUserWhatToDo(It.IsAny<string[][]>()), Times.Once());
        }
    }
}