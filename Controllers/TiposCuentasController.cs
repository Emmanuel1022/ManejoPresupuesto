using Dapper;
using ManejoPresupuesto.Models;
using ManejoPresupuesto.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController: Controller
    {
        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        {
            this.repositorioTiposCuentas = repositorioTiposCuentas;
        }
        public IActionResult Crear()
        {

      
                return View();
        
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipocuenta)
        {


            if (!ModelState.IsValid)
            {
                return View(tipocuenta);

            }

            repositorioTiposCuentas.Crear(tipocuenta);

            return View();        
        
        }
    }
}
