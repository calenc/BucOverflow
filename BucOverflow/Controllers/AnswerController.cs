using BucOverflow.Models;
using Microsoft.AspNetCore.Mvc;

namespace BucOverflow.Controllers
{
    public class AnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //saves a users answer to a question
        [HttpPost]
        public IActionResult AddAnswer(string answerText, int questionID)
        {
            using (var db = new DataContext())
            {
                //gets the last answer entry in the db
                var lastEntry = db.Answers
                      .OrderByDescending(x => x.AnswerID)
                      .FirstOrDefault();

                //news up answer model and assigns values
                AnswerModel answer = new AnswerModel();
                answer.AnswerText = answerText;
                answer.QuestionID = questionID;
                answer.AnswerID = lastEntry.AnswerID + 1;

                //saves new entry to db
                db.Add(answer);
                db.SaveChanges();

                //returns the user to the question page they were on
                return RedirectToAction("ViewQuestion", "Question", new { questionID = questionID });
            }//end using (var db = new DataContext())
        }//end public IActionResult Answer(string AnswerText, int QuestionID)
    }
}
