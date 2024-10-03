using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api.src.Dtos
{
    public class CreateUserRequestDto
    {
        public int Id {get; set;}
         [StringLength(12, MinimumLength = 9)]
        public string Rut { get; set; } = string.Empty;
        [StringLength(100, MinimumLength = 3)]
        public string Nombre { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Correo electrónico inválido.")]
        public string Correo { get; set; } = string.Empty;
        [RegularExpression(@"Masculino|Femenino|Otro|Prefiero no decirlo")]
        public string Genero { get; set; } = string.Empty;
        public string FechaNacimiento { get; set; } = string.Empty;
    }
}