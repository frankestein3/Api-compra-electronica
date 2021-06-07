using compraElectronica.Context;
using compraElectronica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace compraElectronica.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDbContext context;
        public ProductoController(AppDbContext context)
        {
            this.context = context;
        }




        // GET: api/<ProductoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Producto.ToList());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}", Name ="getProducto")]
        public ActionResult Get(int id)
        {
            try
            {
                var producto = context.Producto.FirstOrDefault(f => f.id_producto == id);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult GetPrecio(int id)
        {
            try
            {
                var precio = context.Producto.FirstOrDefault(f => f.id_producto == id);
                return Ok(precio.precio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
