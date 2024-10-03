using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Dtos;
using api.src.Models;

namespace api.src.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                Nombre = userModel.Nombre,
                Correo = userModel.Correo,
                Genero = userModel.Genero,
                FechaNacimiento = userModel.FechaNacimiento     

                
            };
        }
        public static User ToUserFromCreateDto(this CreateUserRequestDto createUserRequestDto)
        {
            return new User
            {
                Nombre = createUserRequestDto.Nombre,
                Correo = createUserRequestDto.Correo,
                Genero = createUserRequestDto.Genero,
                FechaNacimiento = createUserRequestDto.FechaNacimiento                
            };

        }
    }
}