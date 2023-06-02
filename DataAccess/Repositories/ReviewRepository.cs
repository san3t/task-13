using Domain.Interfaces;
using DataAccess.Repositories;
using DataAccess;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(eshop_dbContext repositoryContext)
            : base(repositoryContext) { }
    }
}