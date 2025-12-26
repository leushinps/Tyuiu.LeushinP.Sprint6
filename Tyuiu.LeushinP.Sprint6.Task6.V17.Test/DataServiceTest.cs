
using NUnit.Framework;
using System;
using Tyuiu.LeushinP.Sprint6.Task6.V17.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task6.V17.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V17.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "wFrlYaZtHI XuLENkL BV ltxrhBXm HbJcPW";

            Assert.AreEqual(wait, res);
        }
    }
}