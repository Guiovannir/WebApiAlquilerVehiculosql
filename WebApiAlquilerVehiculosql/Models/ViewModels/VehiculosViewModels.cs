using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApiAlquilerVehiculosql.Models;

namespace WebApiAlquilerVehiculosql.Models.ViewModels
{
    public class VehiculosViewModels
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public double Precio { get; set; }
    }
}