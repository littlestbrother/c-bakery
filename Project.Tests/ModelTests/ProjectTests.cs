using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Order;

namespace Order.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void MenuOrder_NewOrder_True()
        {
            MenuItem newOrder = new MenuItem();
            Assert.AreEqual(typeof(MenuItem), newOrder.GetType());
        }

        [TestMethod]
        public void Bread_NewOrder_True()
        {
            Bread newOrder = new Bread();
            Assert.AreEqual(typeof(Bread), newOrder.GetType());
        }

        [TestMethod]
        public void Pastry_NewOrder_True()
        {
            Pastry newOrder = new Pastry();
            Assert.AreEqual(typeof(Pastry), newOrder.GetType());
        }
    }
}