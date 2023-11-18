using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PetrovNE.Sprint5.Task1.V10.Lib;

namespace Tyuiu.PetrovNE.Sprint5.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\niki8\source\repos\Tyuiu.PetrovNE.Sprint5\Tyuiu.PetrovNE.Sprint5.Task1.V10\bin\Debug\OutputFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
