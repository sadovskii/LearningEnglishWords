using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExerciseForLearningWords.DAL.Repo.Interfaces
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetBy(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        T InsertAndGetEntity(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
