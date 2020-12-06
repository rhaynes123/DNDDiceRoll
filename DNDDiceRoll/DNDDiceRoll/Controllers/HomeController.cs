using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DNDDiceRoll.Models;

namespace DNDDiceRoll.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private const int defaultbound = 1;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RollResult([FromBody]Roll roll)
        {
            var dice = new Dice(roll.Sides);
            var SumOfRolls = 0;

            for (int r =0; r<roll.Qty; r++)
            {
                SumOfRolls += GetRandomFromDiceTypes(dice.NumberOfSides);
            }
            return new JsonResult(SumOfRolls + roll.Bonus);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private int GetRandomFromDiceTypes(int DiceTypes) 
        {
            var randomResult = 0;

            try
            {
                var random = new Random();
                randomResult = random.Next(defaultbound, DiceTypes + defaultbound);
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetRandomFromDiceTypes didn\'t work: \n{ex}");
            }
            return randomResult;
        }
    }
}
