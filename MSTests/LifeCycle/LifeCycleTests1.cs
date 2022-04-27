using System;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.LifeCycle
{
    /// <summary>
    /// Тестовый класс
    /// </summary>
    [TestClass]
    public class LifeCycleTests1 : IDisposable
    {
        #region Конструктор

        /// <summary>
        /// Конструктор - вызывается один раз для каждого теста
        /// </summary>
        public LifeCycleTests1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// ClassInitialize - вызывается один раз для каждого класса
        /// </summary>
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("LifeCycleTests1_ClassInitialize");
            Console.WriteLine();
        }

        /// <summary>
        /// ClassCleanup - вызывается один раз для каждого класса
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("LifeCycleTests1_ClassCleanup");
            Console.WriteLine();
        }

        /// <summary>
        /// TestInitialize - вызывается один раз для каждого теста
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// TestCleanup - вызывается один раз для каждого теста
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Тест-кейс 1
        /// </summary>
        [TestMethod]
        public void TestCase1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс 2
        /// </summary>
        [TestMethod]
        public void TestCase2()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            ;
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Dispose - вызывается один раз для каждого теста
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        #endregion
    }
}