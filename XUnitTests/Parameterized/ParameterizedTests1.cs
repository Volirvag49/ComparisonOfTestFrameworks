using System.Reflection;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTests.Insulation
{
    /// <summary>
    /// Проверка изолированности тестов
    /// </summary>
    public class ParameterizedTests1
    {
        #region Поля

        private readonly ITestOutputHelper _testOutputHelper;

        #endregion

        #region Конструктор

        public ParameterizedTests1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Тест-кейс 1
        /// </summary>
        [InlineData("1111", "222")]
        [Theory]
        public void ParameterizedTests1_TestCase1(string element, string element2)
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine($"element: {element}");
            _testOutputHelper.WriteLine("");

            Thread.Sleep(3000);
            Assert.Equal(element, element);
        }

        /// <summary>
        /// Тест-кейс 2
        /// </summary>
        [InlineData("5555")]
        [InlineData("6666")]
        [InlineData("7777")]
        [InlineData("8888")]
        [Theory]
        public void ParameterizedTests1_TestCase2(string element)
        {
            _testOutputHelper.WriteLine($"{GetType().Name}__{MethodBase.GetCurrentMethod().Name}");
            _testOutputHelper.WriteLine($"element: {element}");
            _testOutputHelper.WriteLine("");

            Thread.Sleep(3000);
            Assert.Equal(element, element);
        }

        #endregion
    }
}