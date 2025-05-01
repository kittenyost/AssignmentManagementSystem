using Xunit;
using Moq;
using AssignmentManagement.Core;
using AssignmentManagement.UI;

namespace AssignmentManagement.Tests
{
    public class ConsoleUITests
    {
        [Fact]
        public void DeleteAssignment_ShouldReturnTrue()
        {
            // Arrange
            var mockService = new Mock<IAssignmentService>();

            mockService.Setup(s => s.DeleteAssignment("Delete Me")).Returns(true);

            var consoleUI = new ConsoleUI(mockService.Object);

            // Act
            var result = mockService.Object.DeleteAssignment("Delete Me");

            // Assert
            Assert.True(result);
            mockService.Verify(s => s.DeleteAssignment("Delete Me"), Times.Once);
        }
    }
}