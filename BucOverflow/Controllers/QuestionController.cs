using Microsoft.AspNetCore.Mvc;
using BucOverflow.Models;
using System.Diagnostics;
using System.Globalization;

namespace BucOverflow.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Returns a question
        public IActionResult ViewQuestion(int questionID)
        {
            using (var db = new DataContext())
            {
                //pulls the current question from the db
                QuestionModel question = db.Questions.Find(questionID);

                //creates a list of answers for the given question
                List<AnswerModel> answers = new List<AnswerModel>();
                foreach (var a in db.Answers)
                {
                    if (a.QuestionID == question.QuestionID)
                    {
                        AnswerModel ans = a;
                        answers.Add(a);
                    }
                }

                ViewBag.answers = answers;

                return View("Question", question);
            }//end using (var db = new DataContext())
        }//public IActionResult ViewQuestion(int questionID)

        //returns the form for submitting a new question
        public IActionResult NewQuestion()
        {
            return View();
        }

        //handles the logic of posting a new question before returning user to the question list
        public IActionResult PostQuestion(QuestionModel question)
        {
            using (var db = new DataContext())
            {
                question.DateAsked = DateTime.Now.ToString("g", CultureInfo.GetCultureInfo("en-US"));
                db.Questions.Add(question);
                db.SaveChanges();
            }
            return RedirectToAction("QuestionList", "Forum");
        }
    }
}
