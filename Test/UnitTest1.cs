using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using Moq;
using System;
using System.Data.Entity;

namespace Lab.Demo.EF.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Shipper_guardado_exitoso()
        {
            var mockSet = new Mock<DbSet<Shippers>>();
            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Shippers).Returns(mockSet.Object);

            ShippersLogic shippersLogic = new ShippersLogic(mockContext.Object);

            Assert.AreEqual(true,
                shippersLogic.insertShipper("TestCaseCompanyName", "0000-0000")
            );   
        }
        [TestMethod]
        public void Shipper_guardado_no_exitoso()
        {
            var mockSet = new Mock<DbSet<Employees>>();
            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(m => m.Employees).Returns(mockSet.Object);

            ShippersLogic shippersLogic = new ShippersLogic(mockContext.Object);
            // forzamos la falla al guardar
            Assert.AreEqual(false,
                shippersLogic.insertShipper("TestCaseCompanyName", "0000-0000")
            );


        }
    }
}
