using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace XUnitTests.WebGui.Simple
{
    public class SampleTodoAppTests
    {
        #region Публичные методы

        [Fact]
        public void Test1()
        {
        }

        /// <summary>
        /// Тест-кейс 1
        /// </summary>
        [InlineData("newItem1")]
        [InlineData("New_Item")]
        [InlineData("")]
        [Theory]
        public void ParameterizedTests1_TestCase1(string newItem)
        {
            IWebDriver _driver = new ChromeDriver();

            // 1 | open || 
            _driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");

            // 2 | setWindowSize | 1294x1400 | 
            _driver.Manage().Window.Size = new Size(1294, 1400);

            // 3 | click | id=sampletodotext | 
            _driver.FindElement(By.Id("sampletodotext")).Click();

            // 4 | type | id=sampletodotext | New item
            _driver.FindElement(By.Id("sampletodotext")).SendKeys(newItem);

            // 5 | click | id=addbutton | 
            _driver.FindElement(By.Id("addbutton")).Click();

            string createdItemName = _driver.FindElement(By.CssSelector(".ng-scope:nth-child(6) > .done-false")).Text;

            // 6 | verifyText | css=.ng-scope:nth-child(6) > .done-false | New item
            Assert.Equal(newItem, createdItemName);

            _driver.Close();
        }

        #endregion
    }
}