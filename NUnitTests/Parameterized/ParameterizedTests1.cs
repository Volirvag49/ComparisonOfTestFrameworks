using System;
using System.Reflection;
using System.Threading;
using NUnit.Framework;

namespace NUnitTests.Parameterized
{
    /// <summary>
    /// Проверка тестов с параметрами
    /// </summary>
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ParameterizedTests1
    {
        /// <summary>
        /// Тест-кейс 1
        /// </summary>
        [TestCase("1111")]
        [TestCase("2222")]
        [TestCase("3333")]
        [TestCase("4444")]
        [Test]
        public void ParameterizedTests1_TestCase1(string element)
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"element: {element}");
            Console.WriteLine();

            Thread.Sleep(3000);
            Assert.AreEqual(element, element);
        }

        /// <summary>
        /// Тест-кейс 2
        /// </summary>
        [TestCase("5555")]
        [TestCase("6666")]
        [TestCase("7777")]
        [TestCase("8888")]
        [Test]
        public void ParameterizedTests1_TestCase2(string element)
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine($"element: {element}");
            Console.WriteLine();

            Thread.Sleep(3000);
            Assert.AreEqual(element, element);
        }
    }
}