//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiAlquilerVehiculosql.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlquilerVehiculos
    {
        public int Id { get; set; }
        public string LugarRecogida { get; set; }
        public System.DateTime FechaRecogida { get; set; }
        public string LugarEntrega { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public int IdVehiculo { get; set; }
    }
}