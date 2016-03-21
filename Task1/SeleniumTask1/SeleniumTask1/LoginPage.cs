using OpenQA.Selenium;

namespace SeleniumTask1
{
    class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public IWebElement UserNameInput
        {
            get { return _driver.FindElement(By.Id("username")); }
        }

        public IWebElement PasswordInput
        {
            get { return _driver.FindElement(By.Id("password")); }
        }

        public IWebElement LoginButton
        {
            get { return _driver.FindElement(By.TagName("Button")); }
        }

        public IWebElement ErrorMessage
        {
            get { return _driver.FindElement(By.XPath("//div[@class='flash error']")); }
        }

        public IWebElement SuccessMessage
        {
            get { return _driver.FindElement(By.XPath("//div[@class='flash success']")); }
        }

        public void Open()
        {
            _driver.Navigate().GoToUrl("http://zalando-edinc.rhcloud.com/login");
        }


    }
}
