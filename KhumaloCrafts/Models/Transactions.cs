using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KhumaloCrafts.Models
{
    public class Transactions
    {
        public int TransactionsId { get; set; }
        [ForeignKey("Products")]

        public int ProductsId { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }
        [DataType(DataType.Date)]
        public DateTime TranscationDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime TranscationTime { get; }

        public Products Products { get; set; }
    }
}

