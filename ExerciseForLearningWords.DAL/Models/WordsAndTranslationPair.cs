using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.DAL.Models
{
    public class WordsAndTranslationPair : BaseEntity
    {
        public string Word { get; set; }
        public string Translation { get; set; }
        public int Status { get; set; }
        public int WordsListId { get; set; }
        public WordsList WordsList { get; set; }
    }
}
