using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.Dtos
{
    public class UpdateUserRequestDto
    {

        public string Rut { get; set; } = string.Empty;

        public string Nombre { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public string Genero { get; set; } = string.Empty;

        public string FechaNacimiento { get; set; } = string.Empty;
    }
}