using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiAlquilerVehiculosql.Models.ViewModels
{
    public class AlquilerViewModels
    {
        public int Id { get; set; }
        [Required]
        public string LugarRecogida { get; set; }
        [Required]
        public System.DateTime FechaRecogida { get; set; }
        [Required]
        public string LugarEntrega { get; set; }
        [Required]
        public System.DateTime FechaEntrega { get; set; }
        [Required]
        public int IdVehiculo { get; set; }
    }
}