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
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly AppDbContext context;
        public ClienteController(AppDbContext context)
        {
            this.context = context;
        }



        // GET: api/<ClienteController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Cliente.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        // GET api/<ClienteController>/
        [HttpGet("{id}", Name = "getCliente")]
        public ActionResult Get(int id)
        {
            try
            {
                var cliente = context.Cliente.FirstOrDefault(f => f.id_cliente == id);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
