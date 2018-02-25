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
      string sentenceResult = Request.Form[("your-sentence")];
      string keyWordResult = Request.Form[("your-keyWord")];
      WordFinder newWordFinder = new WordFinder(sentenceResult, keyWordResult);
      return View("PageResults", newWordFinder);
    }
  }
}
