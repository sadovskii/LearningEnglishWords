using ExerciseForLearningWords.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<WordsAndTranslationPair> WordsAndTranslationPairs { get; set; }
        public DbSet<WordsList> WordsLists { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
