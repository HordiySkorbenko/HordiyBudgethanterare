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
            DateButtonPrev = new Button();
            DateButtonNext = new Button();
            panel1 = new Panel();
            labelDate = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DateButtonPrev
            // 
            DateButtonPrev.BackColor = Color.Transparent;
            DateButtonPrev.Cursor = Cursors.Hand;
            DateButtonPrev.FlatAppearance.BorderSize = 0;
            DateButtonPrev.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            DateButtonPrev.FlatStyle = FlatStyle.Flat;
            DateButtonPrev.ForeColor = Color.Gray;
            DateButtonPrev.Location = new Point(241, 25);
            DateButtonPrev.Name = "DateButtonPrev";
            DateButtonPrev.Size = new Size(50, 50);
            DateButtonPrev.TabIndex = 1;
            DateButtonPrev.Text = "◀ ";
            DateButtonPrev.UseVisualStyleBackColor = false;
            DateButtonPrev.Click += DateButtonPrev_Click;
            // 
            // DateButtonNext
            // 
            DateButtonNext.BackColor = Color.Transparent;
            DateButtonNext.Cursor = Cursors.Hand;
            DateButtonNext.FlatAppearance.BorderSize = 0;
            DateButtonNext.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            DateButtonNext.FlatStyle = FlatStyle.Flat;
            DateButtonNext.ForeColor = Color.Gray;
            DateButtonNext.Location = new Point(493, 25);
            DateButtonNext.Name = "DateButtonNext";
            DateButtonNext.Size = new Size(50, 50);
            DateButtonNext.TabIndex = 2;
            DateButtonNext.Text = "▶ ";
            DateButtonNext.UseVisualStyleBackColor = false;
            DateButtonNext.Click += DateButtonNext_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DateButtonPrev);
            panel1.Controls.Add(DateButtonNext);
            panel1.Controls.Add(labelDate);
            panel1.Location = new Point(498, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 100);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // labelDate
            // 
            labelDate.BackColor = Color.Violet;
            labelDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(249, 1);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(294, 98);
            labelDate.TabIndex = 0;
            labelDate.Text = "BLANK";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(0, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(267, 737);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(353, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(66, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1317, 50);
            panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.icons8_menu_48;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 18);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 8;
            label1.Text = "Smart Budget hanterare";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 788);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button DateButtonNext;
        private Panel panel1;
        public Button DateButtonPrev;
        private Label labelDate;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
