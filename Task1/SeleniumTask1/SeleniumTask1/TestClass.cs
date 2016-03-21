using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumTask1
{
    [TestFixture()]
    public class TestClass
    {
        private ChromeDriver driver;
        private LoginPage loginPage;
        private SecureAreaPage secureAreaPage;

        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            secureAreaPage = new SecureAreaPage(driver);
        }


        [Test]
        public void LoginErrorTest()
        {
            loginPage.Open();
            loginPage.UserNameInput.SendKeys("WrongName");
            loginPage.PasswordInput.SendKeys("SuperSecretPassword!");
            loginPage.LoginButton.Click();
            Assert.AreEqual(loginPage.ErrorMessage.Text, "Your username is invalid!\r\n×");
        }

        [Test]
        public void LoginTest()
        {
            loginPage.Open();
            loginPage.UserNameInput.SendKeys("zalando-lounge");
            loginPage.PasswordInput.SendKeys("SuperSecretPassword!");
            loginPage.LoginButton.Click();

            Assert.AreEqual(secureAreaPage.SuccessMessage.Text, "You logged into a secure area!\r\n×");
        }

        [Test]
        public void LogoutTest()
        {
            loginPage.Open();
            loginPage.UserNameInput.SendKeys("zalando-lounge");
            loginPage.PasswordInput.SendKeys("SuperSecretPassword!");
            loginPage.LoginButton.Click();
            secureAreaPage.LogoutButton.Click();
            Assert.AreEqual(secureAreaPage.SuccessMessage.Text, "You logged out of the secure area!\r\n×");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
