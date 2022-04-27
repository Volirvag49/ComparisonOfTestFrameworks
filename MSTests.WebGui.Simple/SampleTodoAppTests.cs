using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MSTests.WebGui.Simple
{
    [TestClass]
    public class SampleTodoAppTests
    {
        #region Поля

        /// <summary>
        /// IWebDriver
        /// </summary>
        private IWebDriver _driver;

        #endregion

        #region Публичные методы

        /// <summary>
        /// TestInitialize - вызывается один раз для каждого теста
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _driver = new ChromeDriver();

            // 1 | open || 
            _driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");

            // 2 | setWindowSize | 1294x1400 | 
            _driver.Manage().Window.Size = new Size(1294, 1400);
        }

        [DataRow("newItem1")]
        [DataRow("New_Item")]
        [DataRow("")]
        [DataTestMethod]
        public void WhenCreatedNewItem_Then_ItemsNameAreEqual(string newItem)
        {
            // 3 | click | id=sampletodotext | 
            _driver.FindElement(By.Id("sampletodotext")).Click();

            // 4 | type | id=sampletodotext | New item
            _driver.FindElement(By.Id("sampletodotext")).SendKeys(newItem);

            // 5 | click | id=addbutton | 
            _driver.FindElement(By.Id("addbutton")).Click();

            string createdItemName = _driver.FindElement(By.CssSelector(".ng-scope:nth-child(6) > .done-false")).Text;

            // 6 | verifyText | css=.ng-scope:nth-child(6) > .done-false | New item
            Assert.AreEqual(newItem, createdItemName);
        }

        /// <summary>
        /// ClassCleanup - вызывается один раз для каждого класса
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Close();
        }

        #endregion
    }
}