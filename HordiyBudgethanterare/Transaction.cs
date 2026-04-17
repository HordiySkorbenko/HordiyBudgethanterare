using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HordiyBudgethanterare
{
    internal class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; } = "";
        public decimal Amount { get; set; }
        public Guid CategoryId { get; set; }
        public string Type { get; set; } = "Utgift";
    }
}
