using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using MenuPastry;
using MenuBread;

namespace Bakery.Tests { 
    [TestClass]
	public class PropertyAmountTests {

		[TestMethod]
		public void Bread_breadAmount_True() {
			Bread bread = new Bread(5);
			Assert.AreEqual(5, bread.Amount);
		}

		[TestMethod]
		public void Pastry_pastryAmount_True() {
			Pastry pastry = new Pastry(7);

			Assert.AreEqual(7, pastry.Amount);
		}
	}
}