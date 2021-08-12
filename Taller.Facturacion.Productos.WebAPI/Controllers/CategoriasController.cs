using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Taller.Facturacion.Productos.WebAPI.Controllers
{
    [Route("api/[controller]")]

    public class CategoriasController:Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello categoria";
        }
    }
}
