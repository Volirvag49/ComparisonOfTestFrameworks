using System;
using System.Reflection;
using NUnit.Framework;

namespace NUnitTests.Insulation
{
    /// <summary>
    /// Проверка изолированности тестов
    /// </summary>
    [TestFixture]
    public class InsulationTests1
    {
        /// <summary>
        /// Строковая переменная
        /// </summary>
        private string _sampleText;

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

        ///// <summary>
        ///// Метод, украшенный атрибутом SetUp, будет выполняться перед каждым тестом
        ///// </summary>
        //[SetUp]
        //public void SetUp()
        //{
        //    Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
        //    Console.WriteLine($"_sampleText: {_sampleText}");
        //    _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
        //    Console.WriteLine($"_sampleText: {_sampleText}");
        //    Console.WriteLine();
        //}

        ///// <summary>
        ///// Метод, украшенный атрибутом TearDown, будет выполняться после каждого теста.
        ///// </summary>
        //[TearDown]
        //public void TearDown()
        //{
        //    Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
        //    Console.WriteLine($"_sampleText: {_sampleText}");
        //    _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
        //    Console.WriteLine($"_sampleText: {_sampleText}");
        //    Console.WriteLine();
        //}


        [Test]
        [Order(1)]
        public void Test_1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
            Console.WriteLine();
        }

        [Test]
        [Order(2)]
        public void Test_2()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            Console.WriteLine($"_sampleText: {_sampleText}");
            Console.WriteLine();
        }
    }
}