using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseForLearningWords.CommonViewModels.Models;
using ExerciseForLearningWords.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseForLearningWords.Controllers
{
    public class ExerciseForLearningController : Controller
    {
        private ShowHideRandomExerciseView showHideRandomExercise = new ShowHideRandomExerciseView();

        [HttpGet]
        public IActionResult ShowHideRandomExercise()
        {
            showHideRandomExercise.WordsList = new List<WordsListView>
                 {
                     new WordsListView
                     {
                         Id = 1,
                         Name = "1 name",
                         QuantityWords = 12
                     },
                     new WordsListView
                     {
                         Id = 2,
                         Name = "2 name",
                         QuantityWords = 13
                     },
                     new WordsListView
                     {
                         Id = 3,
                         Name = "3 name",
                         QuantityWords = 14
                     },
                 };

            return View(showHideRandomExercise);
        }

        public IActionResult SelectWordsPairs(WordsListView wordsListView)
        {
            showHideRandomExercise.WordsAndTranslationPairs = new List<WordsAndTranslationPairView>
            {
                new WordsAndTranslationPairView
                {
                    Word = "Папа",
                    Translation = "Dad",
                    Status = 0
                },
                new WordsAndTranslationPairView
                {
                    Word = "Мама",
                    Translation = "Mum",
                    Status = 0
                },
                new WordsAndTranslationPairView
                {
                    Word = "Сестра",
                    Translation = "Sister",
                    Status = 0
                }
            };

            return RedirectToAction("ShowHideRandomExercise");
        }
    }
}