using Microsoft.AspNetCore.Mvc;
using MegaManWorld;
using System.Collections.Generic;
using System;

namespace MegaManWorld.Controllers
{
  public class WorldController : Controller
  {

    [Route("/worlds/{world}")]
    public ActionResult Index(string world)
    {
      foreach (MegaWorld item in MegaData.worlds)
      {
        if (item.Route == world)
        {
          return View(item);
        }
      }
      return View("/");
    }

    [HttpPost("/commandpet")]
    public ActionResult Command(string command)
    {
      MegaData.worlds[0].Pet.Bits += 100;
      return RedirectToAction("Index");
    }


    [HttpGet("/updatepet")]
    public string Update()
    {
      string data = "";
      MegaPet p = MegaData.worlds[0].Pet;

      data += "<li>" + p.Id + "</li>" +
              "<li>" + p.Name + "</li>" +
              "<li>" + p.Training + "</li>" +
              "<li>" + p.Energy + "</li>" +
              "<li>" + p.Bits + "</li>" +
              "<li>" + p.Happiness + "</li>";

      return data;
    }

  }
}
