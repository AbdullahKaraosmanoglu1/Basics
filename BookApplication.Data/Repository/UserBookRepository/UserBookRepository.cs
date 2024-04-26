﻿using BookApplication.Data.Entity;
using System.Linq.Expressions;

namespace BookApplication.Data.Repository.UserBookRepository
{
    public class UserBookRepository : IUserBookRepository
    {
        private readonly IUserBookRepository _userBookRepository;

        public UserBookRepository(IUserBookRepository userBookRepository)
        {
            _userBookRepository = userBookRepository;
        }

        public async Task<UserBook> CreateAsync(UserBook entity)
        {
            return await _userBookRepository.CreateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _userBookRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserBook>> GetAllAsync()
        {
            return await _userBookRepository.GetAllAsync();
        }

        public async Task<UserBook> GetByIdAsync(int id)
        {
            return await _userBookRepository.GetByIdAsync(id);
        }

        public Task<UserBook> GetByIdAsync(Expression<Func<UserBook, bool>> expression, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await _userBookRepository.SaveAsync();
        }

        public async Task<UserBook> UpdateAsync(UserBook entity)
        {
            return await _userBookRepository.UpdateAsync(entity);
        }
    }
}