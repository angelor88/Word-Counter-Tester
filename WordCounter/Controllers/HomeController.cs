using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/howOften")]
    public ActionResult CounterResult()
    {
      int counterResult = WordFinder.GetCount(Request.Form["your-sentence"], Request.Form["your-keyWord"]);

        return View("PageResults", counterResult);
    }
  }
}
