using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Axxess_Selenium_Login_Test
{
   public class TestLogin
    {
       [Fact]
       public void TestPositiveLogin()
       {
           //Login Test
           //test two and commit 2
           var driver = new ChromeDriver();
           driver.Navigate().GoToUrl("https://accounts.axxessweb.com/Login");
           driver.FindElementById("Login_UserName").SendKeys("wohe25@gmail.com");
           driver.FindElementById("Login_Password").SendKeys("temp2015");
           driver.FindElementById("Login_Submit").Click();

       }
    }
}
