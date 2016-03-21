using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTask1
{
    [TestFixture()]
    public class TestClass
    {
        private ChromeDriver _driver;

        [SetUp]
        public void Init()
        {
            _driver = new ChromeDriver();
        }


        [Test]
        public void HomeItemTest()
        {
            _driver.Navigate().GoToUrl("http://zalando-edinc.rhcloud.com/shifting_content/menu");
            _driver.FindElement(By.LinkText("Home")).Click();

            Assert.AreEqual(_driver.Url, "http://zalando-edinc.rhcloud.com/");
        }

        [Test]
        public void AboutTest()
        {
            _driver.Navigate().GoToUrl("http://zalando-edinc.rhcloud.com/shifting_content/menu");
            _driver.FindElement(By.LinkText("About")).Click();

            Assert.AreEqual(_driver.Url, "http://zalando-edinc.rhcloud.com/about");
        }

        [Test]
        public void ContactUsTest()
        {
            _driver.Navigate().GoToUrl("http://zalando-edinc.rhcloud.com/shifting_content/menu");
            _driver.FindElement(By.LinkText("Contact Us")).Click();

            Assert.AreEqual(_driver.Url, "http://zalando-edinc.rhcloud.com/contact-us");
        }

        [Test]
        public void PortfolioTest()
        {
            _driver.Navigate().GoToUrl("http://zalando-edinc.rhcloud.com/shifting_content/menu");
            _driver.FindElement(By.LinkText("Portfolio")).Click();

            Assert.AreEqual(_driver.Url, "http://zalando-edinc.rhcloud.com/portfolio");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
