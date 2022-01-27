using KCG_Net_Challenge.Data;
using KCG_Net_Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCG_Net_Challenge.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ApplicationDbContext context, ILogger<PedidoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            ViewData["Title"] = "Pedido";
            List<Pedido> pedidos = await _context.Pedido.ToListAsync();
            return View(pedidos);
        }

        [HttpGet]
        public IActionResult Nuevo()
        {
            NuevoPedido pedido = new NuevoPedido();
            List<Cliente> clientes = _context.Cliente.ToList();
            List<Producto> productos = _context.Producto.ToList();

            pedido.cliente = clientes;
            pedido.producto = productos;
            return View(pedido);
        }

        [HttpPost]
        public async Task<ActionResult> Nuevo(DateTime fecha, string codigoCliente, Decimal precioTotal, List<string> rows)
        {
            try
            {
                if (rows.Count == 0)
                    return BadRequest("Debe ingresar al menos un producto");
                if(codigoCliente == "0")
                    return BadRequest("Debe seleccionar un cliente");
                Pedido pedido = new Pedido();
                pedido.Fecha = fecha;
                pedido.CodigoCliente = codigoCliente;
                pedido.PrecioTotal = precioTotal;
                pedido.Codigo = new Guid();
                _context.Add(pedido);

                await _context.SaveChangesAsync();

                foreach (string row in rows)
                {
                    string[] result = row.Split(";");
                    DetallePedido detalle = new DetallePedido();
                    detalle.CodigoPedido = pedido.Codigo;
                    detalle.CodigoProducto = result[0];
                    detalle.Descripcion = result[1];
                    detalle.Cantidad = int.Parse(result[2]);
                    detalle.PrecioUnitario = Decimal.Parse(result[3]);
                    detalle.SubTotal = Decimal.Parse(result[4]);
                    _context.Add(detalle);
                }

                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
