using System;
using System.Timers;
using System.Collections.Generic;

namespace MegaManWorld
{
  public class ServerUpdate
  {
    private static System.Timers.Timer updateTimer;



    public ServerUpdate()
    {
      // Create a timer with a two second interval.
      updateTimer = new System.Timers.Timer(500);
      // Hook up the Elapsed event for the timer.
      updateTimer.Elapsed += OnSystemUpdate;
      updateTimer.AutoReset = true;
      updateTimer.Enabled = true;
    }

    private void OnSystemUpdate(Object source, ElapsedEventArgs e)
    {
      foreach (MegaWorld world in MegaData.worlds)
      {
        if (world.Pet != null)
        {
          world.Pet.Update();
        }
      }
      Console.WriteLine("Server Update");
    }
  }
}
