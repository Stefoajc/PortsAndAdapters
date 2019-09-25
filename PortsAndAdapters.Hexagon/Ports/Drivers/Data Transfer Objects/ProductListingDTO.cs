﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PortsAndAdapters.Hexagon.Ports.Drivers.Data_Transfer_Objects
{
    public class ProductListingDTO
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
