using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models


{
    public class Debt
    {
        public int Id { get; set; }
        public decimal DebtAmount { get; set; }
        public decimal Amount { get; set; }
        // Debt amount
        public decimal PaidAmount { get; set; }  // Amount paid
        public decimal RemainingAmount => DebtAmount - PaidAmount; // Remaining amount
        public string Description { get; set; }  // Description of the debt
        public DateTime DueDate { get; set; }    // Due date for the debt
    }

}

