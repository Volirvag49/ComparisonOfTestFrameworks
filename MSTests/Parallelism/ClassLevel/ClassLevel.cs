using System;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.Parallelism.ClassLevel
{
    /// <summary>
    /// Последовательное выполнение тестов - по умолчанию
    /// </summary>
    [TestClass]
    public class ClassLevel1
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

    /// <summary>
    /// Последовательное выполнение тестов - по умолчанию
    /// </summary>
    [TestClass]
    public class ClassLevel2
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

    /// <summary>
    /// Последовательное выполнение тестов - по умолчанию
    /// </summary>
    [TestClass]
    public class ClassLevel3
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