using System;
using System.Collections.Generic;
using System.Text;
using PortsAndAdapters.Hexagon.Ports.Driven.Data_Transfer_Objects.Product;

namespace PortsAndAdapters.Hexagon.Ports.Driven.Repositories
{
    public interface IProductRepository
    {
        void Create(ProductCreateDTO productDTO);
        void Update(ProductUpdateDTO productDTO);
        void Delete(Guid Id);
        ProductDetailsDTO Get(Guid Id);
        List<ProductListDTO> List();
    }
}
