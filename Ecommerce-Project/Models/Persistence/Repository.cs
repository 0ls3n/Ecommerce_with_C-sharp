using Ecommerce_Project.Models.Domain_Classes;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Project.Models.Persistence
{
    /* This class is made generic because it saves a lot of lines of code when creating new model classes that needs a repository.
       it also implements all aspects of CRUD (Create, Retrieve, Update, Delete) */

    public class Repository<T> : IRepository<T> where T : Model // This tells the compiler that it's only objects with the type of Model that can be used
    {
        private readonly ProductDbContext _context;
        private readonly DbSet<T> _dbSet;

        private List<T> _repository;
        public Repository(ProductDbContext context)
        {
            _repository = new List<T>();
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            //_repository.Add(entity);
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            //_repository.Remove(entity);
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAllAsync()
        {
            //_repository.Clear();
            foreach (var entity in _dbSet.ToList())
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            //return _repository.Find(x => x.Id == id);
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            //T? oldEntity = await GetByIdAsync(newEntity.Id);
            //if (oldEntity != null)
            //{
            //    _repository.Remove(oldEntity);
            //    _repository.Add(newEntity);
            //}
            //else { return; }

            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
