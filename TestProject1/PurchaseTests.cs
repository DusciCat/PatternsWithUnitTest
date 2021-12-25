using Chain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class PurchaseTests
    {
        [TestMethod]
        public void Test_Purchase_WithValidArguments_CreateValidInstance()
        {
            // Assign
            // Action
            var inst = new Purchase(1, 2, "1");
            // Assert
            Assert.AreEqual(inst.Amount, 2);
            Assert.AreEqual(inst.Number, 1);
            Assert.AreEqual(inst.Purpose, "1");
        }
    }
}