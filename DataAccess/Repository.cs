﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> GetAll() => _dbSet.ToList();
        public T GetById(int id) => _dbSet.Find(id);
        public void Add(T entity) { _dbSet.Add(entity); _context.SaveChanges(); }
        public void Update(T entity) { _dbSet.Update(entity); _context.SaveChanges(); }
        public void Delete(T entity) { _dbSet.Remove(entity); _context.SaveChanges(); }
    }
}
