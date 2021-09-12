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

    public static void AddBread(int NumBread){
        int i = 0;
        while(i < NumBread){
        Bread newBread = new Bread();
        i++;
        }
    }

        public static void AddPastry(int NumPastry){
        int i = 0;
        while(i < NumPastry){
        Pastry newPastry = new Pastry();
        i++;
        }
    }

    static void Main(){
        Console.Clear();
        Console.WriteLine("How many loafs of Bread would you like?");
        string BreadResponse = Console.ReadLine();
        int NumBread = int.Parse(BreadResponse);
        AddBread(NumBread);
        //
        Console.Clear();
        Console.WriteLine("How many Pastries would you like?");
        string PastryResponse = Console.ReadLine();
        int NumPastry = int.Parse(PastryResponse);
        AddPastry(NumPastry);
        //
        Console.Clear();
        List<MenuItem> result = MenuItem.GetAll();
        Console.WriteLine("Here is your total:");
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
        }
    }
}