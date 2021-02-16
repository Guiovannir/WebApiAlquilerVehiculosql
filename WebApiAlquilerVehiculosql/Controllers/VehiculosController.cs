using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAlquilerVehiculosql.Models;
using WebApiAlquilerVehiculosql.Models.ViewModels;

namespace WebApiAlquilerVehiculosql.Controllers
{
    public class VehiculosController : ApiController
    {
        private DBALQUILERVEHICULOSEntities db = new DBALQUILERVEHICULOSEntities();

        // GET: api/Vehiculos
        [ResponseType(typeof(VehiculosViewModels))]
        public IHttpActionResult GetVehiculos()
        {            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);         
            }
            List<VehiculosViewModels> listaVehiculos = null;
            VehiculoMetodos vehiculos = new VehiculoMetodos();
            listaVehiculos = vehiculos.CargaListaVehiculos();
            if (listaVehiculos.Count > 0)
            {
                return Ok(listaVehiculos);
            }
            return NotFound();
        }

        // GET: api/Vehiculos
        [ResponseType(typeof(Vehiculos))]
        public IHttpActionResult GetVehiculos(string consulta)
        {                   
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            VehiculoMetodos vehiculos = new VehiculoMetodos();
            List<VehiculosViewModels> listaVehiculos;
            listaVehiculos = vehiculos.ConsultarVehiculos(consulta);
            if (listaVehiculos.Count > 0)
            {
                return Ok(listaVehiculos);
            }
            return NotFound();
        }
        // POST: api/Vehiculos
        [ResponseType(typeof(VehiculosViewModels))]
        public IHttpActionResult PostVehiculos(VehiculosViewModels model) {            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            VehiculoMetodos vehiculos = new VehiculoMetodos();
            vehiculos.CrearVehiculo(model);
            return Ok();                        
        }

    }
}