using ISIP323_Khachatryan_WPF.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AuthTests
{
    [TestClass]
    public class RegTestFail
    {
        [TestMethod]
        public void RegisterTestFail()
        {
            var page = new RegisterPage();

            Assert.IsFalse(page.Register("", "", "", "", ""));

            Assert.IsFalse(page.Register("Иван", "Иванов", "userX", "123", "321"));

            Assert.IsFalse(page.Register("Иван", "Иванов", "user1", "123", "123"));
        }
    }
}
