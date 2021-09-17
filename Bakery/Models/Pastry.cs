using System;
using System.Linq;


namespace MenuPastry{
public class Pastry{

    public int Amount {get; set; }

    public double Calculate(){
        double Total = 0;
        if(this.Amount > 2){
        double Divider = this.Amount / 5;
        double Subtractor = Math.Ceiling((double)this.Amount / 5);
        Total = (this.Amount*2)-Subtractor;
        } else {
            Total = this.Amount*2;
        }
        return Total;
    }

}
}