using System;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.Parameterized
{
    /// <summary>
    /// Проверка тестов с параметрами
    /// </summary>
    [TestClass]
    public class ParameterizedTests1
    {
        #region Публичные методы

        /// <summary>
        /// Тест-кейс 1
        /// </summary>
        [DataRow("1111")]
        [DataRow("2222")]
        [DataRow("3333")]
        [DataRow("4444")]
        [DataTestMethod]
        public void ParameterizedTests1_TestCase1(string element)
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"element: {element}");
            Console.WriteLine();

            Thread.Sleep(3000);
            Assert.AreEqual(element, element);
        }

        /// <summary>
        /// Тест-кейс 1
        /// </summary>
        [DataRow("5555")]
        [DataRow("6666")]
        [DataRow("7777")]
        [DataRow("8888")]
        [DataTestMethod]
        public void ParameterizedTests1_TestCase2(string element)
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"element: {element}");
            Console.WriteLine();

            Thread.Sleep(3000);
            Assert.AreEqual(element, element);
        }

        #endregion
    }
}