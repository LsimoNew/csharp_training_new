using NUnit.Framework;
using System;

namespace WebAddressbookTests
{
    public class TestBase
    {

        protected ApplicationManager app;

        [SetUp]
        public void SetupApplicationManager()
        {
            app = ApplicationManager.GetInstance();
        }

        [OneTimeTearDown]


        public void StopApplicationManager()
        {
            ApplicationManager.GetInstance().Stop();
        }
    }
}
