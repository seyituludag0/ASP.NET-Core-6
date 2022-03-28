using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductManager : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new() { Id=1, Name="Phone", Price=3899, Stock=50},
            new() { Id=2, Name="Laptop", Price=5399, Stock=100},
            new() { Id=3, Name="Curved Monitor", Price=3000, Stock=20},
            new() { Id=4, Name="Wireless Keyboard", Price=500 , Stock=25 }
        };
    }
}
