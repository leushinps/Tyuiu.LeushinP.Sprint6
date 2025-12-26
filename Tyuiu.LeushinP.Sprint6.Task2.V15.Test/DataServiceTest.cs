using NUnit.Framework;
using Tyuiu.LeushinP.Sprint6.Task2.V15.Lib;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.LeushinP.Sprint6.Task2.V15.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void Checked()
        {
            DataService ds = new DataService();
            int startValue = -5, stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 70.14, 55.21, 41.05, 27.96, 15.48, 1.00, -13.06, -28.16, -42.96, -56.77, -69.83 };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}