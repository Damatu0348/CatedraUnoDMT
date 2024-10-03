using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.Models
{
    public class User
    {
        public int Id { get; set; }
        [StringLength(12, MinimumLength = 9)]
        public string Rut { get; set; } = string.Empty;
        [StringLength(100, MinimumLength = 3)]
        public string Nombre { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Correo electrónico inválido.")]
        public string Correo { get; set; } = string.Empty;
        [RegularExpression(@"Masculino|Femenino|Otro|Prefiero no decirlo")]
        public string Genero { get; set; } = string.Empty;
         [DataType(DataType.Date)]
        [CustomValidation(typeof(User), "ValidateBirthDate")]
        public string FechaNacimiento { get; set; } = string.Empty;

        
    }
}