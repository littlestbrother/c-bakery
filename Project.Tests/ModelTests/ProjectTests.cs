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
        Assert.AreEqual(1,ConsoleProgram.BreadCount(result));
        }       

        [TestMethod]
        public void Pastry_PastryCount_True()
        {
        List<MenuItem> result = MenuItem.GetAll();
        Assert.AreEqual(1,ConsoleProgram.PastryCount(result));
        }       
    }

        [TestClass]
    public class CalculateItems
    {

        [TestMethod]
        public void Bread_BreadCalculate_True()
        {
        Bread newBread2 = new Bread();
        Bread newBread3 = new Bread();
        List<MenuItem> result = MenuItem.GetAll();
        Assert.AreEqual(10,ConsoleProgram.CalculateBread(ConsoleProgram.BreadCount(result)));
        Bread newBread4 = new Bread();
        Assert.AreEqual(15,ConsoleProgram.CalculateBread(ConsoleProgram.BreadCount(result)));
        }

        [TestMethod]
        public void Pastry_PastryCalculate_True()
        {
        Pastry newPastry2 = new Pastry();
        Pastry newPastry3 = new Pastry();
        List<MenuItem> result = MenuItem.GetAll();
        Assert.AreEqual(5,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
        Pastry newPastry4 = new Pastry();
        Assert.AreEqual(7,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
        Pastry newPastry5 = new Pastry();
        Assert.AreEqual(9,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
        Pastry newPastry6 = new Pastry();
        Assert.AreEqual(10,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
        }       
    }
}