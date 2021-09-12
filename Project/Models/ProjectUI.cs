using System;
using System.Collections.Generic;
using Order;
namespace Program{

    public class ConsoleProgram{

    public static int BreadCount(List<MenuItem> result){
    int BreadCnt = 0;
    foreach (var item in result){
        if(item is Bread){
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

    public static int PastryCount(List<MenuItem> result){
    int PastryCnt = 0;
    foreach (var item in result){
        if(item is Pastry){
            PastryCnt++;
        }
    }
    return PastryCnt;
    }


    public static double CalculatePastry(int PastryCnt){
        double Total = 0;
        if(PastryCnt > 2){
        double Divider = PastryCnt / 5;
        double Subtractor = Math.Ceiling((double)PastryCnt / 5);
        Total = (PastryCnt*2)-Subtractor;
        } else {
            Total = PastryCnt*2;
        }
        return Total;
    }

    static void Main(){

        Pastry myPastry1 = new Pastry();
        Pastry myPastry2 = new Pastry();
        Pastry myPastry3 = new Pastry();
        Pastry myPastry4 = new Pastry();
        Pastry myPastry5 = new Pastry();
        Pastry myPastry6 = new Pastry();
        Pastry myPastry7 = new Pastry();
        Pastry myPastry8 = new Pastry();
        Pastry myPastry9 = new Pastry();
        Pastry myPastry10 = new Pastry();
        Pastry myPastry11 = new Pastry();
        Bread myBread1 = new Bread();
        Bread myBread2 = new Bread();
        Bread myBread3 = new Bread();
        Bread myBread4 = new Bread();
        Bread myBread5 = new Bread();
        Bread myBread6 = new Bread();
        Bread myBread7 = new Bread();
        List<MenuItem> result = MenuItem.GetAll();
        Console.Clear();
        Console.WriteLine("Bread Count:");
        Console.WriteLine(BreadCount(result));
        Console.WriteLine("Bread Cost: $");
        Console.WriteLine(CalculateBread(BreadCount(result)));
        Console.WriteLine("---------------");
        Console.WriteLine("Pastry Count:");
        Console.WriteLine(PastryCount(result));
        Console.WriteLine("Pastry Cost: $");
        Console.WriteLine(CalculatePastry(PastryCount(result)));
        Console.WriteLine("---------------");
        Console.WriteLine("Total: $");
        Console.WriteLine(CalculatePastry(PastryCount(result)) + CalculateBread(BreadCount(result)));

        // Console.WriteLine("Bread Cost:");
        // Console.WriteLine(CalculateBread(BreadCount(result)));


            // foreach (var item in result){
            // Console.WriteLine(item.ToString());
            // // .Description
            // }
        }
    }
}