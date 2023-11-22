using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.PetrovNE.Sprint5.Task6.V8.Lib;

namespace Tyuiu.PetrovNE.Sprint5.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V29.txt";

            int wait = 2, res = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, res);
        }
    }
}
