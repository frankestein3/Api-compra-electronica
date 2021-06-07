using compraElectronica.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace compraElectronica.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {

        private readonly AppDbContext context;
        public PedidoController(AppDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Pedido.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {

                var factura = context.Pedido.ToList().Where(f => f.id_pedido == id);
                return Ok(factura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetPedidoCliente(int id)
        {
            try
            {
                var pedido = context.Pedido.ToList().Where(f => f.id_cliente == id);
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult buscarCliente(int id)
        {
            try
            {

                var factura = context.Pedido.ToList().Where(f => f.id_cliente == id);
                return Ok(factura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
