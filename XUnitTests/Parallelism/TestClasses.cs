using System.Reflection;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTests.Parallelism
{
    /// <summary>
    /// </summary>
    public class TestClass1
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public TestClass1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase1()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase2()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase3()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase4()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        #endregion
    }

    /// <summary>
    /// </summary>
    public class TestClass2
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public TestClass2(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase5()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase6()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase7()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Тест-кейс
        /// </summary>
        [Fact]
        public void TestCase8()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
            Thread.Sleep(3000);
        }

        #endregion
    }
}