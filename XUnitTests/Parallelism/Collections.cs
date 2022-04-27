using System.Reflection;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTests.Parallelism
{
    /// <summary>
    /// </summary>
    [Collection("Our Test Collection #1")]
    public class Collection1
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public Collection1(ITestOutputHelper testOutputHelper)
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

    [Collection("Our Test Collection #2")]
    public class Collection2
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public Collection2(ITestOutputHelper testOutputHelper)
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

    [Collection("Our Test Collection #3")]
    public class Collection3
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public Collection3(ITestOutputHelper testOutputHelper)
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

    [Collection("Our Test Collection #4")]
    public class Collection4
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public Collection4(ITestOutputHelper testOutputHelper)
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

    [Collection("Our Test Collection #5")]
    public class Collection5
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public Collection5(ITestOutputHelper testOutputHelper)
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