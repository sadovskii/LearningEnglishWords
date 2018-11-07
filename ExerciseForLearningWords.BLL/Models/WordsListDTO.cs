using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.BLL.Models
{
    public class WordsListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantityWords { get; set; }
        public List<WordsAndTranslationPairDTO> WordsAndTranslationPairs { get; set; }
    }
}
