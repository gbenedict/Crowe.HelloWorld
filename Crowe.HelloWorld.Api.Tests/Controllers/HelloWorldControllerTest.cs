using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Crowe.HelloWorld.Api;
using Crowe.HelloWorld.Api.Controllers;
using Crowe.HelloWorld.Data;
using System.Web.Http.Results;

namespace Crowe.HelloWorld.Api.Tests.Controllers
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();
            // Act
            JsonResult<List<Data.Models.HelloWorld>> result = controller.Index() as JsonResult<List<Data.Models.HelloWorld>>;
                
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Content.Count());
            Assert.AreEqual("Hello World", result.Content.ElementAt(0).Description);            
        }
    }
}
