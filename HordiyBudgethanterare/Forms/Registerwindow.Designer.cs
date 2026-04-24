namespace HordiyBudgethanterare
{
    partial class Registerwindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            panel1 = new Panel();
            Loginbutton = new Button();
            Registerbutton = new Button();
            PasswordTextBox = new TextBox();
            Password = new Label();
            UsernameTextbox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(41, 62);
            Username.Name = "Username";
            Username.Size = new Size(110, 35);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(Loginbutton);
            panel1.Controls.Add(Registerbutton);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(UsernameTextbox);
            panel1.Controls.Add(Username);
            panel1.Location = new Point(400, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 504);
            panel1.TabIndex = 0;
            // 
            // Loginbutton
            // 
            Loginbutton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.Location = new Point(322, 330);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(250, 65);
            Loginbutton.TabIndex = 4;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            // 
            // Registerbutton
            // 
            Registerbutton.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbutton.Location = new Point(41, 330);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(250, 65);
            Registerbutton.TabIndex = 3;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(41, 222);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(531, 51);
            PasswordTextBox.TabIndex = 2;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(41, 184);
            Password.Name = "Password";
            Password.Size = new Size(107, 35);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(41, 100);
            UsernameTextbox.Multiline = true;
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(531, 51);
            UsernameTextbox.TabIndex = 2;
            // 
            // Registerwindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1317, 788);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1333, 827);
            Name = "Registerwindow";
            Text = "Registerwindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Panel panel1;
        private TextBox UsernameTextbox;
        private TextBox PasswordTextBox;
        private Label Password;
        private Button Loginbutton;
        private Button Registerbutton;
    }
}