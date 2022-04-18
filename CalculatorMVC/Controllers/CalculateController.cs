using Microsoft.AspNetCore.Mvc;

namespace CalculatorMVC.Controllers
{
    public class CalculateController : Controller
    {

        public ActionResult Index(string firstNumber, string secondNumber, string Cal)
        {
            int a = Convert.ToInt32(firstNumber);
            int b = Convert.ToInt32(secondNumber);
            int c = 0;
            
            switch (Cal)
            {
                case "Add": c = a + b; break;
                case "Sub": c = a - b; break;
                case "Mul": c = a * b; break;
                case "Div": c = a / b; break;
            }
            
            

            ViewBag.Result = c;
            return View();
        }




    }
}
