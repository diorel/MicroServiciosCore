using System;
using System.Collections.Generic;
using Taller.Facturacion.Productos.Application.Services.Contracts;
using Taller.Facturacion.Productos.Domain.Entities;

namespace Taller.Facturacion.Productos.Application.Services
{
    public class ProductoService : IProductoService
    {
        public IEnumerable<Producto> findAll()
        {
            return new Producto[] { new Producto { Id = 1, Nombre="TV sony", PrecioUnicario=400, Stock=10, CategoriaId=1, Categoria= new Categoria {Id=1, Nombre="Electronica" }  }
            , new Producto { Id = 2 ,Nombre="TV JDC", PrecioUnicario=500, Stock=8, CategoriaId=1, Categoria= new Categoria {Id=1, Nombre="Electronica" } }
            , new Producto { Id = 3 ,Nombre="Alienware 15", PrecioUnicario=1600, Stock=3,CategoriaId=2 ,Categoria= new Categoria {Id=2, Nombre="Informatica" }  } };
        }

        public Producto findById(int id)
        {
            return new Producto { Id = 3, Nombre = "Alienware 15", PrecioUnicario = 1600, Stock = 3, CategoriaId = 2, Categoria = new Categoria { Id = 2, Nombre = "Informatica" } };
        }
    }
}
