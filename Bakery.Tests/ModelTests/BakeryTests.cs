using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MenuPastry;
using MenuBread;

namespace Bakery.Tests
{
    [TestClass]
    public class PropertyAmount
    {

        [TestMethod]
        public void Bread_breadAmount_True()
        {
        Bread bread = new Bread(5);
        Assert.AreEqual(1,bread.Amount);
        }       

        [TestMethod]
        public void Pastry_pastryAmount_True()
        {
        Pastry pastry = new Pastry(7);

        Assert.AreEqual(1,pastry.Amount);
        }       
    }
}

//         [TestClass]
//     public class CalculateItems
//     {

//         [TestMethod]
//         public void Bread_BreadCalculate_True()
//         {
//         Bread newBread2 = new Bread();
//         Bread newBread3 = new Bread();
//         List<MenuItem> result = MenuItem.GetAll();
//         Assert.AreEqual(10,ConsoleProgram.CalculateBread(ConsoleProgram.BreadCount(result)));
//         Bread newBread4 = new Bread();
//         Assert.AreEqual(15,ConsoleProgram.CalculateBread(ConsoleProgram.BreadCount(result)));
//         }

//         [TestMethod]
//         public void Pastry_PastryCalculate_True()
//         {
//         Pastry newPastry2 = new Pastry();
//         Pastry newPastry3 = new Pastry();
//         List<MenuItem> result = MenuItem.GetAll();
//         Assert.AreEqual(5,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
//         Pastry newPastry4 = new Pastry();
//         Assert.AreEqual(7,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
//         Pastry newPastry5 = new Pastry();
//         Assert.AreEqual(9,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
//         Pastry newPastry6 = new Pastry();
//         Assert.AreEqual(10,ConsoleProgram.CalculatePastry(ConsoleProgram.PastryCount(result)));
//         }       
//     }
// }