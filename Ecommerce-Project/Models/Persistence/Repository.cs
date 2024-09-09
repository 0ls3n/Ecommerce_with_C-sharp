using Ecommerce_Project.Models.Domain_Classes;

namespace Ecommerce_Project.Models.Persistence
{
    /* This class is made generic because it saves a lot of lines of code when creating new model classes that needs a repository.
       it also implements all aspects of CRUD (Create, Retrieve, Update, Delete) */

    public class Repository<T> : IRepository<T> where T : Model // This tells the compiler that it's only objects with the type of Model that can be used
    {
        
        private List<T> _repository;
        public Repository()
        {
            _repository = new List<T>();
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            _repository.Remove(entity);
        }

        public void DeleteAll()
        {
            _repository.Clear();
        }

        public List<T> GetAll()
        {
            return _repository;
        }

        public T? GetById(int? id)
        {
            return _repository.Find(x => x.Id == id);
        }

        public void Update(T newEntity)
        {
            T? oldEntity = GetById(newEntity.Id);
            if (oldEntity != null)
            {
                _repository.Remove(oldEntity);
                _repository.Add(newEntity);
            }
            else { return; }
        }
    }
}
