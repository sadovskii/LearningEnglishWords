using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseForLearningWords.BLL.Interfaces;
using ExerciseForLearningWords.CommonViewModels.Models;
using ExerciseForLearningWords.Converters;
using ExerciseForLearningWords.Models;
using ExerciseForLearningWords.Models.CommonViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseForLearningWords.Controllers
{
    public class CreatorListsController : Controller
    {
        private readonly ICreatorListsService creatorListsService;
        private CreatorListsView creatorListsView;

        public CreatorListsController(ICreatorListsService creatorListsService)
        {
            creatorListsView = new CreatorListsView();
            this.creatorListsService = creatorListsService;
        }

        public IActionResult Creator()
        {
            creatorListsView.wordsLists = creatorListsService.GetAllWordsLists().DtoToView();

            return View(creatorListsView);
        }

        public IActionResult DeleteWordsList(WordsListView wordsListView)
        {
            creatorListsService.Delete(wordsListView.ViewToDto());

            return RedirectToAction("Creator");
        }

        public IActionResult SaveNewWordsList(CreatorListsView saveList)
        {
            creatorListsService.CreateWordsList(saveList.saveListWords.ViewToDto());
            return RedirectToAction("Creator");
        }

    }
}