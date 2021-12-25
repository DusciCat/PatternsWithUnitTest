using System.Linq;
using Adapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class RecordServerTests
    {
        [TestMethod]
        public void Test_RecordServer_CreatesExpectedExployees()
        {
            // Assign
            var server = new RecordServer();

            // Action
            var result = server.GetEmployees();

            // Assert
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(1001, result.First().Id);
            Assert.AreEqual("Иван", result.First().FirstName);
            Assert.AreEqual("Иванов", result.First().LastName);
            Assert.AreEqual("Финансовый", result.First().Department);
        }
    }
}