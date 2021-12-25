using Chain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class VicePresidentTests
    {
        [TestMethod]
        public void Test_ProcessRequest_WithUnderLimit()
        {
            // assign
            var vicePresident = new VicePresident();
            // action
            var result = vicePresident.ProcessRequest(new Purchase(1, vicePresident.Limit - 1, "p"));
            // assert
            Assert.AreEqual(result, "VicePresident одобренный запрос# 1");
        }

        [TestMethod]
        public void Test_ProcessRequest_WithOverLimit()
        {
            // assign
            var vicePresident = new VicePresident();
            vicePresident.SetSuccessor(new TestApprover());
            // action
            var result = vicePresident.ProcessRequest(new Purchase(1, vicePresident.Limit + 1, "p"));
            // assert
            Assert.AreEqual(result, TestApprover.Result);
        }
    }
}