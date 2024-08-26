using BookApi.Data;
using BookApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetBooksSortedByPublisherAuthorTitleAsync()
        {
            return await _context.Books
                .FromSqlRaw("EXEC GetBooksSortedByPublisherAuthorTitle")
                .ToListAsync();
        }

        public async Task<decimal> GetTotalPriceAsync()
        {
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC GetTotalPrice");

            return result;
        }

        public async Task<IEnumerable<Book>> GetBooksSortedByAuthorTitleAsync()
        {
            return await _context.Books
                .OrderBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task SaveBooksAsync(IEnumerable<Book> books)
        {
            await _context.Books.AddRangeAsync(books);
            await _context.SaveChangesAsync();
        }
    }
}
