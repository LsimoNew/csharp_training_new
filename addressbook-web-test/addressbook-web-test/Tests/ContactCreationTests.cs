using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebAddressbookTests
{
    [TestFixture]
     public class ContactCreationTests : TestBase
    {
        [Test]
        public void CreateContact()
        {
            ContactData contact = new ContactData("Raz", "Dva", "Tri");
            contact.Nickname = "tik";
            contact.Company = "pik";
            contact.Home = "dok";

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
