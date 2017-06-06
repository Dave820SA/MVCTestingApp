using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;

namespace OdeToFood.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Puts_Message_In_ViewBag()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result.ViewBag.Message);
        }
    }
}
