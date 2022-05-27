namespace PrvniWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Text = "Žena";
            label1.ForeColor = Color.White;
            pictureBox1.BackColor = Color.Red;
        }

        private void ZkontrolujPohlavi() {
            if (radioButton1.Checked)
            {
                label1.Text = "Žena";
            }
            else {
                label1.Text = "Muž";
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            ZkontrolujPohlavi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            //pictureBox1.Location = e.Loca
            PohniKostkou();
            pictureBox1.Focus();
        }
        private void PohniKostkou() {
            if (pictureBox1.Location.X > this.Width)
            {
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
            }
            else {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
            }
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { 
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+5);
            }
        }
    }
}