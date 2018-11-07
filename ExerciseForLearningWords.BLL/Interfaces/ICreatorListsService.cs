using ExerciseForLearningWords.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.BLL.Interfaces
{
    public interface ICreatorListsService
    {
        void Delete(WordsListDTO wordsListDTO);
        List<WordsListDTO> GetAllWordsLists();
        void CreateWordsList(SaveListWordsDTO listWordsDTO);
    }
}
