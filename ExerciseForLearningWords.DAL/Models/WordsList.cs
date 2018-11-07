using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.DAL.Models
{
    public class WordsList : BaseEntity
    {
        public string Name { get; set; }
        public int QuantityWords { get; set; }
        public List<WordsAndTranslationPair> WordsAndTranslationPairs { get; set; }
    }
}
