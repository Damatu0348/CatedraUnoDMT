using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.src.Data;
using api.src.Interface;
using api.src.Models;
using Microsoft.EntityFrameworkCore;

namespace api.src.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;
        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<User?> Delete(int id)
        {
            var productModel = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if(productModel == null)
            {
                throw new Exception("Product NOT found");
            }
            _context.Users.Remove(productModel);
            await _context.SaveChangesAsync();
            return productModel;
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetById(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> Post(User product)
        {
            await _context.Users.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<User?> Put(int id, UpdateUserRequestDto productDto)
        {
            var userModel = await _context.User.FirstOrDefaultAsync(x => x.Id == id);
            if(productModel == null)
            {
                throw new Exception("Product NOT found");
            }
            userModel.Name = productDto.Name;
            userModel.Price = productDto.Price;
            await _context.SaveChangesAsync();
            return userModel;
        }
    }
}