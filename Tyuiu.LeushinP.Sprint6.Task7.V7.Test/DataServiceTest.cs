
using NUnit.Framework;
using System;
using System.IO;
using Tyuiu.LeushinP.Sprint6.Task7.V7.Lib;

namespace Tyuiu.LeushinP.Sprint6.Task7.V7.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidGetMatrix()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V17.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}