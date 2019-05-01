using System;
using System.Collections.Generic;


namespace MegaManWorld
{

  public static class MegaData
  {
    public static List<MegaWorld> worlds;

    static MegaData()
    {
      worlds = new List<MegaWorld>();
      worlds.Add(new MegaWorld("Chill Penguin", "chillpenguin", "snowWorld.png", "backgroundForest.png"));
      worlds.Add(new MegaWorld("Sting Chameleon", "stingchameleon", "forestWorld.png", "backgroundForest.png"));
      worlds.Add(new MegaWorld("Launch Octopus", "launchoctopus", "waterWorld.png", "backgroundForest.png"));
    }
  }
}
