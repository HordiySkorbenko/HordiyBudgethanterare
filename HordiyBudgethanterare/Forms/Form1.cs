namespace HordiyBudgethanterare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime currentDate;


        private void Form1_Load(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            var raw = currentDate.ToString("MMMM yyyy", new System.Globalization.CultureInfo("sv-SE"));
            labelDate.Text = char.ToUpper(raw[0]) + raw[1..];
        }

        private void DateButtonPrev_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            UpdateLabel();
        }

        private void DateButtonNext_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            UpdateLabel();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
