using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestDemo1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver myD;
            myD = new ChromeDriver("C:\\Selenium jas\\chromedriver_win32");
            myD.Url = "https://www.google.com/";
            Thread.Sleep(4000);
            myD.FindElement(By.Name("q")).SendKeys("DXC Technologies");
            Thread.Sleep(4000);
            myD.FindElement(By.ClassName("gNO89b")).Click();
            Thread.Sleep(4000);
            if (myD.Title.ToString() == "DXC Technologies")
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            
            Console.WriteLine(myD.FindElement(By.XPath("/html/body/div[7]/div[3]/div[7]/div[1]/div/div/div/div")).Text);

            myD.Close();
           
        }
    }
}