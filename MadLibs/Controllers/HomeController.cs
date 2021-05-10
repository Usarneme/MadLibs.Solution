using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]

    public ActionResult Form() { return View(); }

    [Route("/MadLib")]
    public ActionResult MadLib(string adjective1, string adjective2, string adjective3, string adjective4, string adverb, string articleOfClothing, string job1, string job2, string noun1, string noun2, string pluralAnimal)
    {
      MadLibCreator myMadLibVariable = new MadLibCreator();
      myMadLibVariable.Adjective1 = adjective1;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Adjective3 = adjective3;
      myMadLibVariable.Adjective4 = adjective4;
      myMadLibVariable.Adverb = adverb;
      myMadLibVariable.ArticleOfClothing = articleOfClothing;
      myMadLibVariable.Job1 = job1;
      myMadLibVariable.Job2 = job2;
      myMadLibVariable.Noun1 = noun1;
      myMadLibVariable.Noun2 = noun2;
      myMadLibVariable.PluralAnimal = pluralAnimal;
      return View(myMadLibVariable);
    }

  }
}
