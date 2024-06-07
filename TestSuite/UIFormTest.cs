using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestSuite
{
    [TestClass]
    public class UIFormTest
    {
        private ChromeDriver driver;

        private string _url = "https://localhost:7149"; //app's URL

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void TestFormSubmission()
        {
            // Navigating to the web page
            driver.Navigate().GoToUrl(_url);

            // Filling out the form
            driver.FindElement(By.Id("name")).SendKeys("Manan Jain");
            driver.FindElement(By.Id("email")).SendKeys("manan.jain@example.com");
            driver.FindElement(By.Id("phone")).SendKeys("1234567890");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            // Simulating delay to load welcome message
            Thread.Sleep(3000);

            // Verifying the welcome message
            var welcomeMessage = driver.FindElement(By.TagName("h1")).Text;
            Assert.IsTrue(welcomeMessage.Contains("Welcome, Manan Jain"), "Welcome message does not contain expected substring");
        }
    }
}