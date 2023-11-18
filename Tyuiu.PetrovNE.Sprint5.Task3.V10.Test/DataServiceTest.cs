using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.PetrovNE.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\niki8\source\repos\Tyuiu.PetrovNE.Sprint5\Tyuiu.PetrovNE.Sprint5.Task3.V10\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
