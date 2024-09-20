using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Repositories.IRepos
{
    /// <summary>
    /// This interface is used for making CRUD operation in the database
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Adding entity to the database
        /// </summary>
        /// <param name="entity">entity</param>
        void Add(T entity);
        /// <summary>
        /// Deleting entity from the database
        /// </summary>
        /// <param name="entity">entity</param>
        void Delete(T entity);
        /// <summary>
        /// Updating entity in the database
        /// </summary>
        /// <param name="entity">entity</param>
        void Update(T oldEntity, T newEntity);
        /// <summary>
        /// Adding entity to the database
        /// </summary>
        /// <param name="id">identification</param>
        Task<T> GetById(int id);
        /// <summary>
        /// Getting all entities from the database
        /// </summary>
        List<T> GetAll();
    }
}
