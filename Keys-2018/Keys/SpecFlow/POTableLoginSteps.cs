using System;
using System.Collections.Generic;
using System.Threading;
using Keys.Global;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Keys 
{
    [Binding]
    public class PropertyOwnerLoginSteps
    {
        public IWebDriver driver = new ChromeDriver();
        
        [Given(@"User is on Login Page")]
        public void GivenUserIsOnLoginPage()
        {
            //ScenarioContext.Current.Pending();
            //Navigate to Login Page
            driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/Account/Login");
        }

        [When(@"User enter crendentials")]
        public void WhenUserEnterCrendentials(Table table)
        {
            // ScenarioContext.Current.Pending();
            var dictionary = TableExtensions.ToDictionary(table);
            var test = dictionary["Username"];

            driver.FindElement(By.XPath("//input[@id='UserName']")).SendKeys(dictionary["Username"]);
            driver.FindElement(By.XPath("//input[@id='Password']")).SendKeys(dictionary["Password"]);
        }
        
        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            // ScenarioContext.Current.Pending();
            //Click on Login button
            driver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();

            //Click on Popup Message
            driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
        }
        
        [Then(@"the user should navigate to PO Dashboard")]
        public void ThenTheUserShouldNavigateToPODashboard()
        {
            // ScenarioContext.Current.Pending();
            Thread.Sleep(1000);
            var PODb = driver.FindElement(By.XPath("//h3[@class='ui header']")).Text;

            //verify PO Dashboard Page
            Assert.That(PODb, Is.EqualTo("Property Owner Dashboard"));
            Console.WriteLine("User is navigated to Property Owner Dashboard");             
        }
    }
}
