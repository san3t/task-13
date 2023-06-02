using Domain.Models;

namespace Domain.Interfaces
{
    public interface IReviewService
    {
        Task<List<Review>> GetAll();
        Task<Review> GetById(int product_id, int customer_id);
        Task<List<Review>> GetAllByProductId(int product_id);
        Task Create(Review model);
        Task Update(Review model);
        Task Delete(int product_id, int customer_id);
    }
}