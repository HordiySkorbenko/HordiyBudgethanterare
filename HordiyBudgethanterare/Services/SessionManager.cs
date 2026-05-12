using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HordiyBudgethanterare.Models
{
    internal static class SessionManager
    {
        public static User? CurrentUser { get; set; }
    }
}
