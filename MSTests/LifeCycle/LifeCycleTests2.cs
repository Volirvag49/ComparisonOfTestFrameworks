using System;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.LifeCycle
{
    /// <summary>
    /// </summary>
    [TestClass]
    public class LifeCycleTests2 : IDisposable
    {
        #region Конструктор

        /// <summary>
        /// Конструктор - вызывается один раз для каждого теста
        /// </summary>
        public LifeCycleTests2()
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
            Console.WriteLine("LifeCycleTests2_ClassInitialize");
            Console.WriteLine();
        }

        /// <summary>
        /// ClassCleanup - вызывается один раз для каждого класса
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("LifeCycleTests2_ClassCleanup");
            Console.WriteLine();
        }

        /// <summary>
        /// Инициализатор теста
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Инициализатор теста
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Тест-кейс 3
        /// </summary>
        [TestMethod]
        public void TestCase3()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс 4
        /// </summary>
        [TestMethod]
        public void TestCase4()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
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