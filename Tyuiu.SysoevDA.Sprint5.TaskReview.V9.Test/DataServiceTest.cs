using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using System.IO;
using Tyuiu.SysoevDA.Sprint5.TaskReview.V9.Lib;

namespace Tyuiu.SysoevDA.Sprint5.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.SysoevDA.Sprint5.Review\Tyuiu.SysoevDA.Sprint5.TaskReview.V9\bin\Debug\OutPutDataFileTask7V9.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
