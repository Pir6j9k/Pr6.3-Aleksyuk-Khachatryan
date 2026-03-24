using ISIP323_Khachatryan_WPF.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AuthTests
{
    [TestClass]
    public class AuthTestFail
    {
        [TestMethod]
        public void AuthTest_Fail()
        {
            var page = new LoginPage { IsTest = true };

            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" ", " "));

            Assert.IsFalse(page.Auth("user1", "wrong"));

            Assert.IsFalse(page.Auth("not_exist", "123"));

            Assert.IsFalse(page.Auth("user1", ""));

            Assert.IsFalse(page.Auth("", "123"));
        }
    }
}
