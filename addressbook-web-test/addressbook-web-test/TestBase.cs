﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost/addressbook";
            verificationErrors = new StringBuilder();

            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        
    }
}