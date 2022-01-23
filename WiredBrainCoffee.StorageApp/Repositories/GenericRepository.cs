using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        protected readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Save()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
