using Domain.Interfaces;
using Domain.Models;

namespace BusinessLogic.Services
{
    public class ReviewService : IReviewService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ReviewService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Review>> GetAll()
        {
            return await _repositoryWrapper.Review.FindAll();
        }

        public async Task<Review> GetById(int product_id, int customer_id)
        {
            var review = await _repositoryWrapper.Review.FindByCondition(x => x.CustomerId == customer_id & x.ProductId == product_id);

            return review.First();
        }

        public async Task<List<Review>> GetAllByProductId(int product_id)
        {
            var reviews = await _repositoryWrapper.Review.FindByCondition(x => x.ProductId == product_id);

            return reviews;
        }

        public async Task Create(Review model)
        {
            await _repositoryWrapper.Review.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Review model)
        {
            await _repositoryWrapper.Review.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int product_id, int customer_id)
        {
            var review = await _repositoryWrapper.Review.FindByCondition(x => x.CustomerId == customer_id & x.ProductId == product_id);
            _repositoryWrapper.Review.Delete(review.First());
            _repositoryWrapper.Save();
        }
    }
}
