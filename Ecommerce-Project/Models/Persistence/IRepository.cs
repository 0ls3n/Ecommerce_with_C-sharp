using Ecommerce_Project.Models.Domain_Classes;
using Microsoft.Identity.Client;

namespace Ecommerce_Project.Models.Persistence
{
    public interface IRepository<T> where T : Model
    {
        public Task AddAsync(T entity);
        public Task UpdateAsync(T newEntity);
        public Task DeleteAsync(int id);
        public Task DeleteAllAsync();
        public Task<T> GetByIdAsync(int? id);
        public Task<List<T>> GetAllAsync();
    }
}
