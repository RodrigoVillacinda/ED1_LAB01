using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto1.Models
{
    public class Jugador
    {
        [Required(ErrorMessage = "The ID is required.")]
        public string Club { get; set; }

        [Required(ErrorMessage = "The ID is required.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        public string Nombre { get; set; }

        [Range(1, 200, ErrorMessage = "A number between 1 and 200.")]
        public int Salario { get; set; }

        [Required(ErrorMessage = "The ID is required.")]
        public string Posicion { get; set; }



    }
}