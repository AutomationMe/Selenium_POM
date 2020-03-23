using FirstCry_Shopping.POM_Framework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCry_Shopping.Pages
{

    public class Home :SeleniumExtensions
    {
        public IWebDriver _driver = null;
        By Searchbox = By.XPath("//*[@id='search_box']");
        By Searchbutton = By.XPath("//*[@class='search-button']");
        public void HomePage(string url)
        {
          
        }
        public IWebElement PasswordTextBox()
        {
            var passwordtextbox = Initialise._driver.FindElement(Searchbox);
            return passwordtextbox;
        }

        public void EnterPasswordTextBox(string password)
        {
            Enter(PasswordTextBox(), password);
        }
        public void EnterUsername(string username)
        {
            Enter(PasswordTextBox(), username);
        }

        public IWebElement submitButton()
        {
            return Initialise._driver.FindElement(Searchbutton);
        }
        public void ClickSubmitButton()
        {
            ButtonClick(submitButton));
        }
    }
}
