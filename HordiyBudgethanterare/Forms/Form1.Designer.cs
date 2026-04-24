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
            labelDate = new Label();
            DateButtonPrev = new Button();
            DateButtonNext = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.BackColor = Color.Violet;
            labelDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(0, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(1315, 98);
            labelDate.TabIndex = 0;
            labelDate.Text = "BLANK";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DateButtonPrev
            // 
            DateButtonPrev.BackColor = Color.Transparent;
            DateButtonPrev.Cursor = Cursors.Hand;
            DateButtonPrev.FlatAppearance.BorderSize = 0;
            DateButtonPrev.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            DateButtonPrev.FlatStyle = FlatStyle.Flat;
            DateButtonPrev.ForeColor = Color.Gray;
            DateButtonPrev.Location = new Point(509, 25);
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
            DateButtonNext.Location = new Point(761, 25);
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 100);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1317, 688);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 788);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Button DateButtonNext;
        private Panel panel1;
        public Button DateButtonPrev;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
