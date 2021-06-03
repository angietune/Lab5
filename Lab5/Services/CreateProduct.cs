using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Lab5.Services
{
    class CreateProduct : AbstractPage
    {
        public CreateProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            var loginPage = new LoginPage(driver);
            loginPage.LoginApp("user", "user");
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'All Products')]")]
        public IWebElement product;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create new')]")]
        public IWebElement create;
        public void AddProduct()
        {
            product.Click();
            create.Click();
            IWebElement productName = driver.FindElement(By.XPath("//input[@id='ProductName']"));
            IWebElement productCategory = driver.FindElement(By.XPath("//select[@id='CategoryId']"));
            SelectElement productCategoryValue = new SelectElement(productCategory);
            IWebElement productSupplier = driver.FindElement(By.XPath("//select[@id='SupplierId']"));
            SelectElement productSupplierValue = new SelectElement(productSupplier);
            IWebElement productPrice = driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
            IWebElement productQuantity = driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            IWebElement productStock = driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
            IWebElement productOrder = driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
            IWebElement productLevel = driver.FindElement(By.XPath("//input[@id='ReorderLevel']"));
            IWebElement CreateBtn = driver.FindElement(By.XPath("//input[@type='submit']"));

            productName.SendKeys("Pinapple");
            productCategory.Click();
            productCategoryValue.SelectByValue("8");
            productSupplier.Click();
            productSupplierValue.SelectByValue("1");
            productPrice.SendKeys("5");
            productQuantity.SendKeys("1");
            productStock.SendKeys("10");
            productOrder.SendKeys("10");
            productLevel.SendKeys("1");
            CreateBtn.Click();
        }
        
    }
}
