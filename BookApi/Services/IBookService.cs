namespace BookApi.Services
{
    using BookApi.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBookService
    {
        Task<IEnumerable<Book>> GetBooksSortedByPublisherAuthorTitleAsync();
        Task<IEnumerable<Book>> GetBooksSortedByAuthorTitleAsync();
        Task<decimal> GetTotalPriceAsync();
        Task SaveBooksAsync(IEnumerable<Book> books);
    }
}
