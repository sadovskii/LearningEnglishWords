using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.DAL.Models
{
    public class WordsAndTranslationPair
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Translation { get; set; }
        public int Status { get; set; }
        public List<WordsList> WordsLists { get; set; }
    }
}
