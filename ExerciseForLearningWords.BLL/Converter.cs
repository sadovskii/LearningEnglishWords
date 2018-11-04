using ExerciseForLearningWords.BLL.Models;
using ExerciseForLearningWords.DAL.Models;
using System;
using System.Collections.Generic;
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

        public static WordsList DtoToEntity(this WordsListDTO wordsList)
        {
            return new WordsList
            {
                Id = wordsList.Id,
                Name = wordsList.Name,
                QuantityWords = wordsList.QuantityWords
            };
        }
    }
}
