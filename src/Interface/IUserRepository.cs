using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Dtos;
using api.src.Models;

namespace api.src.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User?> GetById(int id);
        Task<User> Post(User user);
        Task<User?> Put(int id, UpdateUserRequestDto userDto);
        Task<User?> Delete(int id);
    }
}