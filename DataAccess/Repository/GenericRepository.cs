﻿using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T item)
        {
            using var c = new Context();
            c.Add(item);
            c.SaveChanges();
        }

        public void Delete(T item)
        {
            using var c = new Context();
            c.Remove(item);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Update(T item)
        {
            using var c = new Context();
            c.Update(item);
            c.SaveChanges();
        }
    }
}
