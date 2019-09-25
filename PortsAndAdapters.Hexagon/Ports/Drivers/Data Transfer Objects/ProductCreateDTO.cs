using System;

namespace PortsAndAdapters.Hexagon.Ports.Drivers.Data_Transfer_Objects
{
    public class ProductCreateDTO
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
