using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiAlquilerVehiculosql.Models.ViewModels;

namespace WebApiAlquilerVehiculosql.Controllers
{
    public class AlquilerController : ApiController
    {
        // GET: api/AlquilerVehiculos
        [ResponseType(typeof(AlquilerViewModels))]
        public IHttpActionResult GetAlquilerViewModels()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            List<AlquilerViewModels> listaVehiculos = null;
            AlquilerVehiculosMetodos alquilados = new AlquilerVehiculosMetodos();
            listaVehiculos = alquilados.CargaListaAlquilados();
            if (listaVehiculos.Count > 0)
            {
                return Ok(listaVehiculos);
            }
            return NotFound();
        }
        // GET: api/AlquilerVehiculos
        [ResponseType(typeof(AlquilerViewModels))]
        public IHttpActionResult GetAlquilerViewModels(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            AlquilerViewModels alquilado = new AlquilerViewModels();
            AlquilerVehiculosMetodos alquiler = new AlquilerVehiculosMetodos();
            alquilado = alquiler.ConsultarAlquiler(id);
            return Ok(alquilado);
        }
        // POST: api/AlquilerVehiculos
        [ResponseType(typeof(AlquilerViewModels))]
        public IHttpActionResult PostAlquilerViewModels(AlquilerViewModels model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            AlquilerVehiculosMetodos alquilar = new AlquilerVehiculosMetodos();
            alquilar.CrearAlquiler(model);
            return Ok();
        }
    }
}
