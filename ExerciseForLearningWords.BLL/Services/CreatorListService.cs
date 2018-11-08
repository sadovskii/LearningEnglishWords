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
        private IWordsAndTranslationPairRepository wordsAndTranslationPairRepository;
        private IWordsListRepository wordsListRepository;

        public CreatorListService(IWordsAndTranslationPairRepository wordsAndTranslationPairRepository, IWordsListRepository wordsListRepository)
        {
            this.wordsAndTranslationPairRepository = wordsAndTranslationPairRepository;
            this.wordsListRepository = wordsListRepository;
        }

        public void Delete(WordsListDTO wordsListDTO)
        {
            wordsListRepository.Delete(wordsListDTO.DtoToEntity());
        }

        public List<WordsListDTO> GetAllWordsLists()
        {
            return wordsListRepository.GetAll().EntityToDto();
        }

        public void CreateWordsList(SaveListWordsDTO saveListWords)
        {
            var list = saveListWords.PairsOfWords.Replace("\r\n", "").Split(';');
            var listOfPair = new List<WordsAndTranslationPairDTO>();
            foreach(var a in list)
            {
                if(!string.IsNullOrEmpty(a))
                {
                    var list2 = a.Split('-');
                    listOfPair.Add(new WordsAndTranslationPairDTO { Word = list2[0].Trim(), Translation = list2[1].Trim()});
                }
            }

            var wordsList = new WordsListDTO
            {
                Name = saveListWords.Name,
                QuantityWords = listOfPair.Count
            };

            var WordsList = wordsListRepository.InsertAndGetEntity(wordsList.DtoToEntity()).EntityToDto();

            foreach (var a in listOfPair)
            {
                a.WordsListId = WordsList.Id;
                wordsAndTranslationPairRepository.Insert(a.DtoToEntity());
            }
        }
    }
}
