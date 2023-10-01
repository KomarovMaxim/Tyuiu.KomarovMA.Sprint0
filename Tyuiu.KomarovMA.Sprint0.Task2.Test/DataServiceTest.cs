using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint0.Task2.Lib;
namespace Tyuiu.KomarovMA.Sprint0.Task2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Максим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Максим", res);

        }
    }
}
