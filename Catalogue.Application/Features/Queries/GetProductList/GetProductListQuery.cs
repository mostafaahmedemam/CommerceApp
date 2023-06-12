using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.Application.Features.Queries.GetProductList
{
    public class GetProductListQuery : IRequest<List<ProductVm>>
    {
        public string ProductName { get; set; }

        public GetProductListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }

    }
}
