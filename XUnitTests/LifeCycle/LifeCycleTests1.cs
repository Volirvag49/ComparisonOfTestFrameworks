using System;
using System.Diagnostics;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTests.LifeCycle
{
    /// <summary>
    /// </summary>
    public class LifeCycleTests1 :  IDisposable
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public LifeCycleTests1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;

            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }

        #endregion

        #region Публичные методы

        [Fact]
        public void Test_1()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }

        [Fact]
        public void Test_2()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }


        public void Dispose()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }

        #endregion
    }

    public class ClassFixture : IDisposable
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public ClassFixture(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;

            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }
        #endregion
        public void Dispose()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }

    }

    public class CollectionFixture : IDisposable
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public CollectionFixture(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;

            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }
        #endregion
        public void Dispose()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine("");
        }

    }

}