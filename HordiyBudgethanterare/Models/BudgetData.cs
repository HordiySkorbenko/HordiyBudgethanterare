using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HordiyBudgethanterare.Models
{
    public class BudgetCategory
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "";
        public bool IsFixed { get; set; } = false;
        public Dictionary<string, decimal?> MonthlyAmounts { get; set; } = new();
    }
    public class BudgetData
    {
        public List<BudgetCategory> Categories { get; set; } = new();
        public Dictionary<string, decimal?> MonthlyIncome { get; set; } = new();
    }

}
