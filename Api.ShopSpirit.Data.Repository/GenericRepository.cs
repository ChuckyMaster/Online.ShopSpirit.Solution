using Api.ShopSpirit.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Data.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public Task<T> CreateElementAsync(T element)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteElementAsync(T element)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByKeyAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateElementAsync(T element)
        {
            throw new NotImplementedException();
        }
    }
}
