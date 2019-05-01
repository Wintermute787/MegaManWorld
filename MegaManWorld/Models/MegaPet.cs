using System;
using System.Collections.Generic;

//House the Megaman Pet Object
namespace MegaManWorld
{

  public class MegaPet
  {
    private string Id {get;}
    public string Name {get; set;}
    public int Bits {get; set;}
    public int Training {get; set;}
    public int MaxHealth {get;}
    public int Health {get;}
    public int Happiness {get; set;}
    public int Trauma {get; set;}


    public MegaPet(string name)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Bits = 100;
      Training = 0;
      MaxHealth = 100;
      Health = 100;
      Happiness = 50;
      Trauma = 0;
    }


  }

}
