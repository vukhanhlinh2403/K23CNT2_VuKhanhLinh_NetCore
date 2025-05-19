using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vkllesson04.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreID { get; set; }
        public string Image { get; set; }
        public int price { get; set; }

        public int TotalPage { get; set; }
        public string Summary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book() { 
                Id =1,  
                Title = "AspNetCoreMVC",
                AuthorId = -1,
                GenreID = 1,
                Image = "/image/book-1.jpg",
                price = 120000,
                TotalPage = 100,
                Summary = ""
                },
                new Book() {
                Id=2,
                Title = "AspNetCoreMVC",
                AuthorId = -1,
                GenreID = 1,
                Image = "/image/book-1.jpg",
                price = 120000,
                TotalPage = 100,
                Summary = ""
                },
                new Book() { 
                Id=3,   
                Title = "AspNetCoreMVC",
                AuthorId = -1,
                GenreID = 1,
                Image = "/image/book-1.jpg",
                price = 120000,
                TotalPage = 100,
                Summary = ""
                },
            };
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList()
                .FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<SelectListItem> Authoers { get; } =
            new List<SelectListItem>
            {
                new SelectListItem{Value="1",Text="Nam cao"},
                new SelectListItem{Value="2",Text="ngo tat to"},
                new SelectListItem{Value="3",Text="adamkhoom"},
                new SelectListItem{Value="4",Text="Donal trump"},

            };
        public List<SelectListItem> Generes { get; }
        = new List<SelectListItem>
        {
           new SelectListItem{Value="1",Text="truyen tranh "},
           new SelectListItem{Value="2",Text="van hoc duong dai"},
           new SelectListItem{Value="3",Text="truyen cuoi"},
           new SelectListItem{Value="4",Text="phat hoc"},
        };
    }
}
