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
    public partial class Registerwindow : Form
    {
        private readonly AuthService _authService = new AuthService();
        public Registerwindow()
        {
            InitializeComponent();
        }

        private async void Loginbutton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fyll i användarnamn och lösenord.");
                return;
            }
            Loginbutton.Enabled = false;
            Loginbutton.Text = "Loggar in...";

            try
            {
                User? user = await _authService.Login(username, password);

                if (user == null)
                {
                    MessageBox.Show("Felaktigt användarnamn eller lösenord.", "Inloggning misslyckades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SessionManager.CurrentUser = user;
                    var mainForm = new Form1();
                    mainForm.Show();
                    this.Hide();
                    mainForm.FormClosed += (s, args) => this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte ansluta till servern: {ex.Message}", "Nätverksfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Loginbutton.Enabled = true;
                Loginbutton.Text = "Login";
            }
        }

        private async void Registerbutton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text.Trim();
            string password = PasswordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fyll i användarnamn och lösenord.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 4)
            {
                MessageBox.Show("Lösenordet måste vara minst 4 tecken.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Registerbutton.Enabled = false;
            Registerbutton.Text = "Registrerar...";

            try
            {
                bool success = await _authService.Register(username, password);

                if (!success)
                {
                    MessageBox.Show("Användarnamnet är redan taget. Välj ett annat.", "Registrering misslyckades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Kontot '{username}' skapades! Du kan nu logga in.", "Registrering lyckades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte ansluta till servern: {ex.Message}", "Nätverksfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Registerbutton.Enabled = true;
                Registerbutton.Text = "Register";
            }
        }
    }    
}

