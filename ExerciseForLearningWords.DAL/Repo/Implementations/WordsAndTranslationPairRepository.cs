using ExerciseForLearningWords.DAL.EF;
using ExerciseForLearningWords.DAL.Models;
using ExerciseForLearningWords.DAL.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ExerciseForLearningWords.DAL.Repo.Implementations
{
    public class WordsAndTranslationPairRepository : GenericRepository<ApplicationContext, WordsAndTranslationPair>, IWordsAndTranslationPairRepository
    {
        public WordsAndTranslationPairRepository(ApplicationContext context) : base(context)
        {
        }

        public List<WordsAndTranslationPair> GetWordsAndTranslationPairsByRefWordsList(int id)
        {
            var a = (from pair in context.WordsAndTranslationPairs
                    where pair.WordsListId == id
                    select pair).ToList();
            return a;
        }
    }
}
