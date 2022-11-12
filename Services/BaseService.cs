using System;
using System.Linq.Expressions;
using CommunityToolkit.Mvvm.ComponentModel;
using DesignApp.Abstractions;
using SQLite;

namespace DesignApp.Services
{

    public partial class BaseService<T> : IBaseService<T> where T : BaseModel, new()
    {

        SQLiteConnection connection;
        public string StatusMessage { get; set; }

        public BaseService()
        {
            connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            connection.CreateTable<T>();
        }

        public void DeleteItem(T item)
        {
            try
            {

                connection.Delete(item);

            }
            catch (Exception ex)
            {
                StatusMessage =
                   $"Error: {ex.Message}";
            }
        }

        public void Dispose()
        {
            connection.Close();
        }

        public T GetItem(int id)
        {
            try
            {
                return connection.Table<T>()
                        .FirstOrDefault(x => x.Id == id);
            }
            catch (Exception ex)
            {
                StatusMessage =
                   $"Error: {ex.Message}";
            }
            return null;
        }

        public T GetItem(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return connection.Table<T>().Where(predicate).FirstOrDefault();

            }
            catch (Exception ex)
            {
                StatusMessage =
                   $"Error: {ex.Message}";
            }
            return null;
        }

        public List<T> GetItems()
        {
            try
            {
                return connection.Table<T>().ToList();

            }
            catch (Exception ex)
            {
                StatusMessage =
                   $"Error: {ex.Message}";
            }
            return null;
        }

        public List<T> GetItems(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return connection.Table<T>().Where(predicate).ToList();

            }
            catch (Exception ex)
            {
                StatusMessage =
                   $"Error: {ex.Message}";
            }
            return null;
        }

        public void SaveItem(T item)
        {
            int result = 0;
            try
            {
                if (item.Id != 0)
                {
                    result = connection.Update(item);
                    StatusMessage = $"{result} row(S) updated";
                }
                else
                {
                    result = connection.Insert(item);
                    StatusMessage = $"{result} row(S) added";

                }

            }
            catch (Exception e)
            {
                StatusMessage =
                    $"Error: {e.Message}";
            }
        }




    }


}

