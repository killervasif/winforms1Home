namespace NaughtyLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool state = false;
        private void NaughtyLabel_MouseHover(object sender, EventArgs e)
        {
            (sender as Label)!.Location = new Point(Random.Shared.Next(Size.Width - 200), Random.Shared.Next(Size.Height - 200));
            NaughtyLabel.Text = state ? "Get away from me" : "Leave me alone";
            state = !state;
        }
    }
}