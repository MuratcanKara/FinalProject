using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip olabilir demek
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // =null filtire vermeye de bilirsin demek
        T Get(Expression<Func<T, bool>> filter); // filtre zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
