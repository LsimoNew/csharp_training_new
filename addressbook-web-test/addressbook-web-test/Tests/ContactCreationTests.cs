using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebAddressbookTests
{
    [TestFixture]
     class ContactCreationTests : TestBase
    {
        [Test]
        public void CreateContact()
        {
            ContactData contact = new ContactData("Tri", "Dva", "Raz");
            contact.Nickname = "ti";
            contact.Company = "pi";
            contact.Home = "dor";

            app.Contacts.Create(contact);
        }

        [Test]
        public void EmptyCreateContact()
        {
            ContactData contact = new ContactData("", "", "");
            contact.Nickname = "";
            contact.Company = "";
            contact.Home = "";

            app.Contacts.Create(contact);
        }
    }
}
