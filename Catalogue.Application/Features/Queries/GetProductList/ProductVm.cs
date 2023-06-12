using Catalogue.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.Application.Features.Queries.GetProductList
{
    public class ProductVm
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductAvailabilityName { get; set; }
        public Category ProductCatagory { get; set; }
        public string ProductPrice { get; set; }
    }
}
