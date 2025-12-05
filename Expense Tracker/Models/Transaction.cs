using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using Expense_Tracker.Models;  // <-- make sure this is here

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        private static readonly CultureInfo MxCulture = new CultureInfo("es-MX");
        
        [Key]
        public int TransactionId { get; set; }

        // --- UPDATED USER ID PROPERTIES ---
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
        // ----------------------------------

        [Range(1, int.MaxValue, ErrorMessage = "Por favor seleccione una categoría.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El monto debe ser mayor a 0.")]
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category == null ? "" : Category.Icon + " " + Category.Title;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "- " : "+ ") + Amount.ToString("C0", MxCulture);
            }
        }
    }
}
