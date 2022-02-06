using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>
    {
        private string firstname;
        private string middlename = "";
        private string lastname;
        private string nickname = "";
        private string company = "";
        private string home = "";
        private string mobile = "";

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Firstname == other.Firstname && Lastname == other.Lastname;
        }


        public int GetHashCodeFirstname()
        {
            return Firstname.GetHashCode();
        }

        public int GetHashCodeLastname()
        {
            return Lastname.GetHashCode();
        }

        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        
        public string Middlename
        {
            get { return middlename; } 
            set { middlename = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Home
        {
            get { return home; }
            set { home = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = home; }
        }
    }
}
