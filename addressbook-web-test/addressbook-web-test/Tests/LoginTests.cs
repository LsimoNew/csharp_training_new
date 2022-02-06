using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests :TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // prepare
            app.Auth.Logout();

            // action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            // verification
            Assert.IsTrue(app.Auth.IsLoggedIn(account));

            // after
            app.Auth.Logout();
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            // prepare
            app.Auth.Logout();

            // action
            AccountData account = new AccountData("admin", "1234");
            app.Auth.Login(account);

            // verification
            Assert.IsFalse(app.Auth.IsLoggedIn(account));

            // after
            app.Auth.Logout();
        }
    }
}
