using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;



namespace Projeto1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange: abrir o navegador com o ChromeDriver

            new DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();

            // Act: navegar para o site da Caelum
            driver.Navigate().GoToUrl("https://www.caelum.com.br");

            // Assert: verificar se o título da página contém "Caelum"
            Assert.Contains("Caelum", driver.Title);
        }
    }
}
