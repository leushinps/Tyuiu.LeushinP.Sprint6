using NUnit.Framework;
using Tyuiu.LeushinP.Sprint6.Task0.V5.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task0.V5.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [Test]
        public void TestMethod1()
        {
            int x = 5;
            double wait = -114.5;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
