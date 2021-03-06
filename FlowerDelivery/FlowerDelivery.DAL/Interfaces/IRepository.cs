﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlowerDelivery.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {

        Task<T> Get(params Guid[] identeficators);
        Task<ICollection<T>> GetAll();
        Task Create(T value);
        Task Remove(T value);
        Task Update(T value);
    }
}
