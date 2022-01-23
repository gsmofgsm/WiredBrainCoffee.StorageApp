using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{

    public interface IReadRepository<out T> where T : IEntity  // T is covariant thanks to the out
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public interface IRepository<T> : IReadRepository<T> where T : IEntity // T is invariant
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}