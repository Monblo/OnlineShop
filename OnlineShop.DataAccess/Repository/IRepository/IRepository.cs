using System.Linq.Expressions;

namespace OnlineShop.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Cateogry
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
