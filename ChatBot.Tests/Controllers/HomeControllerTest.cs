﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBot;
using ChatBot.Controllers;

namespace ChatBot.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Initialize
            HomeController controller = new HomeController();

            // act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
