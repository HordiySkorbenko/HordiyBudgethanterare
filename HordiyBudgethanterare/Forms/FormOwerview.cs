using HordiyBudgethanterare.Models;
using HordiyBudgethanterare.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HordiyBudgethanterare
{
    public partial class FormOwerview : Form
    {
        private DateTime startmonth;
        private int visible_month = 6;
        private readonly AuthService authservice = new AuthService();
        private BudgetData Budget => SessionManager.CurrentUser!.Budget;

        public FormOwerview()
        {
            InitializeComponent();
            startmonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        }

        // funktionen skapar en lista med 6 stycken objekt av Datetime från den första månaden i tabellen
        private List<DateTime> GetVisibleMonths()
        {
            var list = new List<DateTime>();
            for (int i = 0; i < visible_month; i++)
                list.Add(startmonth.AddMonths(i));
            return list;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            startmonth = startmonth.AddMonths(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            startmonth = startmonth.AddMonths(1);
        }
    }
}
