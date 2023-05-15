namespace Aplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            => TellTime();

        private void TellTime()
            => MessageBox.Show(DateTime.Now.ToLongTimeString(), "TIME");
    }
}