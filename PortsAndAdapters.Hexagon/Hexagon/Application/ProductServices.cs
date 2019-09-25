using System;
using System.Collections.Generic;
using System.Text;
using PortsAndAdapters.Hexagon.Ports.Driven.Repositories;
using PortsAndAdapters.Hexagon.Ports.Drivers;
using PortsAndAdapters.Hexagon.Ports.Drivers.Data_Transfer_Objects;

namespace PortsAndAdapters.Hexagon.Hexagon.Application
{
    public class ProductServices : IProductCommandServices, IProductQueryServices
    {
        private readonly IProductRepository productRepository;

        public ProductServices(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ProductFullDTO GetById(Guid id) => throw new NotImplementedException();
        public List<ProductListingDTO> GetByIds(List<Guid> ids) => throw new NotImplementedException();
        public ProductFullDTO GetByName(Guid id) => throw new NotImplementedException();
        public List<ProductListingDTO> GetByNames(List<Guid> names) => throw new NotImplementedException();
        public List<ProductListingDTO> List(int? page = null, int? pageSize = null) => throw new NotImplementedException();
        public void UpdatePrice(Guid productId, decimal newPrice) => throw new NotImplementedException();
        public void Create(ProductCreateDTO productDTO) => throw new NotImplementedException();
        public void Delete(Guid productId) => throw new NotImplementedException();
    }
}
