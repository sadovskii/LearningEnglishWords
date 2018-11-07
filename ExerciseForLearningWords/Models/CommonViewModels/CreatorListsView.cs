using ExerciseForLearningWords.CommonViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseForLearningWords.Models.CommonViewModels
{
    public class CreatorListsView
    {
        public SaveListWordsView saveListWords { get; set; }
        public List<WordsListView> wordsLists { get; set; }
    }
}
