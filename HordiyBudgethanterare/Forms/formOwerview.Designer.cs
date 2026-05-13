namespace HordiyBudgethanterare
{
    partial class FormOwerview
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
            navPanel = new Panel();
            lblRange = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            dgvFixed = new DataGridView();
            lblFastautg = new Label();
            lblLöpandeutg = new Label();
            dgvVariable = new DataGridView();
            navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFixed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVariable).BeginInit();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.DarkSeaGreen;
            navPanel.Controls.Add(lblRange);
            navPanel.Controls.Add(btnNext);
            navPanel.Controls.Add(btnPrev);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(961, 100);
            navPanel.TabIndex = 0;
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Location = new Point(443, 50);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(38, 15);
            lblRange.TabIndex = 2;
            lblRange.Text = "label1";
            lblRange.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(611, 42);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 1;
            btnNext.Text = "▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(244, 42);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "◀";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // dgvFixed
            // 
            dgvFixed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFixed.Location = new Point(108, 159);
            dgvFixed.Name = "dgvFixed";
            dgvFixed.Size = new Size(830, 49);
            dgvFixed.TabIndex = 1;
            // 
            // lblFastautg
            // 
            lblFastautg.AutoSize = true;
            lblFastautg.Location = new Point(108, 132);
            lblFastautg.Name = "lblFastautg";
            lblFastautg.Size = new Size(91, 15);
            lblFastautg.TabIndex = 3;
            lblFastautg.Text = "📌 Fasta utgifter";
            lblFastautg.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLöpandeutg
            // 
            lblLöpandeutg.AutoSize = true;
            lblLöpandeutg.Location = new Point(108, 406);
            lblLöpandeutg.Name = "lblLöpandeutg";
            lblLöpandeutg.Size = new Size(110, 15);
            lblLöpandeutg.TabIndex = 4;
            lblLöpandeutg.Text = "📋 Löpande utgifter";
            lblLöpandeutg.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvVariable
            // 
            dgvVariable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVariable.Location = new Point(108, 424);
            dgvVariable.Name = "dgvVariable";
            dgvVariable.Size = new Size(830, 49);
            dgvVariable.TabIndex = 5;
            // 
            // FormOwerview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 611);
            Controls.Add(dgvVariable);
            Controls.Add(lblLöpandeutg);
            Controls.Add(lblFastautg);
            Controls.Add(dgvFixed);
            Controls.Add(navPanel);
            Name = "FormOwerview";
            Text = "FormOwerview";
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFixed).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVariable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel navPanel;
        private Label lblRange;
        private Button btnNext;
        private Button btnPrev;
        private DataGridView dgvFixed;
        private Label lblFastautg;
        private Label lblLöpandeutg;
        private DataGridView dgvVariable;
    }
}