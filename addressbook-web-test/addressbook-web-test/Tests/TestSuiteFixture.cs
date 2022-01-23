using NUnit.Framework;


namespace WebAddressbookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        [OneTimeSetUp]
        public void InitApplicationManager()
        {
            ApplicationManager app = ApplicationManager.GetInstance();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
