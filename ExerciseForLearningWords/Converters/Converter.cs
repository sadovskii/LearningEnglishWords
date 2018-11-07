using ExerciseForLearningWords.BLL.Models;
using ExerciseForLearningWords.CommonViewModels.Models;
using ExerciseForLearningWords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseForLearningWords.Converters
{
    public static class Converter
    {
        public static WordsListView DtoToView(this WordsListDTO wordsList)
        {
            return new WordsListView
            {
                Id = wordsList.Id,
                Name = wordsList.Name,
                QuantityWords = wordsList.QuantityWords
            };
        }

        public static List<WordsListView> DtoToView(this IEnumerable<WordsListDTO> wordsList)
        {
            return wordsList.Select(t => t.DtoToView()).ToList();
        }

        public static SaveListWordsView DtoToView(this SaveListWordsDTO saveListWords)
        {
            return new SaveListWordsView
            {
                Name = saveListWords.Name,
                PairsOfWords = saveListWords.PairsOfWords
            };
        }

        public static SaveListWordsDTO ViewToDto(this SaveListWordsView saveListWords)
        {
            return new SaveListWordsDTO
            {
                Name = saveListWords.Name,
                PairsOfWords = saveListWords.PairsOfWords
            };
        }

        public static WordsListDTO ViewToDto(this WordsListView wordsList)
        {
            return new WordsListDTO
            {
                Id = wordsList.Id,
                Name = wordsList.Name,
                QuantityWords = wordsList.QuantityWords
            };
        }

        public static List<WordsListDTO> ViewToDto(this IEnumerable<WordsListView> wordsList)
        {
            return wordsList.Select(t => t.ViewToDto()).ToList();
        }

        public static WordsAndTranslationPairView DtoToView(this WordsAndTranslationPairDTO wordsAndTranslationPair)
        {
            return new WordsAndTranslationPairView
            {
                Word = wordsAndTranslationPair.Word,
                Translation = wordsAndTranslationPair.Translation,
                Status = wordsAndTranslationPair.Status
            };
        }

        public static List<WordsAndTranslationPairView> DtoToView(this IEnumerable<WordsAndTranslationPairDTO> wordsAndTranslationPair)
        {
            return wordsAndTranslationPair.Select(t => t.DtoToView()).ToList();
        }

    }
}
