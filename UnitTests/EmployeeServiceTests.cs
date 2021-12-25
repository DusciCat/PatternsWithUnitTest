using Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        [TestMethod]
        public void Test_GetEmployee_WithCorrectId_RetursExpectedValue()
        {
            // Assign
            var service = new EmployeeService();

            // Action
            var result = service.GetEmployee(1001);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1001, result.Id);
            Assert.AreEqual("Иван", result.FirstName);
            Assert.AreEqual("Иванов", result.LastName);
            Assert.AreEqual("Финансовый", result.Department);
        }

        [TestMethod]
        public void Test_GetEmployee_WithNotExistingId_RetursExpectedValue()
        {
            // Assign
            var service = new EmployeeService();

            // Action
            var result = service.GetEmployee(-1);

            // Assert
            Assert.IsNull(result);
        }
    }
}