using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab5
{
    public class Tests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [Test]
        public void Test1()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginApp("user", "user");
            IWebElement logout = driver.FindElement(By.XPath("//a[contains(.,'Logout')]"));
            Assert.AreEqual(logout.Text, "Logout");
        }

        
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}