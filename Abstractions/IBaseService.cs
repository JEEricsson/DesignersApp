using System;
using System.Linq.Expressions;

namespace DesignApp.Abstractions
{
    public interface IBaseService<T> : IDisposable where T : BaseModel, new()
    {
        void SaveItem(T item);
        T GetItem(int id);
        T GetItem(Expression<Func<T, bool>> predicate);
        List<T> GetItems();
        List<T> GetItems(Expression<Func<T, bool>> predicate);
        void DeleteItem(T item);

    }
}

