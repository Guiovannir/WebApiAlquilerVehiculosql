using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAlquilerVehiculosql.Models;

namespace WebApiAlquilerVehiculosql.Models.ViewModels
{
    public class VehiculoMetodos
    {
        private DBALQUILERVEHICULOSEntities Db = new DBALQUILERVEHICULOSEntities();
        /// <summary>
        /// Carga la lista de todos los vehiculos
        /// </summary>
        /// <returns>Vehiculos</returns>
        public List<VehiculosViewModels> CargaListaVehiculos()
        {
            try
            {  
                List<VehiculosViewModels> listaVehiculos;
                listaVehiculos = (from d in Db.Vehiculos
                                  select new VehiculosViewModels
                                  {
                                      Id = d.Id,
                                      Marca = d.Marca,
                                      Modelo = d.Modelo,
                                      Precio = d.Precio
                                  }).ToList();
                return (listaVehiculos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Consulta un vehiculo por criterio de busqueda
        /// </summary>
        /// <param name="model">model=>model.Id</param>
        /// <returns>Un vehiculo</returns>
        public List<VehiculosViewModels> ConsultarVehiculos(string consulta)
        {
            try
            {                
                List<VehiculosViewModels> listaVehiculos;
                listaVehiculos = (from d in Db.Vehiculos
                                  where d.Marca.Contains(consulta)
                                  orderby d.Modelo
                                  select new VehiculosViewModels
                                  {
                                      Id = d.Id,
                                      Marca = d.Marca,
                                      Modelo = d.Modelo,
                                      Precio = d.Precio
                                  }).ToList();
                return (listaVehiculos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Crea un vehiculo en la base de datos
        /// </summary>
        /// <param name="model">model</param>
        /// <returns>True o False</returns>
        public bool CrearVehiculo(VehiculosViewModels model)
        {
            try
            {
                var oNuevoVehiculo = new Vehiculos();
                oNuevoVehiculo.Marca = model.Marca;
                oNuevoVehiculo.Modelo = model.Modelo;
                oNuevoVehiculo.Precio = model.Precio;
                Db.Vehiculos.Add(oNuevoVehiculo);
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }       
        
        /// <summary>
        /// Edita los datos de un vehiculo
        /// </summary>
        /// <param name="model">Id del vehiculo</param>
        /// <returns>model</returns>
        public bool EditarVehiculo(VehiculosViewModels model)
        {
            try
            {
                var oEditarVehiculo = Db.Vehiculos.Find(model.Id);
                oEditarVehiculo.Id = model.Id;
                oEditarVehiculo.Marca = model.Marca;
                oEditarVehiculo.Modelo = model.Modelo;
                oEditarVehiculo.Precio = model.Precio;
                Db.Entry(oEditarVehiculo).State = System.Data.Entity.EntityState.Modified;
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Elimina un vehiculo por el Id del vehiculo
        /// </summary>
        /// <param name="id">Id del vehiculo</param>
        /// <returns>True o False</returns>
        public bool EliminarVehiculo(int id)
        {
            try
            {
                var oEliminarVehiculo = Db.Vehiculos.Find(id);
                Db.Vehiculos.Remove(oEliminarVehiculo);
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