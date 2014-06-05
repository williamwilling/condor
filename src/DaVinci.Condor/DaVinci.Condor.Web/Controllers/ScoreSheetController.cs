using System;
using System.Web.Mvc;

namespace DaVinci.Condor.Web.Controllers
{
    public class ScoreSheetController : Controller
    {
        public ActionResult Details(int id)
        {
            var scoreSheetTemplate = new ScoreSheetTemplate();
            scoreSheetTemplate.Criteria.Add(new Criterion()
            {
                Id = 1,
                Description = "Heeft het goed gedaan.",
                Mark = Mark.Adequate
            });
            scoreSheetTemplate.Criteria.Add(new Criterion()
            {
                Id = 2,
                Description = "Heeft het beter dan goed gedaan.",
                Mark = Mark.Good
            });
            scoreSheetTemplate.Criteria.Add(new Criterion()
            {
                Id = 3,
                Description = "Heeft het niet goed gedaan.",
                Mark = Mark.Inadequate
            });

            var scoreSheet = new ScoreSheet(scoreSheetTemplate);

            return View(scoreSheet);
        }
    }
}