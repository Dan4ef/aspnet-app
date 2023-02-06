namespace WebApplication1.Models
{
    public class Book
    {
        /// <summary>
        /// ID книги
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// назва книги
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// автор книги
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// цiна
        /// </summary>
        public int Price { get; set; }
    }
}
