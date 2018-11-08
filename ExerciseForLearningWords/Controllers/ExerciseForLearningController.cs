using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseForLearningWords.BLL.Interfaces;
using ExerciseForLearningWords.CommonViewModels.Models;
using ExerciseForLearningWords.Converters;
using ExerciseForLearningWords.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseForLearningWords.Controllers
{
    public class ExerciseForLearningController : Controller
    {
        private ShowHideRandomExerciseView showHideRandomExercise;
        private readonly IExerciseForLearningService exerciseForLearningService;

        public ExerciseForLearningController(IExerciseForLearningService exerciseForLearningService)
        {
            showHideRandomExercise = new ShowHideRandomExerciseView();
            this.exerciseForLearningService = exerciseForLearningService;
        }

        [HttpGet]
        public IActionResult ShowHideRandomExercise()
        {
            showHideRandomExercise.WordsList = exerciseForLearningService.GetAllWordsLists().DtoToView();

            return View(showHideRandomExercise);
        }

        public IActionResult SelectWordsPairs(WordsListView wordsListView)
        {
            showHideRandomExercise.WordsAndTranslationPairs = exerciseForLearningService.GetAllWordsListsByWordsListId(wordsListView.Id).DtoToView();
            showHideRandomExercise.WordsList = exerciseForLearningService.GetAllWordsLists().DtoToView();

            return View(showHideRandomExercise);
        }
    }
}