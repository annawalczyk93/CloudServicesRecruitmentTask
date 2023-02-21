using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudServicesRecruitmentTask.Pages
{
    public class FormPage
    {
        public void Navigate(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://app.bluealert.pl/ba/form/formularz-testowy");
        }
        public IWebElement GetNameField(IWebDriver driver)
        {
            return driver.FindElement(By.Name("first_name"));
        }
        public IWebElement GetSurnameField(IWebDriver driver)
        {
            return driver.FindElement(By.Name("last_name"));
        }
        public IWebElement GetEmailField(IWebDriver driver)
        {
            return driver.FindElement(By.Name("email"));
        }
        public IWebElement GetPhoneField(IWebDriver driver)
        {
            return driver.FindElement(By.Name("phone"));
        }
        public IWebElement GetPeselField(IWebDriver driver)
        {
            return driver.FindElement(By.Name("pesel"));
        }
        public IWebElement GetIdNumberField(IWebDriver driver)
        {
            return driver.FindElement(By.Name("id_numer"));
        }
        public IWebElement GetDoBField(IWebDriver driver)
        {
            return driver.FindElement(By.Name("date"));
        }
        public IWebElement GetNextButton(IWebDriver driver)
        {
            return driver.FindElement(By.Id("form_button_next"));
        }
        public IWebElement GetFieldGroupZgoda(IWebDriver driver)
        {
            return driver.FindElement(By.Id("fieldgroup_zgoda"));
        }


    }
}
