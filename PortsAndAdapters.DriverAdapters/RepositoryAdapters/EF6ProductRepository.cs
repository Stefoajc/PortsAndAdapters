using System;
using System.Collections.Generic;
using System.Text;
using PortsAndAdapters.Hexagon.Ports.Driven.Data_Transfer_Objects.Product;
using PortsAndAdapters.Hexagon.Ports.Driven.Repositories;

namespace PortsAndAdapters.DrivenAdapters.RepositoryAdapters
{
    public class EF6ProductRepository : IProductRepository
    {
        public void Create(ProductCreateDTO productDTO) => throw new NotImplementedException();
        public void Delete(Guid Id) => throw new NotImplementedException();
        public ProductDetailsDTO Get(Guid Id) => throw new NotImplementedException();
        public List<ProductListDTO> List() => throw new NotImplementedException();
        public void Update(ProductUpdateDTO productDTO) => throw new NotImplementedException();
    }
}
