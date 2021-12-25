﻿using Chain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class PresidentTests
    {
        [TestMethod]
        public void Test_ProcessRequest_WithUnderLimit()
        {
            // assign
            var director = new President();
            // action
            var result = director.ProcessRequest(new Purchase(1, director.Limit - 1, "p"));
            // assert
            Assert.AreEqual(result, "President одобренный запрос# 1");
        }

        [TestMethod]
        public void Test_ProcessRequest_WithOverLimit()
        {
            // assign
            var director = new President();
            // action
            var result = director.ProcessRequest(new Purchase(1, director.Limit + 1, "p"));
            // assert
            Assert.AreEqual(result, "Запрос# 1 требуется исполнительная встреча!");
        }
    }
}