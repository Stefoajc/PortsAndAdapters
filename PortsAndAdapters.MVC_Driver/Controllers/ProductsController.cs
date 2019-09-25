using System;
using Microsoft.AspNetCore.Mvc;
using PortsAndAdapters.Hexagon.Ports.Drivers;
using PortsAndAdapters.Hexagon.Ports.Drivers.Data_Transfer_Objects;
using PortsAndAdapters.MVC_Driver.Models;

namespace PortsAndAdapters.MVC_Driver.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductCommandServices productCommands;
        private readonly IProductQueryServices productQueries;

        public ProductsController(IProductCommandServices productCommands, 
            IProductQueryServices productQueries)
        {
            this.productCommands = productCommands;
            this.productQueries = productQueries;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(ProductCreateViewModel productCreateVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            productCommands.Create(new ProductCreateDTO
            {
                ProductID = Guid.NewGuid(),
                Price = productCreateVM.Price,
                // other properties
            });

            return RedirectToAction("Details");
        }
        public IActionResult Details(Guid id)
        {
            var product = productQueries.GetById(id);

            return View(product);
        }
    }
}