using System;
using System.Reflection;
using NUnit.Framework;

namespace NUnitTests.LifeCycle
{
    /// <summary>
    /// </summary>
    [TestFixture]
    public class LifeCycleTests1 : IDisposable
    {

        /// <summary>
        /// Метод, украшенный атрибутом OneTimeSetUp, будет выполнен до выполнения любого теста.
        /// </summary>
        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Console.WriteLine($"RootFixtureSetup__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Метод, украшенный атрибутом OneTimeTearDown, будет выполнен после выполнения всех тестов.
        /// </summary>
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Console.WriteLine($"RootFixtureSetup__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Метод, украшенный атрибутом SetUp, будет выполняться перед каждым тестом
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Метод, украшенный атрибутом TearDown, будет выполняться после каждого теста.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        /// <summary>
        /// Конструктор класса будет выполняться перед любым методом
        /// и может использоваться для подготовки полей,
        /// которые не следует изменять при выполнении тестов.
        /// </summary>
        public LifeCycleTests1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }


        [Test]
        [Order(1)]
        public void Test_1()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }

        [Test]
        [Order(2)]
        public void Test_2()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }



        public void Dispose()
        {
            Console.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine();
        }
    }
}