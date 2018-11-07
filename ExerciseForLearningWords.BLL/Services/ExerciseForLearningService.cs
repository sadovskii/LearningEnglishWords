using ExerciseForLearningWords.BLL.Interfaces;
using ExerciseForLearningWords.BLL.Models;
using ExerciseForLearningWords.DAL.Models;
using ExerciseForLearningWords.DAL.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.BLL.Services
{
    public class ExerciseForLearningService : IExerciseForLearningService
    {
        private IRepository<WordsAndTranslationPair> wordsAndTranslationPairRepository;
        private IRepository<WordsList> wordsListRepository;

        public ExerciseForLearningService(IRepository<WordsAndTranslationPair> wordsAndTranslationPairRepository, IRepository<WordsList> wordsListRepository)
        {
            this.wordsAndTranslationPairRepository = wordsAndTranslationPairRepository;
            this.wordsListRepository = wordsListRepository;
        }

        public List<WordsListDTO> GetAllWordsLists()
        {
            return wordsListRepository.GetAll().EntityToDto();
        }

        public List<WordsAndTranslationPairDTO> GetAllWordsListsByWordsListId(int id)
        {
            return wordsListRepository.Get(id).WordsAndTranslationPairs.EntityToDto();
        }
    }
}
