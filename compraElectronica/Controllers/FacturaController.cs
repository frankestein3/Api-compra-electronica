using compraElectronica.Context;
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
    public class FacturaController : ControllerBase
    {

        private readonly AppDbContext context;
        public FacturaController(AppDbContext context)
        {
            this.context = context;
        }




        // GET: api/<FacturaController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Factura.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //GET api/<FacturaController>/


        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {

                var factura = context.Factura.ToList().Where(f => f.id_factura == id);
                return Ok(factura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult buscarProducto(int id)
        {
            try
            {

                var producto = context.Producto.ToList().Where(f => f.id_producto == id);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public ActionResult buscarPedido(int id)
        {
            try
            {

                var factura = context.Factura.ToList().Where(f => f.id_pedido == id);
                return Ok(factura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
