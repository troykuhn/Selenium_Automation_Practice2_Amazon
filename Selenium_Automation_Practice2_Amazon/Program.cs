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

			//Web Elements
			IWebElement SignIn = driver.FindElement( By.Id( "nav-link-accountList" ) );
			IWebElement EmailField = driver.FindElement( By.Id( "ap_email" ) );
			IWebElement ContinueButton = driver.FindElement( By.Id( "continue" ) );

			//Operations
			SignIn.Click();
			EmailField.SendKeys( "foiseoisjfosn@fwfwf.com" );
			ContinueButton.Click();
			
		}

		[TearDown]
		public void CloseTest()
		{
			//Close the browser
			driver.Quit();
		}
	}
}
