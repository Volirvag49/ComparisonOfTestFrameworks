using System;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTests.Insulation
{
    /// <summary>
    /// Проверка изолированности тестов
    /// </summary>
    public class InsulationTests1 : IDisposable
    {
        #region Поля

        /// <summary>
        /// Строковая переменная
        /// </summary>
        private string _sampleText;


        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор - вызывается один раз для каждого теста
        /// </summary>
        public InsulationTests1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _testOutputHelper.WriteLine("");
        }

        #endregion

        #region Публичные методы

        [Fact]
        public void Test_1()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _testOutputHelper.WriteLine("");
        }

        [Fact]
        public void Test_2()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _testOutputHelper.WriteLine("");
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _sampleText = $"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}";
            _testOutputHelper.WriteLine($"_sampleText: {_sampleText}");
            _testOutputHelper.WriteLine("");
        }

        #endregion
    }
}