using System;
using System.Collections.Generic;
using Order;
namespace Program{

    class ConsoleProgram{

    static void Main(){

        Console.WriteLine("list Length");
        MenuItem NewOrder = new MenuItem();
        Pastry myPastry = new Pastry();
        Bread myBread1 = new Bread();
        Bread myBread2 = new Bread();
        Bread myBread3 = new Bread();
        Bread myBread4 = new Bread();
        Bread myBread5 = new Bread();
        List<MenuItem> result = MenuItem.GetAll();
        Console.WriteLine(result.Count);  

            foreach (var item in result){
            Console.WriteLine(item.ToString());
            // .Description
            }
        }
    }
}