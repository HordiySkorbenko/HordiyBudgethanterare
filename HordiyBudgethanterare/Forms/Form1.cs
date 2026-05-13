using System.Windows.Forms;

namespace HordiyBudgethanterare
{
    public partial class Form1 : Form
    {
        FormOwerview owerview;
        formTransactions transactions;
        formStatistics statistics;
        formAccountsCard accountsCard;
        formAccountsCash accountsCash;

        public Form1()
        {
            InitializeComponent();
        }

        private bool AccountsExpand = false;
        private bool SidebarExpand = true;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountsTransition_Tick(object sender, EventArgs e)
        {
            if (AccountsExpand == false)
            {
                AccountsPanel.Height += 5;
                if (AccountsPanel.Height >= 230)
                {
                    AccountsTransition.Stop();
                    AccountsExpand = true;
                }
            }
            else
            {
                AccountsPanel.Height -= 5;
                if (AccountsPanel.Height <= 78)
                {
                    AccountsTransition.Stop();
                    AccountsExpand = false;
                }
            }
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            AccountsTransition.Start();
        }

        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                SidebarPanel.Width -= 10;
                PanelChildForms.Left -= 10;
                PanelChildForms.Width += 10;
                if (SidebarPanel.Width <= 70)
                {
                    SidebarExpand = false;
                    SideBarTransition.Stop();
                    CalenderOwerviewButton.Visible = false;
                    TransactionsButton.Visible = false;
                    AccountsButton.Visible = false;
                    StatisticsButton.Visible = false;
                    if (AccountsExpand)
                    {
                        AccountsTransition.Start();
                    }
                }
            }
            else
            {
                SidebarPanel.Width += 10;
                PanelChildForms.Left += 10;
                PanelChildForms.Width -= 10;
                if (SidebarPanel.Width >= 275)
                {
                    SidebarExpand = true;
                    SideBarTransition.Stop();
                    CalenderOwerviewButton.Visible = true;
                    TransactionsButton.Visible = true;
                    AccountsButton.Visible = true;
                    StatisticsButton.Visible = true;
                }
            }
        }

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void ShowChildForm(Form form)
        {
            foreach (Control control in PanelChildForms.Controls)
            {
                control.Hide();
            }
            form.BringToFront();
            form.Show();
        }
        private void CalenderOwerviewButton_Click(object sender, EventArgs e)
        {
            if (owerview == null)
            {
                owerview = new FormOwerview();
                owerview.TopLevel = false;
                owerview.FormBorderStyle = FormBorderStyle.None;
                owerview.Dock = DockStyle.Fill;
                PanelChildForms.Controls.Add(owerview);
                owerview.BringToFront();
                owerview.Show();

            }
            else
            {
                ShowChildForm(owerview);
            }
        }

        private void CashButton_Click(object sender, EventArgs e)
        {
            if (accountsCash == null)
            {
                accountsCash = new formAccountsCash();
                accountsCash.TopLevel = false;
                accountsCash.FormBorderStyle = FormBorderStyle.None;
                accountsCash.Dock = DockStyle.Fill;
                PanelChildForms.Controls.Add(accountsCash);
                accountsCash.BringToFront();
                accountsCash.Show();

            }
            else
            {
                ShowChildForm(accountsCash);
            }
        }



        private void BankAccountButton_Click(object sender, EventArgs e)
        {
            if (accountsCard == null)
            {
                accountsCard = new formAccountsCard();
                accountsCard.TopLevel = false;
                accountsCard.FormBorderStyle = FormBorderStyle.None;
                accountsCard.Dock = DockStyle.Fill;
                PanelChildForms.Controls.Add((accountsCard));
                accountsCard.BringToFront();
                accountsCard.Show();

            }
            else
            {
                ShowChildForm(accountsCard);
            }
        }

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            if (transactions == null)
            {
                transactions = new formTransactions();
                transactions.TopLevel = false;
                transactions.FormBorderStyle = FormBorderStyle.None;
                transactions.Dock = DockStyle.Fill;
                PanelChildForms.Controls.Add((transactions));
                transactions.BringToFront();
                transactions.Show();
            }
            else
            {
                ShowChildForm(transactions);
            }
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            if (statistics == null)
            {
                statistics = new formStatistics();
                statistics.TopLevel = false;
                statistics.FormBorderStyle = FormBorderStyle.None;
                statistics.Dock = DockStyle.Fill;
                PanelChildForms.Controls.Add((statistics));
                statistics.BringToFront();
                statistics.Show();

            }
            else
            {
                ShowChildForm(statistics);
            }
        }
    }
}
