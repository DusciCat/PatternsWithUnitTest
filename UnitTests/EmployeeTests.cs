using Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestToString()
        {
            // Assign
            // Action
            // Assert
            Assert.AreEqual("Id #1  Имя: F  Фамилия: L  Отдел: D", new Employee
            {
                Id = 1,
                Department = "D",
                FirstName = "F",
                LastName = "L"
            }.ToString());
        }
    }
}