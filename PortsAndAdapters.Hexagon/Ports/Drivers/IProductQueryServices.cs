using System;
using System.Collections.Generic;
using PortsAndAdapters.Hexagon.Ports.Drivers.Data_Transfer_Objects;

namespace PortsAndAdapters.Hexagon.Ports.Drivers
{
    public interface IProductQueryServices
    {
        List<ProductListingDTO> List(int? page = null, int? pageSize = null);
        List<ProductListingDTO> GetByIds(List<Guid> ids);

        List<ProductListingDTO> GetByNames(List<Guid> names);

        ProductFullDTO GetById(Guid id);

        ProductFullDTO GetByName(Guid id);
    }
}
