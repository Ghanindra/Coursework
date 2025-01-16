using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Coursework.Models
{
    public class AppData

    {

        public List<User> Users { get; set; } = new();

        public List<Debt> Debts { get; set; } = new();

        public List<Transaction> Transactions { get; set; } = new();
        public decimal TotalBalance { get; set; } = 0;

    }
}
