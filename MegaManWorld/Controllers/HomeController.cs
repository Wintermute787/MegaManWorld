using Microsoft.AspNetCore.Mvc;
using MegaManWorld;
using System.Collections.Generic;
using System;

namespace MegaManWorld.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {

      return View();
    }

  }
}
