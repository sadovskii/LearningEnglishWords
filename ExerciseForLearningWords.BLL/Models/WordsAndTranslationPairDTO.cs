using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.BLL.Models
{
    public class WordsAndTranslationPairDTO
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Translation { get; set; }
        public int Status { get; set; }
        public int WordsListId { get; set; }
    }
}
