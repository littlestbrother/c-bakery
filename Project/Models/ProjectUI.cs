using System;
using System.Collections.Generic;
using Order;
namespace Program{

    public class ConsoleProgram{

    public static int BreadCount(List<MenuItem> result){
    int BreadCnt = 0;
    foreach (var item in result){
        if(item is Bread){
            Console.WriteLine(item);
            BreadCnt++;
        }
    }
    return BreadCnt;
    }

    public static int CalculateBread(int BreadCnt){
        int DummyCnt = BreadCnt;
        int Total = 0;
        while(DummyCnt %3 != 0){
        DummyCnt -= 1;
        }

        if(DummyCnt %3 == 0){
            int Subtractor = DummyCnt / 3;
            Total = (DummyCnt - Subtractor)*5;
            Total += (BreadCnt - DummyCnt)*5;
        }
        return Total;
    }

    static void Main(){

        // MenuItem NewOrder = new MenuItem();
        // Pastry myPastry = new Pastry();
        Bread myBread1 = new Bread();
        // Bread myBread2 = new Bread();
        // Bread myBread3 = new Bread();
        // Bread myBread4 = new Bread();
        List<MenuItem> result = MenuItem.GetAll();
        Console.WriteLine("Bread Count:");
        Console.WriteLine(BreadCount(result));
        Console.WriteLine("Bread Cost:");
        Console.WriteLine(CalculateBread(BreadCount(result)));


            foreach (var item in result){
            Console.WriteLine(item.ToString());
            // .Description
            }
        }
    }
}