using OpenQA.Selenium;

namespace SeleniumTask1
{
    class SecureAreaPage
    {
        private IWebDriver _driver;

        public SecureAreaPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement LogoutButton
        {
            get { return _driver.FindElement(By.LinkText("Logout")); }
        }

        public IWebElement SuccessMessage
        {
            get { return _driver.FindElement(By.XPath("//div[@class='flash success']")); }
        }
    }
}
