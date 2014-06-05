using System;
using System.Web.Mvc;

namespace DaVinci.Condor.Web.Controllers
{
    public class ScoreSheetController : Controller
    {
        public ActionResult Details(int id)
        {
            var scoreSheet = new ScoreSheet();
            scoreSheet.Criteria.Add(new Criterion()
            {
                Id = 1,
                Description = "Heeft het goed gedaan.",
                Mark = Mark.Adequate
            });
            scoreSheet.Criteria.Add(new Criterion()
            {
                Id = 2,
                Description = "Heeft het beter dan goed gedaan.",
                Mark = Mark.Good
            });
            scoreSheet.Criteria.Add(new Criterion()
            {
                Id = 3,
                Description = "Heeft het niet goed gedaan.",
                Mark = Mark.Inadequate
            });

            return View(scoreSheet);
        }
    }
}