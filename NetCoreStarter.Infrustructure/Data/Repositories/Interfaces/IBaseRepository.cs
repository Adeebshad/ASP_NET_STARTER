using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Infrustructure.Data.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync( Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        Task<T> GetByIDAsync(object id);
        Task InsertAsync(T entity);
        Task DeleteAsync(object id);
        void Delete(T entityToDelete);
        void Update(T entityToUpdate);
        Task<bool> CommitAsync();
        Task DisposeAsync();
    }
}
