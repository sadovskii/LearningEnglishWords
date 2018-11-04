using ExerciseForLearningWords.BLL.Interfaces;
using ExerciseForLearningWords.BLL.Models;
using ExerciseForLearningWords.DAL.Models;
using ExerciseForLearningWords.DAL.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.BLL.Services
{
    public class CreatorListService : ICreatorListsService
    {
        private IRepository<WordsAndTranslationPair> wordsAndTranslationPairRepository;
        private IRepository<WordsList> wordsListRepository;

        public CreatorListService(IRepository<WordsAndTranslationPair> wordsAndTranslationPairRepository, IRepository<WordsList> wordsListRepository)
        {
            this.wordsAndTranslationPairRepository = wordsAndTranslationPairRepository;
            this.wordsListRepository = wordsListRepository;
        }
        public void Delete(WordsListDTO wordsListDTO)
        {
            wordsListRepository.Delete(wordsListDTO.DtoToEntity());
        }
    }
}
