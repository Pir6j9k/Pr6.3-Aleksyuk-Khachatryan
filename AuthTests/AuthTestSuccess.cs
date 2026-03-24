using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ISIP323_Khachatryan_WPF.Pages;

namespace AuthTests
{
    [TestClass]
    public class AuthTestSuccess
    {
        [TestMethod]
        public void AuthTest_Success()
        {
            var page = new LoginPage();

            Assert.IsTrue(page.Auth("user1", "123"));
            Assert.IsTrue(page.Auth("user2", "456"));
            Assert.IsTrue(page.Auth("user3", "789"));
            Assert.IsTrue(page.Auth("impala67", "impala67"));
            Assert.IsTrue(page.Auth("123", "321"));
            Assert.IsTrue(page.Auth("1111", "1111"));
        }
    }
}
