﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Newest1");
            newData.Header = null;
            newData.Footer = null;

            app.Groups.Modify(0, newData);
        }
    }
}
