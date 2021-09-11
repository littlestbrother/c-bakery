using System;
using System.Collections.Generic;
using Order;

class ConsoleProgram{
static void Main()
{
            Console.WriteLine("Hello World");
            Bread NewOrder = new Bread();
            Bread NewOrder1 = new Bread();
            Bread NewOrder2 = new Bread();
            List<Bread> result = Bread.GetAll();
            Console.WriteLine(result.Count);  
            foreach (var item in result)
    {  
        Console.WriteLine(item);
        // .Description
    }
    }
}