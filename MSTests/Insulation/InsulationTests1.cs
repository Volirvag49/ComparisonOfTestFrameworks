using System;
using System.Reflection;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTests.Insulation
{
    /// <summary>
    /// Проверка изолированности тестов
    /// </summary>
    [TestClass]
    public class InsulationTests1
    {
        #region Поля

        /// <summary>
        /// Строковая переменная
        /// </summary>
        private string _sampleText;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор - вызывается один раз для каждого теста
        /// </summary>
        public InsulationTests1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
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
            Console.WriteLine("InsulationTests1_ClassInitialize");
            Console.WriteLine();
        }

        /// <summary>
        /// ClassCleanup - вызывается один раз для каждого класса
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("InsulationTests1_ClassCleanup");
            Console.WriteLine();
        }

        /// <summary>
        /// TestInitialize - вызывается один раз для каждого теста
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
            Console.WriteLine();
        }

        /// <summary>
        /// TestCleanup - вызывается один раз для каждого теста
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс 1
        /// </summary>
        [TestMethod]
        public void InsulationTests1_TestCase1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс 2
        /// </summary>
        [TestMethod]
        public void InsulationTests1_TestCase2()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Dispose - вызывается один раз для каждого теста
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
            Console.WriteLine();
        }

        #endregion
    }
}