using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using HordiyBudgethanterare.Models;

namespace HordiyBudgethanterare.Services
{
   
    internal class Datamanagment
    {
        private readonly string filePath = "budget_data.json";

        private class BudgetData
        {
            public List<Category> Categories { get; set; } = new();
            public List<Transaction> Transactions { get; set; } = new();
        }

        private BudgetData data = new();

        public List<Category> Categories => data.Categories;
        public List<Transaction> Transactions => data.Transactions;

        public void Load()
        {
            if (!File.Exists(filePath)) return;
            var json = File.ReadAllText(filePath);
            data = JsonSerializer.Deserialize<BudgetData>(json) ?? new BudgetData();
        }

    }
}
