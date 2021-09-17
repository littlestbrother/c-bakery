using System;
using System.Linq;



namespace MenuBread{
public class Bread{
    
    public int Amount {get; set; }

    public int Calculate(){
        int DummyCnt = this.Amount;
        int Total = 0;
        while(DummyCnt %3 != 0){
        DummyCnt -= 1;
        }

        if(DummyCnt %3 == 0){
            int Subtractor = DummyCnt / 3;
            Total = (DummyCnt - Subtractor)*5;
            Total += (this.Amount - DummyCnt)*5;
        }
        return Total;
    }

    }
}