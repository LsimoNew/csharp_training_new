using System;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactHelper Create(ContactData contact)
        {
            InitNewContact();
            FillContactForm(contact);
            SaveNewContact();
            ReturnToContactsPage();
            return this;
        }

        public ContactHelper Modify(int x, ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            EditContact(x);
            FillContactForm(newData);
            SubmitContactModification();
            ReturnToContactsPage();
            return this;
        }

        public ContactHelper Remove(int x)
        {
            manager.Navigator.GoToHomePage();
            SelectContact(x);
            RemoveContact();
            AcceptAlert();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);            
            return this;
        }

        public ContactHelper InitNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public void ReturnToContactsPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        public ContactHelper SaveNewContact()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }

        public ContactHelper EditContact(int index)
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[" + index + "]/td[8]/a")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[" + index + "]/td/input[@type='checkbox']")).Click();
            return this;
        }
        private void RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
        }

        private void SubmitContactModification()
        {
            driver.FindElement(By.XPath("//input[@value='Update']")).Click();
        }

        private void AcceptAlert()
        {
            driver.SwitchTo().Alert().Accept();
        }
    }
}
