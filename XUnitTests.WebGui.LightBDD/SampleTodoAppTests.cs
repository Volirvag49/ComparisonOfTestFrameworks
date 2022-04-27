using System.Drawing;
using LightBDD.Framework.Scenarios;
using LightBDD.XUnit2;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace NUnitTests.WebGui.LightBDD
{
    public class Tests : FeatureFixture
    {
        #region Поля

        /// <summary>
        /// IWebDriver
        /// </summary>
        private IWebDriver _driver;

        /// <summary>
        /// Название созданного элемента
        /// </summary>
        private string _createdItemName;

        #endregion

        #region Публичные методы

        [Scenario]
        public void WhenCreatedNewItem_Then_ItemsNameAreEqual()
        {
            Runner.RunScenario(
                _ => Given_BrowserDriver(new ChromeDriver()),
                _ => Given_Opened_Browser("https://lambdatest.github.io/sample-todo-app/"),
                _ => When_NewItemCreated("itemName"),
                _ => Then_New_Item_IsCorrect("itemName"));
        }

        [Scenario]
        public void WhenCreatedNewItem_Then_ItemsNameAreEqual_2()
        {
            Runner.RunScenario(
                _ => Given_BrowserDriver(new ChromeDriver()),
                _ => Given_Opened_Browser("https://lambdatest.github.io/sample-todo-app/"),
                _ => When_NewItemCreated("itemName2"),
                _ => Then_New_Item_IsCorrect("itemName2"));
        }

        #endregion

        #region Приватные методы

        private void Given_BrowserDriver(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        private void Given_Opened_Browser(string url)
        {
            // 1 | open || 
            _driver.Navigate().GoToUrl(url);

            // 2 | setWindowSize | 1294x1400 | 
            _driver.Manage().Window.Size = new Size(1294, 1400);
        }


        private void When_NewItemCreated(string newItemName)
        {
            // 3 | click | id=sampletodotext | 
            _driver.FindElement(By.Id("sampletodotext")).Click();

            // 4 | type | id=sampletodotext | New item
            _driver.FindElement(By.Id("sampletodotext")).SendKeys(newItemName);

            // 5 | click | id=addbutton | 
            _driver.FindElement(By.Id("addbutton")).Click();

            _createdItemName = _driver.FindElement(By.CssSelector(".ng-scope:nth-child(6) > .done-false")).Text;
        }

        private void Then_New_Item_IsCorrect(string excepted)
        {
            Assert.Equal(excepted, _createdItemName);
        }

        #endregion
    }
}