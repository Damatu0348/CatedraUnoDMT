using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Data;
using api.src.Interface;
using api.src.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.src.Dtos;
using api.src.Mappers;

namespace api.src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
         public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }
         [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserRequestDto userDto)
        {
            var userModel = userDto.ToUserFromCreateDto();
            await _userRepository.Post(userModel);
            return CreatedAtAction(nameof(GetById), new {id = userModel.Id}, userModel.ToUserDto());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutId([FromRoute] int id, [FromBody] UpdateUserRequestDto updateDto)
        {
            var userModel = await _userRepository.Put(id, updateDto);
            if(userModel == null)
            {
                return NotFound();
            }
            userModel.Name = updateDto.Nombre;

            return Ok(userModel.ToProductDto());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var user = await _userRepository.Delete(id);
            if(user == null)
            {
                return NotFound();
            }
            return NoContent();
        }
        

        
    }
}