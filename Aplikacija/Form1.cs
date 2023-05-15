namespace Aplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            => MessageBox.Show(DateTime.Now.ToString(), "TIME");

        private void TellTime()
            => MessageBox.Show(DateTime.Now.ToLongDateString(), "TIME");

        private void button2_Click(object sender, EventArgs e)
            => TellTime();
    }
}