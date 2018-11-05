using ExerciseForLearningWords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseForLearningWords.CommonViewModels.Models
{
    public class ShowHideRandomExerciseView
    {
        public List<WordsListView> WordsList { get; set; }
        public List<WordsAndTranslationPairView> WordsAndTranslationPairs { get; set; }
    }
}
