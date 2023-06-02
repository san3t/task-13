﻿using Domain.Interfaces;

namespace Domain.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        IReviewRepository Review { get; }

        Task Save();
    }
}
