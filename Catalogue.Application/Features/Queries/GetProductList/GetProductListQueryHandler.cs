using AutoMapper;
using Catalogue.Application.Contract.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalogue.Application.Features.Queries.GetProductList
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, List<ProductVm>>
    {
        private readonly ICatalogueRepository _catalogueRepository;
        private readonly IMapper _mapper;

        public GetProductListQueryHandler(ICatalogueRepository orderRepository, IMapper mapper)
        {
            _catalogueRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<ProductVm>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var ordersList = await _catalogueRepository.GetProductByName(request.ProductName);
            return _mapper.Map<List<ProductVm>>(ordersList);
        }
    }
}
