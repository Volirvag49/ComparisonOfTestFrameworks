using System;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.Parallelism
{
    /// <summary>
    /// Последовательное выполнение тестов - по умолчанию
    /// </summary>
    [TestClass]
    public class MethodLevel
    {
        #region Публичные методы

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [TestMethod]
        public void TestCase1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [TestMethod]
        public void TestCase2()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [TestMethod]
        public void TestCase3()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [TestMethod]
        public void TestCase4()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [TestMethod]
        public void TestCase5()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        #endregion
    }
}