using Chain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class ChainTests
    {
        [TestMethod]
        public void Test()
        {
            // assign
            var d = new Director();
            var vp = new VicePresident();
            var p = new President();
            d.SetSuccessor(vp);
            vp.SetSuccessor(p);

            var p1 = new Purchase(2034, 350.00, "Supplies");
            var p2 = new Purchase(2035, 32590.10, "Project X");
            var p3 = new Purchase(2036, 122100.00, "Project Y");

            // action
            // assert
            Assert.AreEqual(d.ProcessRequest(p1), "Director одобренный запрос# 2034");
            Assert.AreEqual(d.ProcessRequest(p2), "President одобренный запрос# 2035");
            Assert.AreEqual(d.ProcessRequest(p3), "Запрос# 2036 требуется исполнительная встреча!");
        }
    }
}