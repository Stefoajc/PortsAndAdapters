using System;
using PortsAndAdapters.Hexagon.Ports.Drivers.Data_Transfer_Objects;

namespace PortsAndAdapters.Hexagon.Ports.Drivers
{
    public interface IProductCommandServices
    {
        void Create(ProductCreateDTO productDTO);
        void UpdatePrice(Guid productId, decimal newPrice);
        void Delete(Guid productId);

    }
}
