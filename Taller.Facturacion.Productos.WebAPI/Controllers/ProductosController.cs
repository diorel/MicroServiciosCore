using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Taller.Facturacion.Productos.Application.Services.Contracts;
using Taller.Facturacion.Productos.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Taller.Facturacion.Productos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductosController : Controller
    {


        private readonly IProductoService _procutoService;

        public ProductosController(IProductoService procutoService)
        {
            _procutoService = procutoService;

        }

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return Ok(this._procutoService.findAll());
        }


        // GET: api/values
        //[HttpGet]
        //public IEnumerable<Producto> Get()
        //{
        //    return this._procutoService.findAll();
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            return this._procutoService.findById(id);
        }

        // POST api/values
        [HttpPost]
        public Producto Post([FromBody] Producto producto)
        {
            return producto;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Producto producto)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
