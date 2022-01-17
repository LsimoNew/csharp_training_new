using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Tri", "Dva", "Raz");
            newData.Nickname = "a";
            newData.Company = "b";
            newData.Home = "c";

            app.Contacts.Modify(2, newData);
        }
    }
}
