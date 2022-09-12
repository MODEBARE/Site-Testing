using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Net;
using System.Threading;
using System.Net.Mail;
using System.Net.Mime;
using OpenQA.Selenium.Interactions;
using System.ComponentModel;

                                        //1


//STLC PHASES
//  1. Requirement Analysis
//  2. Test Planning
//  3. Test Case Development
//  4. Test Environment Setup
//  5. Test Execution
//  6. Test Cycle Closure

//2

//A

/*What is Testing?
Testing in casual term is defined as a finding out how well something works/measure of a quality. In Software technology, testing is the act of examining the behavior of a
software under test by validation and verification in order to find bugs.

                                //B

                    Manual and Automation Testing 
Manual testing refers to the method of testing in which human performs the test step by step without writing the scripts.
This human is the QA analyst. 

                                while

Automation testing, tests are automated automatically via test automation frameworks, along
with other tools and software.*/

//C

/* Tester's Documents includes the following
 Functional Requirement Specification
 Business Requirement Document
 Requirement for Proposal
 Software Requirement Document
 Requirement Traceability Matrix
 Functional Requirement Document
*/

            //3

//Qualities Of a QA
/* 1. Creative Mind
 * 2. Confidence
 * 3. Resalience
 * 4. Diplomacy
 */


namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver Ayo = new ChromeDriver();
            Ayo.Navigate().GoToUrl("http://automationpractice.com");
            IWebElement Signin = Ayo.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
            Ayo.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Signin.SendKeys(Keys.Enter);
            IWebElement usernameInput = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[2]/input"));
            usernameInput.SendKeys("Ayo11@gmail.com");
            IWebElement Registerrkey = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button/span"));
            Registerrkey.Click();
            IWebElement title = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[1]/div[1]/label/div/span/input"));
            title.Click();
            IWebElement FirstName = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[2]/input"));
            FirstName.SendKeys("Ayomide");
            IWebElement LastName = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[3]/input"));
            LastName.SendKeys("Ariyibi");
            IWebElement Password = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[5]/input"));
            Password.SendKeys("Ayomi@123");
            IWebElement day = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[1]/div/select"));
            day.SendKeys("10");
            IWebElement month = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[2]/div/select"));
            month.SendKeys("May");
            IWebElement year = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[3]/div/select"));
            year.SendKeys("1998");
            IWebElement newsletter = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[7]/div/span/input"));
            newsletter.Click();
            IWebElement Received = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[8]/div/span/input"));
            Received.Click();
            IWebElement Company = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[3]/input"));
            Company.SendKeys("Fintrak Software Company");
            IWebElement Address = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[4]/input"));
            Address.SendKeys("294, Gbagada, Lagos,Fintrak Software Company");
            IWebElement AddressLn = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[5]/input"));
            AddressLn.SendKeys("Plot294, suite 3");
            IWebElement City = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[6]/input"));
            City.SendKeys("Lagos");
            IWebElement State = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select"));
            State.SendKeys("Florida");
            IWebElement PostalCode = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[8]/input"));
            PostalCode.SendKeys("10012");
            IWebElement Country = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[9]/div/select"));
            Country.SendKeys("United States");
            IWebElement AddInfo = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[10]/textarea"));
            AddInfo.SendKeys("Thanks");
            IWebElement HomePhone = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[12]/input"));
            HomePhone.SendKeys("+10987657");
            IWebElement MobilePhone = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[13]/input"));
            MobilePhone.SendKeys("+2349030316718");
            IWebElement Address3 = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[14]/input"));
            Address3.SendKeys("Oshodi Area");
            IWebElement Register = Ayo.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[4]/button/span"));
            Register.Click();







            Assert.Pass();
        }
    }
}