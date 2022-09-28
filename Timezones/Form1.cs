namespace Timezones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(this, new EventArgs());
        }
        bool state = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += (s, e) => Time.Text = state ? DateTime.Now.ToLongTimeString() : DateTime.UtcNow.ToLongTimeString();
        }

        private void cityChange_Click(object sender, EventArgs e)
        {
            state = !state;
            BackgroundImage = state ? Properties.Resources.Baku : Properties.Resources.London;
        }

        
    }
}