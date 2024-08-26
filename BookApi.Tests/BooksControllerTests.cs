using BookApi.Controllers;
using BookApi.Models;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BookApi.Tests
{
    public class BooksControllerTests
    {
        private readonly Mock<IBookService> _mockBookService;
        private readonly BooksController _controller;

        public BooksControllerTests()
        {
            _mockBookService = new Mock<IBookService>();
            _controller = new BooksController(_mockBookService.Object);
        }

        [Fact]
        public async Task GetBooksSortedByPublisherAuthorTitle_ReturnsOkResult()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book { Publisher = "A", AuthorLastName = "Smith", AuthorFirstName = "John", Title = "Book A", Price = 10 }
            };
            _mockBookService.Setup(service => service.GetBooksSortedByPublisherAuthorTitleAsync())
                .ReturnsAsync(books);

            // Act
            var result = await _controller.GetBooksSortedByPublisherAuthorTitle();

            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Book>>>(result);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var returnBooks = Assert.IsType<List<Book>>(okResult.Value);
            Assert.Single(returnBooks);
        }

        [Fact]
        public async Task GetTotalPrice_ReturnsTotalPrice()
        {
            // Arrange
            var totalPrice = 25m;
            _mockBookService.Setup(service => service.GetTotalPriceAsync())
                .ReturnsAsync(totalPrice);

            // Act
            var result = await _controller.GetTotalPrice();

            // Assert
            var actionResult = Assert.IsType<ActionResult<decimal>>(result);
            var okResult = Assert.IsType<OkObjectResult>(actionResult.Result);
            var returnTotalPrice = Assert.IsType<decimal>(okResult.Value);
            Assert.Equal(totalPrice, returnTotalPrice);
        }
    }
}
