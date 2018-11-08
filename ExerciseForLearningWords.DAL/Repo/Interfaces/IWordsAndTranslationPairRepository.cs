using ExerciseForLearningWords.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.DAL.Repo.Interfaces
{
    public interface IWordsAndTranslationPairRepository : IGenericRepository<WordsAndTranslationPair>
    {
        List<WordsAndTranslationPair> GetWordsAndTranslationPairsByRefWordsList(int id);
    }
}
