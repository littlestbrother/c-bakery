using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Order;
using Program;

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

    [TestClass]
    public class CountItems
    {

        [TestMethod]
        public void Bread_BreadCount_True()
        {
        List<MenuItem> result = MenuItem.GetAll();
        //we expect two because a bread object was created earlier in our code on line 22.
        Assert.AreEqual(1,ConsoleProgram.BreadCount(result));
        }       

        [TestMethod]
        public void Pastry_PastryCount_True()
        {
        List<MenuItem> result = MenuItem.GetAll();
        //we expect two because a bread object was created earlier in our code on line 22.
        Assert.AreEqual(2,ConsoleProgram.PastryCount(result));
        }       
    }
}