using bigsmall.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace bigsmall.CommonMethodObject
{
    public class BigObject
    {
        public void sale()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement sale = BaseClass.driver.FindElement(By.XPath("//*[@id='myheader']/div[1]/div/div/ul/li[2]/a"));
            sale.Click();
        }

        public void lights()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement lights = BaseClass.driver.FindElement(By.XPath("//a[@href='/products/paper-home-fairy-lights']"));
            lights.Click();
        }

        public void wishlist()
           {
               BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
               IWebElement wishlist = BaseClass.driver.FindElement(By.XPath("//Span[text()='Add to Wishlist']"));
               wishlist.Click();
           }

      /* public void viewwish()
           {
               BaseClass.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
               IWebElement viewwish = BaseClass.Driver.FindElement(By.XPath("//a[@class= 'swym-view-history']"));
               viewwish.Click();
           }*/

        public void cart()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement cart = BaseClass.driver.FindElement(By.XPath("//*[@id='AddToCartForm-4765028352088']/button"));
            cart.Click();
        }

        public void checkout()
        {
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement checkout = BaseClass.driver.FindElement(By.XPath("//*[@id='CartDrawer']/form/div[2]/div[3]/button"));
            checkout.Click();
            
        }
    }
}
