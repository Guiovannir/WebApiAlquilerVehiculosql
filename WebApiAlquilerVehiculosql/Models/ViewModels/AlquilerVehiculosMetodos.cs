using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAlquilerVehiculosql.Models;

namespace WebApiAlquilerVehiculosql.Models.ViewModels
{
    public class AlquilerVehiculosMetodos
    {
        private DBALQUILERVEHICULOSEntities Db = new DBALQUILERVEHICULOSEntities();
        /// <summary>
        /// Carga la lista de todos los alquileres
        /// </summary>
        /// <returns>Alquileres</returns>
        public List<AlquilerViewModels> CargaListaAlquilados()
        {
            try
            {
                List<AlquilerViewModels> listaAlquilados;
                listaAlquilados = (from d in Db.AlquilerVehiculos
                                   select new AlquilerViewModels
                                   {
                                       Id = d.Id,
                                       LugarEntrega = d.LugarEntrega,
                                       FechaEntrega = d.FechaEntrega,
                                       LugarRecogida = d.LugarRecogida,
                                       FechaRecogida = d.FechaRecogida,
                                       IdVehiculo = d.IdVehiculo
                                   }).ToList();
                return (listaAlquilados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Carga un alquiler por el Id del alquiler
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Alquiler</returns>
        public AlquilerViewModels ConsultarAlquiler(int id)
        {
            try
            {
                AlquilerViewModels model = new AlquilerViewModels();
                var oConsultarAlquiler = Db.AlquilerVehiculos.Find(id);
                model.Id = oConsultarAlquiler.Id;
                model.LugarEntrega = oConsultarAlquiler.LugarEntrega;
                model.FechaEntrega = oConsultarAlquiler.FechaEntrega;
                model.LugarRecogida = oConsultarAlquiler.LugarRecogida;
                model.FechaRecogida = oConsultarAlquiler.FechaRecogida;
                return (model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Crea un alquiler de un vehiculo en la base de datos
        /// </summary>
        /// <param name="model">model</param>
        /// <returns>True o False</returns>
        public bool CrearAlquiler(AlquilerViewModels model)
        {
            try
            {
                var oNuevoAlquiler = new AlquilerVehiculos();
                oNuevoAlquiler.IdVehiculo = model.IdVehiculo;
                oNuevoAlquiler.LugarEntrega = model.LugarEntrega;
                oNuevoAlquiler.FechaEntrega = model.FechaEntrega;
                oNuevoAlquiler.LugarRecogida = model.LugarRecogida;
                oNuevoAlquiler.FechaRecogida = model.FechaRecogida;
                Db.AlquilerVehiculos.Add(oNuevoAlquiler);
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}