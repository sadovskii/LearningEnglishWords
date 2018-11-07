using ExerciseForLearningWords.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.BLL.Interfaces
{
    public interface IExerciseForLearningService
    {
        List<WordsListDTO> GetAllWordsLists();
        List<WordsAndTranslationPairDTO> GetAllWordsListsByWordsListId(int id);
    }
}
