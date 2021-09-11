using System;
using System.Collections.Generic;
using Order;

class ConsoleProgram{
static void Main()
{
            Console.WriteLine("Hello World");
            MenuItem NewOrder = new MenuItem();
            Pastry myPastry = new Pastry();
            Bread myBread = new Bread();
            List<MenuItem> result = MenuItem.GetAll();
            Console.WriteLine(result.Count);  
            foreach (var item in result)
    {  
        Console.WriteLine(item.ToString());
        // .Description
    }
    }
}