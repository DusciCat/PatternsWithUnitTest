using Chain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class DirectorTests
    {
        [TestMethod]
        public void Test_ProcessRequest_WithUnderLimit()
        {
            // assign
            var director = new Director();
            // action
            var result = director.ProcessRequest(new Purchase(1, director.Limit - 1, "p"));
            // assert
            Assert.AreEqual(result, "Director одобренный запрос# 1");
        }

        [TestMethod]
        public void Test_ProcessRequest_WithOverLimit()
        {
            // assign
            var director = new Director();
            director.SetSuccessor(new TestApprover());
            // action
            var result = director.ProcessRequest(new Purchase(1, director.Limit + 1, "p"));
            // assert
            Assert.AreEqual(result, TestApprover.Result);
        }
    }
}