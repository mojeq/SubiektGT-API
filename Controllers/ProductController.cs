using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubiektGT_API.Models;
using SubiektGT_API.Services;

namespace SubiektGT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/GetAllProducts
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            ProductService productService = new ProductService();
            IEnumerable<Product> productsList = productService.GetAllProducts();

            return productsList;
        }
    }
}