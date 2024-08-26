using System.ComponentModel.DataAnnotations.Schema;

namespace BookApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public decimal Price { get; set; }

        public string MlaCitation
        {
            get
            {
                return $"{AuthorLastName}, {AuthorFirstName}. *{Title}*. {Publisher}, 2024.";
            }
        }

        public string ChicagoCitation
        {
            get
            {
                return $"{AuthorLastName}, {AuthorFirstName}. *{Title}*. {Publisher}, 2024.";
            }
        }
    }

}
