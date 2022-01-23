﻿using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T item);
        T GetById(int id);
        void Remove(T item);
        void Save();
    }
}