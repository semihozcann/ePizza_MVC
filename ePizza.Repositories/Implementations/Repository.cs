﻿using ePizza.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            //remove asenkron bir metot olmadıgından dolayı biz burada task.run kullanarak remove asenkron bir hale getirmiş olduk...
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
            return entity;
        }

        public async Task<TEntity> FindAsync(object id)
        {
            return await _context.Set<TEntity>().FindAsync();
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            //1 eğer where sorgusu yoksa direk olarak liste gönder eğer where sorgusu where sorgusunu gonder seklinde calısmaktadır. 
            IQueryable<TEntity> query = _context.Set<TEntity>();
            //(x=>x.CategorId==id);
            if (predicate!=null) // where sorgusu null değilse
            {

                query = query.Where(predicate); // where sorgusu
            }
            if (includeProperties.Any()) 
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);

                }
            }
            return await query.ToListAsync();

        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            //where sorgusu IQueryable : database seviyesind where sorgusu yapıp bize ilgili datayı getirir önce where sorgusunu ceker sonra gönderir listeyi

            //IEnumable : önce liste yapıp sonra where sorgusu ceker.

            IQueryable<TEntity> query = _context.Set<TEntity>();
            //(x=>x.CategorId==id);
            query = query.Where(predicate);
            if (includeProperties.Any())
            {
                //Todo:Tekrar Kontrol edilecektir.
                foreach (var includeProperty in includeProperties)
                {

                    query = query.Include(includeProperty); 
                }

            }
            return await query.SingleOrDefaultAsync();


        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
            return entity;
        }
    }
}
