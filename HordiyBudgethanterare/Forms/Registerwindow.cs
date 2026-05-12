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
    public partial class Registerwindow : Form
    {
        public Registerwindow()
        {
            InitializeComponent();
        }

        

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fyll i användarnamn och lösenord.");
                return;
            }

        }
    }
}
