using System;

namespace WebApplication1.Models
{
    public class Purchase
    {
        /// <summary>
        /// ID покупки
        /// </summary>
        public int PurchaseId { get; set; }
        /// <summary>
        /// ім'я й прізвище покупця
        /// </summary>
        public string Person { get; set; }
        /// <summary>
        /// адреса покупця
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// ID книги
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// дата покупки
        /// </summary>
        public DateTime Date { get; set; }
    }
}
