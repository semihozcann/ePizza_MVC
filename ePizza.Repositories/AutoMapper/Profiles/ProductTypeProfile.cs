using AutoMapper;
using ePizza.Entities.Concrete;
using ePizza.Entities.Dtos.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizza.Repositories.AutoMapper.Profiles
{
    public class ProductTypeProfile : Profile
    {
        public ProductTypeProfile()
        {
            CreateMap<ProductTypeAddDto, ProductType>();
            CreateMap<ProductTypeUpdateDto, ProductType>();
            CreateMap<ProductType, ProductTypeUpdateDto>();
        }
    }
}
