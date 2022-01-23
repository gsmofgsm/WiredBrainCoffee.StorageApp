using System;
using System.Collections.Generic;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);
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
