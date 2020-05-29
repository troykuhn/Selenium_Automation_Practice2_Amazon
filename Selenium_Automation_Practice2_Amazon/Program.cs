using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Automation_Practice2_Amazon
{
	class Program
	{
		// Create a reference for Chrome browser
		IWebDriver driver = new ChromeDriver();

		

		static void Main( string[] args )
		{


		}

		[SetUp]
		public void Initialize()
		{
			// Go to Amazon Webpage
			driver.Navigate().GoToUrl( "https://www.amazon.com" );
		}


		[Test]
		public void ExecuteTheTest()
		{
			//Full screen browser
			driver.Manage().Window.Maximize();

			//Web Elements and Operations
			IWebElement SignIn = driver.FindElement( By.Id( "nav-link-accountList" ) );
			SignIn.Click();

			IWebElement EmailField = driver.FindElement( By.Id( "ap_email" ) );
			EmailField.SendKeys( "foiseoisjfosn@fwfwf.com" );

			IWebElement ContinueButton = driver.FindElement( By.Id( "continue" ) );
			ContinueButton.Click();

			IWebElement ErrorMessage = driver.FindElement( By.ClassName( "a-alert-heading" ) );
			string ActualErrorMessageText = ErrorMessage.Text;
			string ExpectedErrorMessageText = "There was a problem";

			Assert.AreEqual( ActualErrorMessageText, ExpectedErrorMessageText );

			
		}

		[TearDown]
		public void CloseTest()
		{
			//Close the browser
			driver.Quit();
		}
	}
}
