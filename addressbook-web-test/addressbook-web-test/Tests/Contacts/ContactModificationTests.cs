using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Tri", "Raz");
            newData.Middlename = null;
            newData.Nickname = null;
            newData.Company = null;
            newData.Home = null;

            app.Contacts.Modify(0, newData);
        }
    }
}
