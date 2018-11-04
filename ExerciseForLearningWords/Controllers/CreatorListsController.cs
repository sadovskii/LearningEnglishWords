using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseForLearningWords.Controllers
{
    public class CreatorListsController : Controller
    {
        public IActionResult Creator()
        {
            return View();
        }
    }
}