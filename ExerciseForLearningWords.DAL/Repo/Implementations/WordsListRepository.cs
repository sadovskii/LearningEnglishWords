using ExerciseForLearningWords.DAL.EF;
using ExerciseForLearningWords.DAL.Models;
using ExerciseForLearningWords.DAL.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ExerciseForLearningWords.DAL.Repo.Implementations
{
    public class WordsListRepository : GenericRepository<ApplicationContext, WordsList>, IWordsListRepository
    {
        public WordsListRepository(ApplicationContext context) : base(context)
        {
        }

    }
}
