using CalculatorMVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace CalculatorMVC.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            if (model.Operation == CalculatorModel.OperationType.Addition)
            {
                model.Result = model.NumberA + model.NumberB;
            }
            else if (model.Operation == CalculatorModel.OperationType.Subtraction)
            {
                model.Result = model.NumberA - model.NumberB;
            }
            else if (model.Operation == CalculatorModel.OperationType.Multiplication)
            {
                model.Result = model.NumberA * model.NumberB;
            }
            else if (model.Operation == CalculatorModel.OperationType.Division)
            {
                model.Result = model.NumberA / model.NumberB;
            }

            return View(model);
        }

        
    }
}
