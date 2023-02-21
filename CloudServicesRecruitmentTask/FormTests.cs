using CloudServicesRecruitmentTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CloudServicesRecruitmentTask
{
    public class FormTests
    {
        IWebDriver driver;
        FormPage formPage;

        [SetUp]
        public void Setup()
        {
            formPage = new FormPage();
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new System.Drawing.Point(8, 30);
            driver.Manage().Window.Size = new System.Drawing.Size(1600, 900);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void FillFormWithCorrectData()
        {
            formPage.Navigate(driver);
            formPage.GetNameField(driver).SendKeys("Tester");
            formPage.GetSurnameField(driver).SendKeys("Testerski");
            formPage.GetEmailField(driver).SendKeys("test1234@gmail.com");
            formPage.GetPhoneField(driver).SendKeys("789098654");
            formPage.GetPeselField(driver).SendKeys("64101214487");
            formPage.GetIdNumberField(driver).SendKeys("AXT945327");
            formPage.GetDoBField(driver).SendKeys("2023-02-01");
            formPage.GetIdNumberField(driver).Click();
            formPage.GetNextButton(driver).Click();

            Assert.That(formPage.GetFieldGroupZgoda(driver).Displayed);
        }

        
        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}