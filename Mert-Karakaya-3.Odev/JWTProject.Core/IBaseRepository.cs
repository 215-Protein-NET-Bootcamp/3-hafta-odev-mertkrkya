using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTProject.Core
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id); 
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task InsertAsync(TEntity entity);
        void Update(TEntity entity); //Uzun işlem olmadığı için senkron da yapılabilir. Direkt stateyi değişiyor.
        void Delete(TEntity entity);
    }
}
