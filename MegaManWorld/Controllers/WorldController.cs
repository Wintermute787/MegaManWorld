using Microsoft.AspNetCore.Mvc;
using MegaManWorld;
using System.Collections.Generic;
using System;

namespace MegaManWorld.Controllers
{
  public class WorldController : Controller
  {

    [HttpGet("/worlds/{world}")]
    public ActionResult Index(string world)
    {
      foreach (MegaWorld item in MegaData.worlds)
      {
        Console.WriteLine(world);
        Console.WriteLine(item.Route);
        if (item.Route == world)
        {
          return View(item);
        }
      }
      return View();
    }

  }
}
