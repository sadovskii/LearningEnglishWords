using ExerciseForLearningWords.BLL.Interfaces;
using ExerciseForLearningWords.BLL.Models;
using ExerciseForLearningWords.DAL.Models;
using ExerciseForLearningWords.DAL.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseForLearningWords.BLL.Services
{
    public class ExerciseForLearningService : IExerciseForLearningService
    {
        private IWordsAndTranslationPairRepository wordsAndTranslationPairRepository;
        private IWordsListRepository wordsListRepository;

        public ExerciseForLearningService(IWordsAndTranslationPairRepository wordsAndTranslationPairRepository, IWordsListRepository wordsListRepository)
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
            return wordsAndTranslationPairRepository.GetWordsAndTranslationPairsByRefWordsList(id).EntityToDto();
        }
    }
}
