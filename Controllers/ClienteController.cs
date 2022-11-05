using HamburguesasChespi.Clases;
using HamburguesasChespi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HamburguesasChespi.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<ClienteCLS> ListaClientes()
        {
            List<ClienteCLS> Lista = new List<ClienteCLS>();
            using (db_a8f2d3_dbhamburguesascheContext bd = new db_a8f2d3_dbhamburguesascheContext())
            {
                Lista = (from cliente in bd.Clientes
                         where cliente.Id == 1
                         select new ClienteCLS
                         {
                             iidcliente = cliente.Id,
                             nombrecompleto = cliente.Nombre,
                             direccion = cliente.Direccion
                         }).ToList();
                return Lista;

            }
        }
    }
}
