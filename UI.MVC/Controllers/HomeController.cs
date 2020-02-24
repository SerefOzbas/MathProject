using Bll.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IQuestionService _questionService;
        ICategoryService _categoryService;
        public HomeController(IQuestionService questionService,ICategoryService categoryService)
        {
            _questionService = questionService;
            _categoryService = categoryService;
        }
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetAllQuestion()
        {
            var questions = _questionService.GetAll();
            return View(questions);
        }
        [HttpGet]
        public ActionResult AskQuestion()
        {
            var getcategorylist = _categoryService.GetAll();
            SelectList list = new SelectList(getcategorylist, "ID", "CategoryName");
            ViewBag.categorylist = list;
            return View();
        }
        [HttpPost]
        public ActionResult AskQuestion(Question question)
        {           
            try
            {
                question.UserId =(int) Session["UserID"];
                _questionService.Insert(question);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Veritabanına ekleme hatası";
                return View();
            }
            return RedirectToAction("GetAllQuestion", "Home");
        }

        public ActionResult QuestionDetails(int questionid)
        {
            return View(_questionService.Get(questionid));        
        }
    }
}