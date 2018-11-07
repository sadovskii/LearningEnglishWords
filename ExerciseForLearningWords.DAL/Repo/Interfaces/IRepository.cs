using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseForLearningWords.DAL.Repo.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        int InsertAndGetId(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
        void Dispose();
    }
}
