using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseForLearningWords.CommonViewModels.Models
{
    public class SaveListWordsView
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string PairsOfWords { get; set; }
    }
}
