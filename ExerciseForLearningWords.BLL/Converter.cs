using ExerciseForLearningWords.BLL.Models;
using ExerciseForLearningWords.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciseForLearningWords.BLL
{
    public static class Converter
    {
        public static WordsListDTO EntityToDto(this WordsList wordsList)
        {
            return new WordsListDTO
            {
                Id = wordsList.Id,
                Name = wordsList.Name,
                QuantityWords = wordsList.QuantityWords
            };
        }

        public static List<WordsListDTO> EntityToDto(this IEnumerable<WordsList> wordsList)
        {
            return wordsList.Select(t => t.EntityToDto()).ToList();
        }

        public static WordsList DtoToEntity(this WordsListDTO wordsList)
        {
            return new WordsList
            {
                Id = wordsList.Id,
                Name = wordsList.Name,
                QuantityWords = wordsList.QuantityWords
            };
        }

        public static List<WordsList> DtoToEntity(this IEnumerable<WordsListDTO> wordsList)
        {
            return wordsList.Select(t => t.DtoToEntity()).ToList();
        }

        public static WordsAndTranslationPair DtoToEntity(this WordsAndTranslationPairDTO WordsAndTranslationPair)
        {
            return new WordsAndTranslationPair
            {
                Id = WordsAndTranslationPair.Id,
                Word = WordsAndTranslationPair.Word,
                Translation = WordsAndTranslationPair.Translation,
                Status = WordsAndTranslationPair.Status,
                WordsListId = WordsAndTranslationPair.WordsListId
            };
        }

        public static List<WordsAndTranslationPair> DtoToEntity(this IEnumerable<WordsAndTranslationPairDTO> WordsAndTranslationPairs)
        {
            return WordsAndTranslationPairs.Select(t => t.DtoToEntity()).ToList();
        }

        public static WordsAndTranslationPairDTO EntityToDto(this WordsAndTranslationPair WordsAndTranslationPair)
        {
            return new WordsAndTranslationPairDTO
            {
                Id = WordsAndTranslationPair.Id,
                Word = WordsAndTranslationPair.Word,
                Translation = WordsAndTranslationPair.Translation,
                Status = WordsAndTranslationPair.Status,
                WordsListId = WordsAndTranslationPair.WordsListId
            };
        }

        public static List<WordsAndTranslationPairDTO> EntityToDto(this IEnumerable<WordsAndTranslationPair> WordsAndTranslationPairs)
        {
            var a = WordsAndTranslationPairs.Select(t => t.EntityToDto());
            return a.ToList();
        }
    }
}
