using System;
using System.Collections.Generic;
using System.Text;

namespace PortsAndAdapters.Hexagon.Ports.Driven.Data_Transfer_Objects.Product
{
    public class ProductDetailsDTO
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
