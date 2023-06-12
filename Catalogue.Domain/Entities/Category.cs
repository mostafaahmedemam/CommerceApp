using Catalogue.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.Domain.Entities
{
    public class Category : EntityBase
    {
        public Guid CatagoryId { get; set; }
        public string CategoryName { get; set; }    
        public string CategoryDescription { get; set; }
    }
}
