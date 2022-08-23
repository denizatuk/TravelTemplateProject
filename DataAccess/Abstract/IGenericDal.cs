﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetAll();
        
    }
}
