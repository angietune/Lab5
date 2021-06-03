using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace Lab5
{
    class LoginPage : AbstractPage
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Name")]
        public IWebElement name;

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement submitBtn;

        public void LoginApp(string name, string password)
        {
            IAction action = new Actions(driver)
                .SendKeys(name)
                .SendKeys(password)
                .Click(submitBtn)
                .Build();

            action.Perform();
        }

    }
}