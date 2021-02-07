﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    // class : referans tip olabilir
    // IEntity olabilir veya IEntity implemente eden bir class olabilir
    //new() : new'lenebilir olmalıdır
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void add(T entity);
        void update(T entity);
        void delete(T entity);
    }
}
