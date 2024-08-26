namespace BookApi.Services
{
    using BookApi.Data;
    using BookApi.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BookService : IBookService
    {
        private readonly BookContext _context;

        public BookService(BookContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetBooksSortedByPublisherAuthorTitleAsync()
        {
            return await _context.Books
                .OrderBy(b => b.Publisher)
                .ThenBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksSortedByAuthorTitleAsync()
        {
            return await _context.Books
                .OrderBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task<decimal> GetTotalPriceAsync()
        {
            return await _context.Books.SumAsync(b => b.Price);
        }

        public async Task SaveBooksAsync(IEnumerable<Book> books)
        {
            await _context.Books.AddRangeAsync(books);
            await _context.SaveChangesAsync();
        }
    }
}
