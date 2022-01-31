using internetBankingProject.Data;
using InternetBankingProject.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InternetBankingProject.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        public async Task  Delete(int id)
        {
            var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }
         
        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;
            if (includes !=null)
            {
                foreach (var includePropery in includes)
                {
                    query = query.Include(includePropery);

                }
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
            //var entity = await _context.Set<T>().FindAsync(Id);
            //return entity;
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>>orderBy = null, List<string> includes = null)
        {
            //var entities = await _context.Set<T>().ToListAsync();
            //return entities;

            IQueryable<T> query = _db;

            if (expression !=null)
            {
                query = query.Where(expression);
            }
            if (includes != null)
            {
                foreach (var includePropery in includes)
                {
                    query = query.Include(includePropery);

                }
            }

            if (orderBy !=null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }
        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
