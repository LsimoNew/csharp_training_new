using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Newest1");
            newData.Header = "Newest2";
            newData.Footer = "Newest3";

            app.Groups.Modify(1, newData);
        }
    }
}
