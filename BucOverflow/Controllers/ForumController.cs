using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BucOverflow.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BucOverflow.Controllers
{
    public class ForumController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //returns a list of the currently posted questions
        public IActionResult QuestionList()
        {
            //creates a list of questions
            List<QuestionModel> questionList = new List<QuestionModel>();
            using (var db = new DataContext())
            {
                questionList = db.Questions.ToList();
            }//end using (var db = new DataContext())

            ViewBag.questions = questionList;

            return View();
        }//end public IActionResult QuestionList()

        // Search function to find questions. Can search by title, category tag, and date asked. Function loads list and passes to view.
        public IActionResult Search(string searchString)
        {
            List<QuestionModel> questionList = new List<QuestionModel>();

            using (var db = new DataContext())
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    questionList = db.Questions
                                   .Where(q => q.Title.ToLower().Contains(searchString.ToLower()) || q.Tag.ToLower().Contains(searchString.ToLower())
                                   || q.DateAsked.Contains(searchString)).ToList();
                }
                else
                {
                    questionList = db.Questions.ToList();
                }
                ViewBag.questions = questionList;
                return View("QuestionList", questionList);
            }
        }
    }
}

