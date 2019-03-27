using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Models;
using HelloWorld.API.Controllers;
using System.Web.Http.Results;
using System.Net;

namespace HelloWorldAPI.Tests
{
    [TestClass]
    public class TestHelloWorldController
    {

        [TestMethod]
        public void GetHelloWorld_ShouldReturnMsg()
        {
            var controller = new HelloWorldController();
            var result = controller.GetHelloWorld();

            Assert.IsNotNull(result);
            //Assert.AreEqual("Hello World", result, false);
        }


    }
}
