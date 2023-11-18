using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PetrovNE.Sprint5.Task2.V9.Lib;

namespace Tyuiu.PetrovNE.Sprint5.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\niki8\source\repos\Tyuiu.PetrovNE.Sprint5\Tyuiu.PetrovNE.Sprint5.Task2.V9\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
