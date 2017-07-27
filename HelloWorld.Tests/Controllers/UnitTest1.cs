using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using HelloWorld.Domain.Models;
using System.Web.Script.Serialization;

namespace HelloWorld.Controllers.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void GetTest()
        {
            
            var controller = new MessageAPIController();

            //Act
            var result = controller.Get();
            var resultMessage = new JavaScriptSerializer().Deserialize<Message>(result);

            //Assert
            Assert.AreEqual("Hello World", resultMessage.Value);
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}