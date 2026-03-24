using ISIP323_Khachatryan_WPF.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AuthTests
{
    [TestClass]
    public class RegTestSuccess
    {
        [TestMethod]
        public void RegisterTestSuccess()
        {
            var page = new RegisterPage();

            bool result = page.Register(
                "Иван",
                "Иванов",
                "new_user_123",
                "12345",
                "12345"
            );

            Assert.IsTrue(result);
        }
    }
}
