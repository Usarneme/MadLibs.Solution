using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]

    public ActionResult Form() { return View(); }

    [Route("/MadLib")]
    public ActionResult MadLib(string noun, string verb)
    {
      MadLibCreator myMadLibVariable = new MadLibCreator();
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Verb = verb;
      return View(myMadLibVariable);
    }

  }
}