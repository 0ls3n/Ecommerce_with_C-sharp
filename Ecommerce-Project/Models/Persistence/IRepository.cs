using Ecommerce_Project.Models.Domain_Classes;
using Microsoft.Identity.Client;

namespace Ecommerce_Project.Models.Persistence
{
    public interface IRepository<T> where T : Model
    {
        public void Add(T entity);
        public void Update(T newEntity);
        public void Delete(T entity);
        public void DeleteAll();
        public T? GetById(int? id);
        public List<T> GetAll();
    }
}
