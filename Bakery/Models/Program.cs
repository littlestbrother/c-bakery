using System;
using System.Collections;
using ItemsOnMenu;
using MenuPastry;
using MenuBread;
using System.Linq;


namespace Program{

    public class ConsoleProgram{
    static void Main(){
        Console.Clear();
        Console.WriteLine("How many loafs of Bread would you like?");
        string BreadResponse = Console.ReadLine();
        int NumBread = int.Parse(BreadResponse);
        Bread bread = new Bread();
        //
        Console.Clear();
        Console.WriteLine("How many Pastries would you like?");
        string PastryResponse = Console.ReadLine();
        int NumPastry = int.Parse(PastryResponse);
        Pastry pastries = new Pastry();
        //
        Console.Clear();
        Console.WriteLine("Bread Count:");
        bread.Amount = NumBread;
        Console.WriteLine(bread.Amount);
        Console.WriteLine("Pastry Count:");
        pastries.Amount = NumPastry;
        Console.WriteLine(pastries.Amount);
        // Console.Clear();
        // List<MenuItem> result = MenuItem.GetAll();
        // Console.WriteLine("Here is your total:");
        // Console.WriteLine("Bread Count:");
        // Console.WriteLine(BreadCount(result));
        // Console.WriteLine("Bread Cost: $");
        // Console.WriteLine(CalculateBread(BreadCount(result)));
        // Console.WriteLine("---------------");
        // Console.WriteLine("Pastry Count:");
        // Console.WriteLine(PastryCount(result));
        // Console.WriteLine("Pastry Cost: $");
        // Console.WriteLine(CalculatePastry(PastryCount(result)));
        // Console.WriteLine("---------------");
        // Console.WriteLine("Total: $");
        // Console.WriteLine(CalculatePastry(PastryCount(result)) + CalculateBread(BreadCount(result)));
        }
    }
}