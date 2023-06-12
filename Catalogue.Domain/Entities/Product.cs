using Catalogue.Domain.Entities;
using Catalogue.Domain.Common;
using System;

namespace Catalogue.Domain.Entities
{
    public class Product : EntityBase
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public Category ProductCatagory  { get; set; }
        public string ProductPrice{ get; set; }
    }
}