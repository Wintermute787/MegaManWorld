using System;
using System.Collections.Generic;

namespace MegaManWorld
{
  public class MegaWorld
  {
    public string Name {get; set;}
    public string Route {get; set;}
    public string WorldImg {get; set;}
    public string BackgroundImg {get; set;}

    public MegaPet Pet {get; set;}

    public MegaWorld(string name, string route, string img, string backgroundImg)
    {
      this.Name = name;
      this.Route = route;
      this.WorldImg = img;
      this.BackgroundImg = backgroundImg;
    }

  }

}
