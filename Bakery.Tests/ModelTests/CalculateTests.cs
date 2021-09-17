using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MenuPastry;
using MenuBread;

namespace Bakery.Tests { 
    [TestClass]
	public class CalculateTests {

		[TestMethod]
		public void Bread_BreadCalculate_True() {
			Bread bread = new Bread(1);
			Assert.AreEqual(5, bread.Calculate());
			bread.Amount = 2;
			Assert.AreEqual(10, bread.Calculate());
			bread.Amount = 3;
			Assert.AreEqual(10, bread.Calculate());
		}

		[TestMethod]
		public void Pastry_PastryCalculate_True() {
			Pastry pastries = new Pastry(1);
			Assert.AreEqual(2, pastries.Calculate());
			pastries.Amount = 3;
			Assert.AreEqual(5, pastries.Calculate());
			pastries.Amount = 4;
			Assert.AreEqual(7, pastries.Calculate());
			pastries.Amount = 5;
			Assert.AreEqual(9, pastries.Calculate());
			pastries.Amount = 6;
			Assert.AreEqual(10, pastries.Calculate());
		}
	}
}