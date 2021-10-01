using Microsoft.AspNetCore.Mvc;

namespace CalculatorWeb.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
         public ActionResult Add()
         {
             return View();
         }

         [HttpPost]
         public ActionResult Add(string firstNumber, string secondNumber)
        {
            return View();
        }
    }
}