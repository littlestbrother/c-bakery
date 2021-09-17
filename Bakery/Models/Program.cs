using System;
using System.Collections;
using MenuPastry;
using MenuBread;
using System.Linq;

namespace Program {

	public class ConsoleProgram {
		static void Main() {
			//
			Console.Clear();
			Console.WriteLine("How many loafs of Bread would you like?");
			string BreadResponse = Console.ReadLine();
			int NumBread = int.Parse(BreadResponse);
			Bread bread = new Bread(NumBread);
			//
			Console.Clear();
			Console.WriteLine("How many Pastries would you like?");
			string PastryResponse = Console.ReadLine();
			int NumPastry = int.Parse(PastryResponse);
			Pastry pastries = new Pastry(NumPastry);
			//
			Console.Clear();
			Console.WriteLine("Here is your total:");
			Console.WriteLine("Bread Count:");
			Console.WriteLine(bread.Amount);
			Console.WriteLine("Bread Cost: $");
			Console.WriteLine(bread.Calculate());
			Console.WriteLine("---------------");
			Console.WriteLine("Pastry Count:");
			Console.WriteLine(pastries.Amount);
			Console.WriteLine("Pastry Cost: $");
			Console.WriteLine(pastries.Calculate());
			Console.WriteLine("---------------");
			Console.WriteLine("Total: $");
			Console.WriteLine(bread.Calculate() + pastries.Calculate());
		}
	}
}