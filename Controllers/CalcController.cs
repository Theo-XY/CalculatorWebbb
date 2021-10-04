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
            int numberOne = int.Parse(firstNumber);
            int numberTwo = int.Parse(secondNumber);
            int result = numberOne + numberTwo;
            ViewBag.Result = result;
            return View();

        }
    }
}