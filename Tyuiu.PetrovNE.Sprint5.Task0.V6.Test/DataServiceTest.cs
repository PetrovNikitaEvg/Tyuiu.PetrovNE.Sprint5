using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PetrovNE.Sprint5.Task0.V6.Lib;

namespace Tyuiu.PetrovNE.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\\Users\\niki8\\source\\repos\\Tyuiu.PetrovNE.Sprint5\\Tyuiu.PetrovNE.Sprint5.Task0.V6\\bin\\Debug\\OutputFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}
