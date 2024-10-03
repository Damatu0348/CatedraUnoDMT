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
        public string Name { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Correo electrónico inválido.")]
        public string Email { get; set; } = string.Empty;
        [RegularExpression(@"Masculino|Femenino|Otro|Prefiero no decirlo")]
        public string Gender { get; set; } = string.Empty;
         [DataType(DataType.Date)]
        [CustomValidation(typeof(User), "ValidateBirthDate")]
        public string BirthDate { get; set; } = string.Empty;

        public static ValidationResult? ValidateBirthDate(DateTime birthDate, ValidationContext context)
        {
            return birthDate < DateTime.Now
                ? ValidationResult.Success
                : new ValidationResult("La fecha de nacimiento debe ser menor a la fecha actual.");
        }
    }
}