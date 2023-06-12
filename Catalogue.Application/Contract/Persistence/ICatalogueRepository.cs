using Catalogue.Domain.Entities;
using Ordering.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.Application.Contract.Persistence
{
    public interface ICatalogueRepository : IAsyncRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductByName(string ProductName);
    }
}
