using System;
using System.Collections.Generic;

namespace Order{


 public class MenuItem{

    private static List<MenuItem> _instances = new List<MenuItem> {};

    public static List<MenuItem> GetAll(){
      return _instances;
    }

    public MenuItem(){
        _instances.Add(this);
    }

}

public class Bread : MenuItem{
    public int BreadCnt = 0;
    public static void GetBreadCount(){

    }
}

public class Pastry : MenuItem{}
}