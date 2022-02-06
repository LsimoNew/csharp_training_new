using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;


namespace WebAddressbookTests
{
    [TestFixture]
     public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Imia", "Familia");
            contact.Middlename = "rok";
            contact.Nickname = "tik";
            contact.Company = "pik";
            contact.Home = "dok";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("", "");
            contact.Middlename = "";
            contact.Nickname = "";
            contact.Company = "";
            contact.Home = "";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }
        [Test]
        public void BadNameContactCreationTest()
        {
            ContactData contact = new ContactData("Imia", "Famili'a");
            contact.Middlename = "";
            contact.Nickname = "";
            contact.Company = "";
            contact.Home = "";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }
    }
}
