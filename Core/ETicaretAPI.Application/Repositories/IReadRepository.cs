﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddAsync(List<T>entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> Remove(T entity);
        Task<bool> Remove(string id);

    }
}
