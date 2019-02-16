using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SuggestToSocialApp.WebUI.Repository.Abstract
{
    public interface IGenericRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        T GetById(int postId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
