using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public static class RepositoryExtensions
    {
        public static void AddBatch<T>(this IRepository<T> repository, T[] items)
            where T : IEntity
        {
            foreach (var item in items)
            {
                repository.Add(item);
            }
            repository.Save();
        }
    }
}
