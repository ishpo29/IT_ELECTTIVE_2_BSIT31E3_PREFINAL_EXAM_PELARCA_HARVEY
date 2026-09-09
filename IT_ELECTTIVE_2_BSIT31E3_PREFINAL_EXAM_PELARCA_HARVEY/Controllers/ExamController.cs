using Microsoft.AspNetCore.Mvc;
using IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY.Models;

namespace IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY.Models
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View(QuestionBank.All.OrderBy(q => q.Number).ToList());
        }

        public IActionResult Record(int id)
        {
            var record = QuestionBank.All.FirstOrDefault(q => q.Number == id);
            if (record == null)
            {
                Response.StatusCode = 404;
                return View("NotFiled", id);
            }
            return View(record);
        }
    }
}
