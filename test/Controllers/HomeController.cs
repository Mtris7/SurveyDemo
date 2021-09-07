using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using test.EF;
using test.Entities;
using test.Models;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SurveyDbContext _context;

        public HomeController(ILogger<HomeController> logger, SurveyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost, ActionName("SubmitForm")]
        public IActionResult SubmitForm(Survey survey)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            survey.UserID = "123456";
            #region
            //if (!string.IsNullOrEmpty(Request.Form["comeLib"])) 
            //    survey.Come = Request.Form["comeLib"];

            //if (!string.IsNullOrEmpty(Request.Form["useLib"]))
            //    survey.UseLib = Request.Form["useLib"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["knowLib"]))
            //    survey.KnowLib = Request.Form["knowLib"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["purposeLib"]))
            //    survey.Purpose = Request.Form["purposeLib"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["reasonLib"]))
            //    survey.Reason = Request.Form["reasonLib"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["serviceLib"]))
            //    survey.TimeLibOpen = Request.Form["serviceLib"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["searchInLib"]))
            //    survey.Search = Request.Form["searchInLib"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["informationDatabase"]))
            //    survey.InformationDatabase = Request.Form["informationDatabase"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["searchDatabase"]))
            //    survey.SearchDatabase = Request.Form["searchDatabase"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["informationCategory"]))
            //    survey.InformationCategory = Request.Form["informationCategory"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["exactlyCategory"]))
            //    survey.ExactlyCategory = Request.Form["exactlyCategory"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["informationWebsite"]))
            //    survey.InformationWebsite = Request.Form["informationWebsite"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["exactlyWebsite"]))
            //    survey.ExactlyWebsite = Request.Form["exactlyWebsite"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["searchWebsite"]))
            //    survey.SearchWebsite = Request.Form["searchWebsite"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["ReadEffective"]))
            //    survey.ReadEffective = Request.Form["ReadEffective"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["BorrowEffective"]))
            //    survey.BorrowEffective = Request.Form["BorrowEffective"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["ReferEffective"]))
            //    survey.ReferEffective = Request.Form["ReferEffective"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["InternetEffective"]))
            //    survey.InternetEffective = Request.Form["InternetEffective"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["PhotoEffective"]))
            //    survey.PhotoEffective = Request.Form["PhotoEffective"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["DifferentEffective"]))
            //    survey.DifferentEffective = Request.Form["DifferentEffective"].ToString();

            //if (!string.IsNullOrEmpty(Request.Form["SpaceReview"]))
            //    survey.SpaceReview = Request.Form["SpaceReview"].ToString();
            #endregion

            _context.Survey.Add(survey);
            _context.SaveChanges();

            return Content("Khảo sát thành công, cảm ơn bạn đã tham gia.");
        }
    }
}
