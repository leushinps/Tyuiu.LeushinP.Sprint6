using NUnit.Framework;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.LeushinP.Sprint6.Task5.V14.Lib;
namespace Tyuiu.LeushinP.Sprint6.Task5.V14.Test
{
    [TestFixture]
    public sealed class DataServiceTest
    {
        [Test]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask5V14.txt";
            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 13, 11.49, 10, 14.52, 16, 13.66, 19, 11, 11.28 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}