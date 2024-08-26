
using BookApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApi.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooksSortedByPublisherAuthorTitleAsync();
        Task<IEnumerable<Book>> GetBooksSortedByAuthorTitleAsync();
        Task<decimal> GetTotalPriceAsync();
        Task SaveBooksAsync(IEnumerable<Book> books);
    }
}
