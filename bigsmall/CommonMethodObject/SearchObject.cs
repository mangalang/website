using bigsmall.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace bigsmall.CommonMethodObject
{
    public class SearchObject
    {
        public void HomePage()
        {
            //BaseClass.driver.Navigate().GoToUrl("https://www.bigsmall.in/");
            //BaseClass.driver.Manage().Window.Maximize();
        }
        public void OnSitePage()
        {
            // BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //IWebElement VerifySearch= BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/header/div[2]/div[2]/div[1]/div/a[1]/img[2]"));
            // VerifySearch.Click();
        }
        public void ClickOnSearch(string SearchData)
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement SearchBar = BaseClass.driver.FindElement(By.Name("q"));
            SearchBar.SendKeys(SearchData);
            //SearchBar.Click();
        }
        public void VerifyResult()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement SearchBar = BaseClass.driver.FindElement(By.Name("q"));
            SearchBar.Click();
            //BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //IWebElement result = BaseClass.driver.FindElement(By.XPath("//a[@class='snize-no-products-found-link']"));
            //*[@id="MainContent"]/div/div[1]/div/header/h1
        }


    }

}

