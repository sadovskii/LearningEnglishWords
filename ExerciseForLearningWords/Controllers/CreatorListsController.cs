using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseForLearningWords.BLL.Interfaces;
using ExerciseForLearningWords.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseForLearningWords.Controllers
{
    public class CreatorListsController : Controller
    {
        private readonly ICreatorListsService creatorListsService;

        public CreatorListsController(ICreatorListsService creatorListsService)
        {
            this.creatorListsService = creatorListsService;
        }

        public IActionResult Creator()
        {
            List<WordsListView> rrr = new List<WordsListView>
            {
                new WordsListView
                {
                     Id = 1,
                     Name = "1 name",
                     QuantityWords = 1
                },
                new WordsListView
                {
                     Id = 2,
                     Name = "2 name",
                     QuantityWords = 2
                },
                new WordsListView
                {
                     Id = 3,
                     Name = "3 name",
                     QuantityWords = 3
                }
            };

            return View(rrr);
        }

        public IActionResult DeleteWordsList(int id)
        {
            return RedirectToAction("Creator");
        }

    }
}