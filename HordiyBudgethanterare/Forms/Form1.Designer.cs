namespace HordiyBudgethanterare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SidebarPanel = new FlowLayoutPanel();
            panel5 = new Panel();
            CalenderOwerviewButton = new Button();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            TransactionsButton = new Button();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            StatisticsButton = new Button();
            pictureBox3 = new PictureBox();
            AccountsPanel = new FlowLayoutPanel();
            panel7 = new Panel();
            AccountsButton = new Button();
            pictureBox4 = new PictureBox();
            panel8 = new Panel();
            CashButton = new Button();
            panel2 = new Panel();
            BankAccountButton = new Button();
            panel3 = new Panel();
            label1 = new Label();
            SideMenuButton = new PictureBox();
            AccountsTransition = new System.Windows.Forms.Timer(components);
            SideBarTransition = new System.Windows.Forms.Timer(components);
            PanelChildForms = new Panel();
            SidebarPanel.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            AccountsPanel.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SideMenuButton).BeginInit();
            SuspendLayout();
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.DarkSeaGreen;
            SidebarPanel.Controls.Add(panel5);
            SidebarPanel.Controls.Add(panel4);
            SidebarPanel.Controls.Add(panel6);
            SidebarPanel.Controls.Add(AccountsPanel);
            SidebarPanel.Location = new Point(0, 51);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(279, 737);
            SidebarPanel.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(CalenderOwerviewButton);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 70);
            panel5.TabIndex = 5;
            // 
            // CalenderOwerviewButton
            // 
            CalenderOwerviewButton.Anchor = AnchorStyles.None;
            CalenderOwerviewButton.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalenderOwerviewButton.Image = Properties.Resources.icons8_budget_30;
            CalenderOwerviewButton.ImageAlign = ContentAlignment.MiddleLeft;
            CalenderOwerviewButton.Location = new Point(0, 0);
            CalenderOwerviewButton.Margin = new Padding(0);
            CalenderOwerviewButton.Name = "CalenderOwerviewButton";
            CalenderOwerviewButton.Padding = new Padding(25, 0, 0, 0);
            CalenderOwerviewButton.RightToLeft = RightToLeft.No;
            CalenderOwerviewButton.Size = new Size(266, 70);
            CalenderOwerviewButton.TabIndex = 0;
            CalenderOwerviewButton.Text = "Calender Overview";
            CalenderOwerviewButton.UseVisualStyleBackColor = true;
            CalenderOwerviewButton.Click += CalenderOwerviewButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSeaGreen;
            pictureBox1.Image = Properties.Resources.icons8_budget_30;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(TransactionsButton);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(3, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 70);
            panel4.TabIndex = 5;
            // 
            // TransactionsButton
            // 
            TransactionsButton.Dock = DockStyle.Fill;
            TransactionsButton.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionsButton.Image = (Image)resources.GetObject("TransactionsButton.Image");
            TransactionsButton.ImageAlign = ContentAlignment.MiddleLeft;
            TransactionsButton.Location = new Point(0, 0);
            TransactionsButton.Name = "TransactionsButton";
            TransactionsButton.Padding = new Padding(25, 0, 0, 0);
            TransactionsButton.RightToLeft = RightToLeft.No;
            TransactionsButton.Size = new Size(266, 70);
            TransactionsButton.TabIndex = 0;
            TransactionsButton.Text = "Transactions";
            TransactionsButton.UseMnemonic = false;
            TransactionsButton.UseVisualStyleBackColor = true;
            TransactionsButton.Click += TransactionsButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkSeaGreen;
            pictureBox2.Image = Properties.Resources.icons8_transaction_50;
            pictureBox2.Location = new Point(0, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(StatisticsButton);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(3, 155);
            panel6.Name = "panel6";
            panel6.Size = new Size(266, 70);
            panel6.TabIndex = 5;
            // 
            // StatisticsButton
            // 
            StatisticsButton.Dock = DockStyle.Fill;
            StatisticsButton.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatisticsButton.Image = Properties.Resources.icons8_statistics_30;
            StatisticsButton.ImageAlign = ContentAlignment.MiddleLeft;
            StatisticsButton.Location = new Point(0, 0);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Padding = new Padding(25, 0, 0, 0);
            StatisticsButton.RightToLeft = RightToLeft.No;
            StatisticsButton.Size = new Size(266, 70);
            StatisticsButton.TabIndex = 0;
            StatisticsButton.Text = "Statistics";
            StatisticsButton.UseVisualStyleBackColor = true;
            StatisticsButton.Click += StatisticsButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkSeaGreen;
            pictureBox3.Image = Properties.Resources.icons8_statistics_30;
            pictureBox3.Location = new Point(0, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 73);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // AccountsPanel
            // 
            AccountsPanel.BackColor = Color.DarkSeaGreen;
            AccountsPanel.Controls.Add(panel7);
            AccountsPanel.Controls.Add(panel8);
            AccountsPanel.Controls.Add(panel2);
            AccountsPanel.FlowDirection = FlowDirection.TopDown;
            AccountsPanel.Location = new Point(0, 228);
            AccountsPanel.Margin = new Padding(0);
            AccountsPanel.Name = "AccountsPanel";
            AccountsPanel.Size = new Size(273, 80);
            AccountsPanel.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(AccountsButton);
            panel7.Controls.Add(pictureBox4);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 70);
            panel7.TabIndex = 5;
            // 
            // AccountsButton
            // 
            AccountsButton.Dock = DockStyle.Fill;
            AccountsButton.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountsButton.Image = Properties.Resources.icons8_accounts_32;
            AccountsButton.ImageAlign = ContentAlignment.MiddleLeft;
            AccountsButton.Location = new Point(0, 0);
            AccountsButton.Name = "AccountsButton";
            AccountsButton.Padding = new Padding(25, 0, 0, 0);
            AccountsButton.RightToLeft = RightToLeft.No;
            AccountsButton.Size = new Size(266, 70);
            AccountsButton.TabIndex = 0;
            AccountsButton.Text = "Accounts";
            AccountsButton.UseVisualStyleBackColor = true;
            AccountsButton.Click += AccountsButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkSeaGreen;
            pictureBox4.Image = Properties.Resources.icons8_accounts_32;
            pictureBox4.Location = new Point(-3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 73);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(CashButton);
            panel8.Location = new Point(275, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(266, 70);
            panel8.TabIndex = 5;
            // 
            // CashButton
            // 
            CashButton.Dock = DockStyle.Fill;
            CashButton.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashButton.Image = Properties.Resources.icons8_sphere_24;
            CashButton.ImageAlign = ContentAlignment.MiddleLeft;
            CashButton.Location = new Point(0, 0);
            CashButton.Name = "CashButton";
            CashButton.Padding = new Padding(25, 0, 0, 0);
            CashButton.RightToLeft = RightToLeft.No;
            CashButton.Size = new Size(266, 70);
            CashButton.TabIndex = 0;
            CashButton.Text = "Cash";
            CashButton.UseVisualStyleBackColor = true;
            CashButton.Click += CashButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(BankAccountButton);
            panel2.Location = new Point(547, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 70);
            panel2.TabIndex = 5;
            // 
            // BankAccountButton
            // 
            BankAccountButton.AutoSize = true;
            BankAccountButton.Dock = DockStyle.Fill;
            BankAccountButton.Font = new Font("Castellar", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BankAccountButton.Image = Properties.Resources.icons8_sphere_24;
            BankAccountButton.ImageAlign = ContentAlignment.MiddleLeft;
            BankAccountButton.Location = new Point(0, 0);
            BankAccountButton.Name = "BankAccountButton";
            BankAccountButton.Padding = new Padding(25, 0, 0, 0);
            BankAccountButton.RightToLeft = RightToLeft.No;
            BankAccountButton.Size = new Size(266, 70);
            BankAccountButton.TabIndex = 0;
            BankAccountButton.Text = "Bank Account";
            BankAccountButton.UseVisualStyleBackColor = true;
            BankAccountButton.Click += BankAccountButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(SideMenuButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1317, 50);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 28);
            label1.TabIndex = 8;
            label1.Text = "Smart Budget Hanterare";
            // 
            // SideMenuButton
            // 
            SideMenuButton.BackColor = Color.DarkSeaGreen;
            SideMenuButton.Dock = DockStyle.Left;
            SideMenuButton.Image = Properties.Resources.icons8_menu_48;
            SideMenuButton.Location = new Point(0, 0);
            SideMenuButton.Name = "SideMenuButton";
            SideMenuButton.Size = new Size(65, 50);
            SideMenuButton.SizeMode = PictureBoxSizeMode.CenterImage;
            SideMenuButton.TabIndex = 7;
            SideMenuButton.TabStop = false;
            SideMenuButton.Click += SideMenuButton_Click;
            // 
            // AccountsTransition
            // 
            AccountsTransition.Interval = 5;
            AccountsTransition.Tick += AccountsTransition_Tick;
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 1;
            SideBarTransition.Tick += SideBarTransition_Tick;
            // 
            // PanelChildForms
            // 
            PanelChildForms.Location = new Point(278, 51);
            PanelChildForms.Name = "PanelChildForms";
            PanelChildForms.Size = new Size(1039, 737);
            PanelChildForms.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 788);
            Controls.Add(PanelChildForms);
            Controls.Add(panel3);
            Controls.Add(SidebarPanel);
            IsMdiContainer = true;
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "Form1";
            SidebarPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            AccountsPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SideMenuButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel SidebarPanel;
        private Panel panel2;
        private Button BankAccountButton;
        private Panel panel3;
        private PictureBox SideMenuButton;
        private Label label1;
        private Panel panel4;
        private Button TransactionsButton;
        private Panel panel5;
        private Button CalenderOwerviewButton;
        private Panel panel6;
        private Button StatisticsButton;
        private FlowLayoutPanel AccountsPanel;
        private Panel panel7;
        private Button AccountsButton;
        private Panel panel8;
        private Button CashButton;
        private System.Windows.Forms.Timer AccountsTransition;
        private System.Windows.Forms.Timer SideBarTransition;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel PanelChildForms;
    }
}
