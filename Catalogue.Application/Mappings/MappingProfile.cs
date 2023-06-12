using AutoMapper;
using Catalogue.Application.Features.Queries.GetProductList;
using Catalogue.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogue.Application.Mappings
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductVm>().ReverseMap();
        }
    }
}
