using BookApi.Data;
using BookApi.Models;
using BookApi.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BookApi.Tests
{
    public class BookServiceTests
    {
        private readonly BookService _bookService;
        private readonly DbContextOptions<BookContext> _dbContextOptions;

        public BookServiceTests()
        {
            // Configure in-memory database for testing
            _dbContextOptions = new DbContextOptionsBuilder<BookContext>()
                .UseInMemoryDatabase(databaseName: "BookDatabase")
                .Options;

            // Create a context using in-memory database
            using (var context = new BookContext(_dbContextOptions))
            {
                context.Books.AddRange(new List<Book>
                {
                    new Book { Publisher = "A", AuthorLastName = "Smith", AuthorFirstName = "John", Title = "Book A", Price = 10 },
                    new Book { Publisher = "A", AuthorLastName = "Doe", AuthorFirstName = "Jane", Title = "Book B", Price = 15 }
                });
                context.SaveChanges();
            }

            // Initialize the service with the in-memory context
            _bookService = new BookService(new BookContext(_dbContextOptions));
        }

        [Fact]
        public async Task GetBooksSortedByPublisherAuthorTitleAsync_ReturnsSortedBooks()
        {
            // Act
            var result = await _bookService.GetBooksSortedByPublisherAuthorTitleAsync();

            // Convert to List<Book> if needed
            var resultList = result.ToList();

            // Assert
            Assert.NotNull(resultList);
            Assert.IsType<List<Book>>(resultList);
            Assert.Equal(2, resultList.Count);
            Assert.Equal("Book A", resultList.First().Title);
            Assert.Equal("Book B", resultList.Last().Title);
        }

        [Fact]
        public async Task GetTotalPriceAsync_ReturnsCorrectTotalPrice()
        {
            // Act
            var result = await _bookService.GetTotalPriceAsync();

            // Assert
            Assert.Equal(25m, result);
        }
    }
}
