using System;
using System.Collections.Generic;

//House the Megaman Pet Object
namespace MegaManWorld
{

  public class MegaPet
  {
    public string Id {get;}
    public string Name {get; set;}
    public int Bits {get; set;}
    public int Training {get; set;}
    public int Power {get; set;}
    public int EnergyCapacity {get; set;}
    public int Energy {get; set;}
    public int Happiness {get; set;}
    public int Trauma {get; set;}


    public MegaPet(string name)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
      Bits = 100;
      Training = 0;
      EnergyCapacity = 100;
      Energy = 100;
      Happiness = 50;
      Trauma = 0;
    }


    public void Update()
    {
      if (Bits > 0 )
        Bits -= 1;
      else
      {
        if (Happiness > 0)
          Happiness--;
        if (Energy > 0)
          Energy--;
        else
        {
          if (EnergyCapacity > 10)
          {
            EnergyCapacity -= 10;
            Energy = EnergyCapacity;
          }
          else
          {
            EnergyCapacity = 0;
          }
        }
      }
    }
  }
}
