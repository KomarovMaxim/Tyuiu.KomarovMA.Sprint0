using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint0.Task3.Lib;
namespace Tyuiu.KomarovMA.Sprint0.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()

        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
